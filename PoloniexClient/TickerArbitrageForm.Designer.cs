﻿using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace CryptoMarketClient {
    partial class TickerArbitrageForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TickerArbitrageForm));
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StepAreaSeriesView stepAreaSeriesView1 = new DevExpress.XtraCharts.StepAreaSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StepAreaSeriesView stepAreaSeriesView2 = new DevExpress.XtraCharts.StepAreaSeriesView();
            this.colEarning = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEarningUSD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tickerArbitrageInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIsSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colBaseCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarketCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastUpdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTickers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLowestAskTicker = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHighestBidTicker = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLowestAskHost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHighestBidHost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLowestAsk = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHighestBid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSpread = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBuyTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLowestAksFee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHighestBidFee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalFee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbShowDetail = new DevExpress.XtraBars.BarCheckItem();
            this.bbAllCurrencies = new DevExpress.XtraBars.BarCheckItem();
            this.bcShowOrderBook = new DevExpress.XtraBars.BarCheckItem();
            this.bbTryArbitrage = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bbMonitorSelected = new DevExpress.XtraBars.BarCheckItem();
            this.bbOpenWeb = new DevExpress.XtraBars.BarButtonItem();
            this.rpPoloniex = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.arbitrageHistoryChart = new DevExpress.XtraCharts.ChartControl();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.chartSidePanel = new DevExpress.XtraEditors.SidePanel();
            this.orderBookSidePanel = new DevExpress.XtraEditors.SidePanel();
            this.orderBookControl1 = new CryptoMarketClient.OrderBookControl();
            this.bbSelectPositive = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickerArbitrageInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arbitrageHistoryChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stepAreaSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stepAreaSeriesView2)).BeginInit();
            this.sidePanel1.SuspendLayout();
            this.chartSidePanel.SuspendLayout();
            this.orderBookSidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // colEarning
            // 
            this.colEarning.DisplayFormat.FormatString = "0.########";
            this.colEarning.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colEarning.FieldName = "Earning";
            this.colEarning.Name = "colEarning";
            this.colEarning.OptionsColumn.AllowEdit = false;
            this.colEarning.OptionsColumn.ReadOnly = true;
            this.colEarning.Visible = true;
            this.colEarning.VisibleIndex = 14;
            // 
            // colIsActual
            // 
            this.colIsActual.Caption = "IsActual";
            this.colIsActual.FieldName = "IsActual";
            this.colIsActual.Name = "colIsActual";
            this.colIsActual.OptionsColumn.AllowEdit = false;
            // 
            // colEarningUSD
            // 
            this.colEarningUSD.Caption = "In USD";
            this.colEarningUSD.DisplayFormat.FormatString = "0.########";
            this.colEarningUSD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colEarningUSD.FieldName = "EarningUSD";
            this.colEarningUSD.Name = "colEarningUSD";
            this.colEarningUSD.OptionsColumn.AllowEdit = false;
            this.colEarningUSD.OptionsColumn.ReadOnly = true;
            this.colEarningUSD.Visible = true;
            this.colEarningUSD.VisibleIndex = 15;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tickerArbitrageInfoBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(6);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1022, 718);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tickerArbitrageInfoBindingSource
            // 
            this.tickerArbitrageInfoBindingSource.DataSource = typeof(CryptoMarketClient.TickerArbitrageInfo);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIsSelected,
            this.colBaseCurrency,
            this.colMarketCurrency,
            this.colLastUpdate,
            this.colUpdateTime,
            this.colIsActual,
            this.colTickers,
            this.colCount,
            this.colLowestAskTicker,
            this.colHighestBidTicker,
            this.colLowestAskHost,
            this.colHighestBidHost,
            this.colLowestAsk,
            this.colHighestBid,
            this.colSpread,
            this.colAmount,
            this.colBuyTotal,
            this.colTotal,
            this.colLowestAksFee,
            this.colHighestBidFee,
            this.colTotalFee,
            this.colEarning,
            this.colEarningUSD});
            gridFormatRule1.Column = this.colEarning;
            gridFormatRule1.ColumnApplyTo = this.colEarning;
            gridFormatRule1.Name = "ArbitrageSpreadRule";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Greater;
            formatConditionRuleValue1.Value1 = 0D;
            gridFormatRule1.Rule = formatConditionRuleValue1;
            gridFormatRule2.Column = this.colIsActual;
            gridFormatRule2.ColumnApplyTo = this.colUpdateTime;
            gridFormatRule2.Name = "FormatNotActual";
            formatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            formatConditionRuleValue2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            formatConditionRuleValue2.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue2.Appearance.Options.UseForeColor = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
            formatConditionRuleValue2.Value1 = false;
            gridFormatRule2.Rule = formatConditionRuleValue2;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.FormatRules.Add(gridFormatRule2);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.KeepFocusedRowOnUpdate = false;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colSpread, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // colIsSelected
            // 
            this.colIsSelected.Caption = "Selected";
            this.colIsSelected.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colIsSelected.FieldName = "IsSelected";
            this.colIsSelected.Name = "colIsSelected";
            this.colIsSelected.Visible = true;
            this.colIsSelected.VisibleIndex = 0;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // colBaseCurrency
            // 
            this.colBaseCurrency.Caption = "Base";
            this.colBaseCurrency.FieldName = "BaseCurrency";
            this.colBaseCurrency.Name = "colBaseCurrency";
            this.colBaseCurrency.OptionsColumn.AllowEdit = false;
            this.colBaseCurrency.Visible = true;
            this.colBaseCurrency.VisibleIndex = 1;
            // 
            // colMarketCurrency
            // 
            this.colMarketCurrency.Caption = "Market";
            this.colMarketCurrency.FieldName = "MarketCurrency";
            this.colMarketCurrency.Name = "colMarketCurrency";
            this.colMarketCurrency.OptionsColumn.AllowEdit = false;
            this.colMarketCurrency.Visible = true;
            this.colMarketCurrency.VisibleIndex = 2;
            // 
            // colLastUpdate
            // 
            this.colLastUpdate.DisplayFormat.FormatString = "HH:mm:ss.fff";
            this.colLastUpdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colLastUpdate.FieldName = "LastUpdate";
            this.colLastUpdate.Name = "colLastUpdate";
            this.colLastUpdate.OptionsColumn.AllowEdit = false;
            this.colLastUpdate.Visible = true;
            this.colLastUpdate.VisibleIndex = 3;
            // 
            // colUpdateTime
            // 
            this.colUpdateTime.Caption = "UpdateTime Ms";
            this.colUpdateTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUpdateTime.FieldName = "UpdateTimeMs";
            this.colUpdateTime.Name = "colUpdateTime";
            this.colUpdateTime.OptionsColumn.AllowEdit = false;
            this.colUpdateTime.Visible = true;
            this.colUpdateTime.VisibleIndex = 4;
            // 
            // colTickers
            // 
            this.colTickers.FieldName = "Tickers";
            this.colTickers.Name = "colTickers";
            this.colTickers.OptionsColumn.AllowEdit = false;
            this.colTickers.OptionsColumn.ReadOnly = true;
            // 
            // colCount
            // 
            this.colCount.FieldName = "Count";
            this.colCount.Name = "colCount";
            this.colCount.OptionsColumn.AllowEdit = false;
            this.colCount.OptionsColumn.ReadOnly = true;
            // 
            // colLowestAskTicker
            // 
            this.colLowestAskTicker.FieldName = "LowestAskTicker";
            this.colLowestAskTicker.Name = "colLowestAskTicker";
            this.colLowestAskTicker.OptionsColumn.AllowEdit = false;
            this.colLowestAskTicker.OptionsColumn.ReadOnly = true;
            // 
            // colHighestBidTicker
            // 
            this.colHighestBidTicker.FieldName = "HighestBidTicker";
            this.colHighestBidTicker.Name = "colHighestBidTicker";
            this.colHighestBidTicker.OptionsColumn.AllowEdit = false;
            this.colHighestBidTicker.OptionsColumn.ReadOnly = true;
            // 
            // colLowestAskHost
            // 
            this.colLowestAskHost.Caption = "Buy On";
            this.colLowestAskHost.FieldName = "LowestAskHost";
            this.colLowestAskHost.Name = "colLowestAskHost";
            this.colLowestAskHost.OptionsColumn.AllowEdit = false;
            this.colLowestAskHost.OptionsColumn.ReadOnly = true;
            this.colLowestAskHost.Visible = true;
            this.colLowestAskHost.VisibleIndex = 5;
            // 
            // colHighestBidHost
            // 
            this.colHighestBidHost.Caption = "Sell On";
            this.colHighestBidHost.FieldName = "HighestBidHost";
            this.colHighestBidHost.Name = "colHighestBidHost";
            this.colHighestBidHost.OptionsColumn.AllowEdit = false;
            this.colHighestBidHost.OptionsColumn.ReadOnly = true;
            this.colHighestBidHost.Visible = true;
            this.colHighestBidHost.VisibleIndex = 6;
            // 
            // colLowestAsk
            // 
            this.colLowestAsk.DisplayFormat.FormatString = "0.########";
            this.colLowestAsk.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLowestAsk.FieldName = "LowestAsk";
            this.colLowestAsk.Name = "colLowestAsk";
            this.colLowestAsk.OptionsColumn.AllowEdit = false;
            this.colLowestAsk.OptionsColumn.ReadOnly = true;
            this.colLowestAsk.Visible = true;
            this.colLowestAsk.VisibleIndex = 7;
            // 
            // colHighestBid
            // 
            this.colHighestBid.DisplayFormat.FormatString = "0.########";
            this.colHighestBid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colHighestBid.FieldName = "HighestBid";
            this.colHighestBid.Name = "colHighestBid";
            this.colHighestBid.OptionsColumn.AllowEdit = false;
            this.colHighestBid.OptionsColumn.ReadOnly = true;
            this.colHighestBid.Visible = true;
            this.colHighestBid.VisibleIndex = 8;
            // 
            // colSpread
            // 
            this.colSpread.DisplayFormat.FormatString = "0.#########";
            this.colSpread.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSpread.FieldName = "Spread";
            this.colSpread.Name = "colSpread";
            this.colSpread.OptionsColumn.AllowEdit = false;
            this.colSpread.Visible = true;
            this.colSpread.VisibleIndex = 9;
            // 
            // colAmount
            // 
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsColumn.AllowEdit = false;
            this.colAmount.OptionsColumn.ReadOnly = true;
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 10;
            // 
            // colBuyTotal
            // 
            this.colBuyTotal.DisplayFormat.FormatString = "0.########";
            this.colBuyTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBuyTotal.FieldName = "BuyTotal";
            this.colBuyTotal.Name = "colBuyTotal";
            this.colBuyTotal.OptionsColumn.AllowEdit = false;
            this.colBuyTotal.Visible = true;
            this.colBuyTotal.VisibleIndex = 11;
            // 
            // colTotal
            // 
            this.colTotal.DisplayFormat.FormatString = "0.########";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.OptionsColumn.AllowEdit = false;
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 12;
            // 
            // colLowestAksFee
            // 
            this.colLowestAksFee.FieldName = "LowestAksFee";
            this.colLowestAksFee.Name = "colLowestAksFee";
            this.colLowestAksFee.OptionsColumn.AllowEdit = false;
            this.colLowestAksFee.OptionsColumn.ReadOnly = true;
            // 
            // colHighestBidFee
            // 
            this.colHighestBidFee.FieldName = "HighestBidFee";
            this.colHighestBidFee.Name = "colHighestBidFee";
            this.colHighestBidFee.OptionsColumn.AllowEdit = false;
            this.colHighestBidFee.OptionsColumn.ReadOnly = true;
            // 
            // colTotalFee
            // 
            this.colTotalFee.DisplayFormat.FormatString = "0.########";
            this.colTotalFee.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalFee.FieldName = "TotalFee";
            this.colTotalFee.Name = "colTotalFee";
            this.colTotalFee.OptionsColumn.AllowEdit = false;
            this.colTotalFee.OptionsColumn.ReadOnly = true;
            this.colTotalFee.Visible = true;
            this.colTotalFee.VisibleIndex = 13;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AllowGlyphSkinning = true;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bbShowDetail,
            this.bbAllCurrencies,
            this.bcShowOrderBook,
            this.bbTryArbitrage,
            this.barButtonItem1,
            this.bbMonitorSelected,
            this.bbOpenWeb,
            this.bbSelectPositive});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(6);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpPoloniex});
            this.ribbonControl1.Size = new System.Drawing.Size(2004, 278);
            // 
            // bbShowDetail
            // 
            this.bbShowDetail.Caption = "Show Chart";
            this.bbShowDetail.Id = 1;
            this.bbShowDetail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbShowDetail.ImageOptions.Image")));
            this.bbShowDetail.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbShowDetail.ImageOptions.LargeImage")));
            this.bbShowDetail.Name = "bbShowDetail";
            this.bbShowDetail.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bbShowDetail_CheckedChanged);
            // 
            // bbAllCurrencies
            // 
            this.bbAllCurrencies.Caption = "Show Positive Earnings";
            this.bbAllCurrencies.Id = 3;
            this.bbAllCurrencies.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbAllCurrencies.ImageOptions.Image")));
            this.bbAllCurrencies.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbAllCurrencies.ImageOptions.LargeImage")));
            this.bbAllCurrencies.Name = "bbAllCurrencies";
            this.bbAllCurrencies.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bbAllCurrencies_CheckedChanged);
            // 
            // bcShowOrderBook
            // 
            this.bcShowOrderBook.Caption = "Show Combined OrderBook";
            this.bcShowOrderBook.Id = 4;
            this.bcShowOrderBook.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bcShowOrderBook.ImageOptions.Image")));
            this.bcShowOrderBook.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bcShowOrderBook.ImageOptions.LargeImage")));
            this.bcShowOrderBook.Name = "bcShowOrderBook";
            this.bcShowOrderBook.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.bcShowOrderBook_CheckedChanged);
            // 
            // bbTryArbitrage
            // 
            this.bbTryArbitrage.Caption = "Try Arbitrage!";
            this.bbTryArbitrage.Id = 5;
            this.bbTryArbitrage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbTryArbitrage.ImageOptions.Image")));
            this.bbTryArbitrage.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbTryArbitrage.ImageOptions.LargeImage")));
            this.bbTryArbitrage.Name = "bbTryArbitrage";
            this.bbTryArbitrage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbTryArbitrage_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Monitor only Seelcted Arbitrage";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bbMonitorSelected
            // 
            this.bbMonitorSelected.Caption = "Monitor Only Selected Arbitrages";
            this.bbMonitorSelected.Id = 7;
            this.bbMonitorSelected.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbMonitorSelected.ImageOptions.Image")));
            this.bbMonitorSelected.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbMonitorSelected.ImageOptions.LargeImage")));
            this.bbMonitorSelected.Name = "bbMonitorSelected";
            // 
            // bbOpenWeb
            // 
            this.bbOpenWeb.Caption = "Open Markets in Web";
            this.bbOpenWeb.Id = 8;
            this.bbOpenWeb.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbOpenWeb.ImageOptions.Image")));
            this.bbOpenWeb.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbOpenWeb.ImageOptions.LargeImage")));
            this.bbOpenWeb.Name = "bbOpenWeb";
            this.bbOpenWeb.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbOpenWeb_ItemClick);
            // 
            // rpPoloniex
            // 
            this.rpPoloniex.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rpPoloniex.Name = "rpPoloniex";
            this.rpPoloniex.Text = "Connect";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbShowDetail);
            this.ribbonPageGroup1.ItemLinks.Add(this.bcShowOrderBook);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbAllCurrencies, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbSelectPositive);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbMonitorSelected);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbOpenWeb);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbTryArbitrage);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Arbitrage";
            // 
            // arbitrageHistoryChart
            // 
            this.arbitrageHistoryChart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.arbitrageHistoryChart.DataBindings = null;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisX.WholeRange.SideMarginsValue = 0D;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.arbitrageHistoryChart.Diagram = xyDiagram1;
            this.arbitrageHistoryChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arbitrageHistoryChart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.arbitrageHistoryChart.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.arbitrageHistoryChart.Legend.MarkerMode = DevExpress.XtraCharts.LegendMarkerMode.CheckBoxAndMarker;
            this.arbitrageHistoryChart.Legend.Name = "Default Legend";
            this.arbitrageHistoryChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.arbitrageHistoryChart.Location = new System.Drawing.Point(1, 0);
            this.arbitrageHistoryChart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.arbitrageHistoryChart.Name = "arbitrageHistoryChart";
            series1.ArgumentDataMember = "Time";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series1.LegendText = "Earnings in USD";
            series1.Name = "Earnings in USD";
            series1.ValueDataMembersSerializable = "ValueUSD";
            series1.View = stepAreaSeriesView1;
            series2.ArgumentDataMember = "Time";
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series2.LegendText = "Earnings in base currency";
            series2.Name = "Earnings in base currency";
            series2.ValueDataMembersSerializable = "Value";
            series2.View = stepAreaSeriesView2;
            this.arbitrageHistoryChart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.arbitrageHistoryChart.Size = new System.Drawing.Size(529, 718);
            this.arbitrageHistoryChart.TabIndex = 5;
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.gridControl1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel1.Location = new System.Drawing.Point(0, 278);
            this.sidePanel1.Margin = new System.Windows.Forms.Padding(4);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(1022, 718);
            this.sidePanel1.TabIndex = 6;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // chartSidePanel
            // 
            this.chartSidePanel.Controls.Add(this.arbitrageHistoryChart);
            this.chartSidePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.chartSidePanel.Location = new System.Drawing.Point(1474, 278);
            this.chartSidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.chartSidePanel.Name = "chartSidePanel";
            this.chartSidePanel.Size = new System.Drawing.Size(530, 718);
            this.chartSidePanel.TabIndex = 7;
            this.chartSidePanel.Text = "sidePanel2";
            // 
            // orderBookSidePanel
            // 
            this.orderBookSidePanel.Controls.Add(this.orderBookControl1);
            this.orderBookSidePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.orderBookSidePanel.Location = new System.Drawing.Point(1022, 278);
            this.orderBookSidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.orderBookSidePanel.Name = "orderBookSidePanel";
            this.orderBookSidePanel.Size = new System.Drawing.Size(452, 718);
            this.orderBookSidePanel.TabIndex = 9;
            this.orderBookSidePanel.Text = "sidePanel2";
            // 
            // orderBookControl1
            // 
            this.orderBookControl1.ArbitrageInfo = null;
            this.orderBookControl1.Asks = null;
            this.orderBookControl1.Bids = null;
            this.orderBookControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderBookControl1.Location = new System.Drawing.Point(1, 0);
            this.orderBookControl1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.orderBookControl1.Name = "orderBookControl1";
            this.orderBookControl1.OrderBookCaption = "";
            this.orderBookControl1.Size = new System.Drawing.Size(451, 718);
            this.orderBookControl1.TabIndex = 0;
            // 
            // bbSelectPositive
            // 
            this.bbSelectPositive.Caption = "Select Positive Arbitrages";
            this.bbSelectPositive.Id = 9;
            this.bbSelectPositive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbSelectPositive.ImageOptions.Image")));
            this.bbSelectPositive.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbSelectPositive.ImageOptions.LargeImage")));
            this.bbSelectPositive.Name = "bbSelectPositive";
            this.bbSelectPositive.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbSelectPositive_ItemClick);
            // 
            // TickerArbitrageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2004, 996);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.orderBookSidePanel);
            this.Controls.Add(this.chartSidePanel);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TickerArbitrageForm";
            this.Text = "Classic Arbitrage";
            this.Load += new System.EventHandler(this.TickerArbitrageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickerArbitrageInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stepAreaSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stepAreaSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arbitrageHistoryChart)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.chartSidePanel.ResumeLayout(false);
            this.orderBookSidePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GridControl gridControl1;
        private GridView gridView1;
        private System.Windows.Forms.BindingSource tickerArbitrageInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colBaseCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colMarketCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colTickers;
        private DevExpress.XtraGrid.Columns.GridColumn colCount;
        private DevExpress.XtraGrid.Columns.GridColumn colLowestAskTicker;
        private DevExpress.XtraGrid.Columns.GridColumn colHighestBidTicker;
        private DevExpress.XtraGrid.Columns.GridColumn colLowestAskHost;
        private DevExpress.XtraGrid.Columns.GridColumn colHighestBidHost;
        private DevExpress.XtraGrid.Columns.GridColumn colLowestAsk;
        private DevExpress.XtraGrid.Columns.GridColumn colHighestBid;
        private DevExpress.XtraGrid.Columns.GridColumn colSpread;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colLowestAksFee;
        private DevExpress.XtraGrid.Columns.GridColumn colHighestBidFee;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalFee;
        private DevExpress.XtraGrid.Columns.GridColumn colEarning;
        private DevExpress.XtraGrid.Columns.GridColumn colEarningUSD;
        private DevExpress.XtraGrid.Columns.GridColumn colBuyTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colLastUpdate;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpPoloniex;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarCheckItem bbShowDetail;
        private DevExpress.XtraCharts.ChartControl arbitrageHistoryChart;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.SidePanel chartSidePanel;
        private DevExpress.XtraBars.BarCheckItem bbAllCurrencies;
        private DevExpress.XtraBars.BarCheckItem bcShowOrderBook;
        private DevExpress.XtraEditors.SidePanel orderBookSidePanel;
        private OrderBookControl orderBookControl1;
        private DevExpress.XtraBars.BarButtonItem bbTryArbitrage;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdateTime;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActual;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarCheckItem bbMonitorSelected;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSelected;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraBars.BarButtonItem bbOpenWeb;
        private DevExpress.XtraBars.BarButtonItem bbSelectPositive;
    }
}