﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;
using WampSharp.Binding;
using WampSharp.V2;
using WampSharp.V2.Rpc;

namespace CryptoMarketClient {
    public class PoloniexModel : ModelBase {
        const string PoloniexServerAddress = "wss://api.poloniex.com";

        static PoloniexModel defaultModel;
        public static PoloniexModel Default {
            get {
                if(defaultModel == null) {
                    defaultModel = new PoloniexModel();
                    defaultModel.Load();
                }
                return defaultModel;
            }
        }

        public override string Name => "Poloniex";

        List<PoloniexTicker> tickers;
        public List<PoloniexTicker> Tickers {
            get {
                if(tickers == null)
                    tickers = new List<PoloniexTicker>();
                return tickers;
            }
        }

        protected IDisposable TickersSubscriber { get; set; }
        public void Connect() {
            if(TickersSubscriber != null)
                return;
            TickersSubscriber = SubscribeToTicker();
        }

        private IDisposable SubscribeToTicker() {
            DefaultWampChannelFactory channelFactory =
                new DefaultWampChannelFactory();

            IWampChannel wampChannel = channelFactory.CreateJsonChannel(PoloniexServerAddress, "realm1");
            wampChannel.Open().Wait();

            ISubject<PoloniexTicker> subject = wampChannel.RealmProxy.Services.GetSubject<PoloniexTicker>("ticker", new PoloniexTickerConverter());
            IDisposable disposable = subject.Subscribe(x => GetTickerItem(x));

            return disposable;
        }


        private void GetTickerItem(PoloniexTicker item) {
            lock(Tickers) {
                PoloniexTicker t = Tickers.FirstOrDefault((i) => i.CurrencyPair == item.CurrencyPair);
                if(t != null) {
                    lock(t) {
                        t.Assign(item);
                        t.UpdateHistoryItem();
                        RaiseTickerUpdate(t);
                    }
                }
                else {
                    Tickers.Add(item);
                    RaiseTickerUpdate(item);
                }
            }
        }

        public event TickerUpdateEventHandler TickerUpdate;
        protected void RaiseTickerUpdate(PoloniexTicker t) {
            TickerUpdateEventArgs e = new TickerUpdateEventArgs() { Ticker = t };
            if(TickerUpdate != null)
                TickerUpdate(this, e);
            t.RaiseChanged();
        }
        public IDisposable ConnectOrderBook(PoloniexTicker ticker) {
            ticker.OrderBook.Updates.Clear();
            DefaultWampChannelFactory channelFactory =
               new DefaultWampChannelFactory();

            IWampChannel wampChannel = channelFactory.CreateJsonChannel(PoloniexServerAddress, "realm1");
            wampChannel.Open().Wait();

            ISubject<OrderBookUpdateInfo> subject = wampChannel.RealmProxy.Services.GetSubject<OrderBookUpdateInfo>(ticker.OrderBook.Owner.Name, new OrderBookUpdateInfoConverter());
            return subject.Subscribe(x => ticker.OrderBook.OnRecvUpdate(x));
        }
        
        public void GetTickersInfo() {
            string address = "https://poloniex.com/public?command=returnTicker";
            string text = GetDownloadString(address);
            if(string.IsNullOrEmpty(text))
                return;
            Tickers.Clear();
            JObject res = (JObject)JsonConvert.DeserializeObject(text);
            int index = 0;
            foreach(JProperty prop in res.Children()) {
                PoloniexTicker t = new PoloniexTicker();
                t.Index = index;
                t.CurrencyPair = prop.Name;
                JObject obj = (JObject)prop.Value;
                t.Id = obj.Value<int>("id");
                t.Last = obj.Value<double>("last");
                t.LowestAsk = obj.Value<double>("lowestAsk");
                t.HighestBid = obj.Value<double>("highestBid");
                t.Change = obj.Value<double>("percentChange");
                t.BaseVolume = obj.Value<double>("baseVolume");
                t.Volume = obj.Value<double>("quoteVolume");
                t.IsFrozen = obj.Value<int>("isFrozen") != 0;
                t.Hr24High = obj.Value<double>("high24hr");
                t.Hr24Low = obj.Value<double>("low24hr");
                Tickers.Add(t);
                index++;
            }
        }
        public void UpdateTickersInfo() {
            string address = "https://poloniex.com/public?command=returnTicker";
            string text = GetDownloadString(address);
            if(string.IsNullOrEmpty(text))
                return;
            JObject res = (JObject)JsonConvert.DeserializeObject(text);
            foreach(JProperty prop in res.Children()) {
                PoloniexTicker t = Tickers.FirstOrDefault((i) => i.CurrencyPair == prop.Name);
                JObject obj = (JObject)prop.Value;
                t.Last = obj.Value<double>("last");
                t.LowestAsk = obj.Value<double>("lowestAsk");
                t.HighestBid = obj.Value<double>("highestBid");
                t.Change = obj.Value<double>("percentChange");
                t.BaseVolume = obj.Value<double>("baseVolume");
                t.Volume = obj.Value<double>("quoteVolume");
                t.IsFrozen = obj.Value<int>("isFrozen") != 0;
                t.Hr24High = obj.Value<double>("high24hr");
                t.Hr24Low = obj.Value<double>("low24hr");
            }
        }
        public string GetOrderBookString(PoloniexTicker ticker, int depth) {
            return string.Format("https://poloniex.com/public?command=returnOrderBook&currencyPair={0}&depth={1}",
                Uri.EscapeDataString(ticker.CurrencyPair), depth);
        }
        public void UpdateOrderBook(PoloniexTicker ticker, string text) {
            ticker.OrderBook.Bids.Clear();
            ticker.OrderBook.Asks.Clear();

            JObject res = (JObject)JsonConvert.DeserializeObject(text);
            foreach(JProperty prop in res.Children()) {
                if(prop.Name == "asks" || prop.Name == "bids") {
                    OrderBookEntryType type = prop.Name == "asks" ? OrderBookEntryType.Ask : OrderBookEntryType.Bid;
                    JArray items = prop.Value.ToObject<JArray>();
                    foreach(JArray item in items.Children()) {
                        OrderBookUpdateInfo info = new OrderBookUpdateInfo();
                        info.Type = type;
                        info.Entry = new OrderBookEntry();
                        info.Action = OrderBookUpdateType.Modify;
                        JEnumerable<JToken> values = (JEnumerable<JToken>)item.Children();
                        JValue rateValue = (JValue)values.First();
                        info.Entry.Value = rateValue.ToObject<double>();
                        info.Entry.Amount = rateValue.Next.ToObject<double>();
                        if(type == OrderBookEntryType.Ask)
                            ticker.OrderBook.ForceAddAsk(info);
                        else
                            ticker.OrderBook.ForceAddBid(info);
                    }
                }
                else if(prop.Name == "seq") {
                    ticker.OrderBook.SeqNumber = prop.Value.ToObject<int>();
                    //Console.WriteLine("Snapshot seq no = " + ticker.OrderBook.SeqNumber);
                }
                else if(prop.Name == "isFrozen") {
                    ticker.IsFrozen = prop.Value.ToObject<int>() == 0;
                }
            }
            ticker.OrderBook.ApplyQueueUpdates();
            ticker.OrderBook.RaiseOnChanged(new OrderBookUpdateInfo() { Action = OrderBookUpdateType.RefreshAll });
        }
        public void GetOrderBook(PoloniexTicker ticker, int depth) {
            string address = string.Format("https://poloniex.com/public?command=returnOrderBook&currencyPair={0}&depth={1}",
                Uri.EscapeDataString(ticker.CurrencyPair), depth);
            string text = ((ITicker)ticker).DownloadString(address);
            if(string.IsNullOrEmpty(text))
                return;
            UpdateOrderBook(ticker, text);
        }
        protected List<TradeHistoryItem> UpdateList { get; } = new List<TradeHistoryItem>(100);
        public void UpdateTrades(PoloniexTicker ticker) {
            string address = string.Format("https://poloniex.com/public?command=returnTradeHistory&currencyPair={0}", Uri.EscapeDataString(ticker.CurrencyPair));
            string text = GetDownloadString(address);
            if(string.IsNullOrEmpty(text))
                return;
            ticker.TradeHistory.Clear();
            JArray trades = (JArray)JsonConvert.DeserializeObject(text);
            foreach(JObject obj in trades) {
                TradeHistoryItem item = new TradeHistoryItem();
                item.Time = obj.Value<DateTime>("time");
                item.Amount = obj.Value<double>("amount");
                item.Rate = obj.Value<double>("rate");
                item.Total = obj.Value<double>("total");
                item.Type = obj.Value<string>("type") == "buy" ? TradeType.Buy : TradeType.Sell;
                item.Fill = TradeFillType.Fill;
                TickerUpdateHelper.UpdateHistoryForTradeItem(item, ticker);
                ticker.TradeHistory.Add(item);
            }
        }
        public void GetTicker(ITicker ticker) {
            throw new NotImplementedException();
        }
    }

    public delegate void TickerUpdateEventHandler(object sender, TickerUpdateEventArgs e);
    public class TickerUpdateEventArgs : EventArgs {
        public PoloniexTicker Ticker { get; set; }
    }
 }
