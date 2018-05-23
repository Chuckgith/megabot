﻿namespace FormConsole
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabsExchanges = new System.Windows.Forms.TabControl();
            this.tabPoloniex = new System.Windows.Forms.TabPage();
            this.tabsMarkets = new System.Windows.Forms.TabControl();
            this.tabUsdt = new System.Windows.Forms.TabPage();
            this.lbCoins = new System.Windows.Forms.ListBox();
            this.tabBtc = new System.Windows.Forms.TabPage();
            this.tabEth = new System.Windows.Forms.TabPage();
            this.tabXmr = new System.Windows.Forms.TabPage();
            this.grbCoinSelectedBalances = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblValueMultiplicator = new System.Windows.Forms.Label();
            this.trbMultiplicator = new System.Windows.Forms.TrackBar();
            this.lblValueTolerance = new System.Windows.Forms.Label();
            this.trbTolerance = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBotAmount = new System.Windows.Forms.TextBox();
            this.lblLossTolerance = new System.Windows.Forms.Label();
            this.lblBalancesQuote = new System.Windows.Forms.Label();
            this.lblBalancesBase = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBalancesTitleQuote = new System.Windows.Forms.Label();
            this.lblBalancesTitleBase = new System.Windows.Forms.Label();
            this.btnStartBot = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBalances = new System.Windows.Forms.DataGridView();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoteAvailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoteOnOrdersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSDTValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabBinance = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.grbTrade = new System.Windows.Forms.GroupBox();
            this.gbBuy = new System.Windows.Forms.GroupBox();
            this.lblBalanceBuy = new System.Windows.Forms.Label();
            this.lblBalanceTitleBuy = new System.Windows.Forms.Label();
            this.txtBuyTotalUsdt = new System.Windows.Forms.TextBox();
            this.lblTotalUsdt = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.txtBuyTotal = new System.Windows.Forms.TextBox();
            this.lblBuyTotal = new System.Windows.Forms.Label();
            this.btnBuy100 = new System.Windows.Forms.Button();
            this.btnBuy75 = new System.Windows.Forms.Button();
            this.btnBuy50 = new System.Windows.Forms.Button();
            this.btnBuy25 = new System.Windows.Forms.Button();
            this.txtBuyAmountUsdt = new System.Windows.Forms.TextBox();
            this.lblBuyAmountUsdt = new System.Windows.Forms.Label();
            this.txtBuyAmount = new System.Windows.Forms.TextBox();
            this.lblBuyAmount = new System.Windows.Forms.Label();
            this.txtBuyPriceUsdt = new System.Windows.Forms.TextBox();
            this.lblBuyPriceUsdt = new System.Windows.Forms.Label();
            this.txtBuyPrice = new System.Windows.Forms.TextBox();
            this.lblBuyPrice = new System.Windows.Forms.Label();
            this.gbSell = new System.Windows.Forms.GroupBox();
            this.lblBalanceTitleSell = new System.Windows.Forms.Label();
            this.lblBalanceSell = new System.Windows.Forms.Label();
            this.txtSellTotalUsdt = new System.Windows.Forms.TextBox();
            this.lblSellTotalUsdt = new System.Windows.Forms.Label();
            this.btnSell = new System.Windows.Forms.Button();
            this.txtSellTotal = new System.Windows.Forms.TextBox();
            this.lblSellTotal = new System.Windows.Forms.Label();
            this.btnSell100 = new System.Windows.Forms.Button();
            this.txtSellAmountUsdt = new System.Windows.Forms.TextBox();
            this.btnSell75 = new System.Windows.Forms.Button();
            this.btnSell50 = new System.Windows.Forms.Button();
            this.lblSellAmountUsdt = new System.Windows.Forms.Label();
            this.btnSell25 = new System.Windows.Forms.Button();
            this.txtSellAmount = new System.Windows.Forms.TextBox();
            this.lblSellAmount = new System.Windows.Forms.Label();
            this.txtSellPriceUsdt = new System.Windows.Forms.TextBox();
            this.lblSellPriceUsdt = new System.Windows.Forms.Label();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.lblSellPrice = new System.Windows.Forms.Label();
            this.dgvCurrentTrades = new System.Windows.Forms.DataGridView();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvClosedTrades = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Total = new System.Windows.Forms.Label();
            this.balanceModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.currencyPairDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lossToleranceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lossToleranceMultiplicatorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usdtValueDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePaidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceLastDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highestProfitDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highestProfitDiffDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toleranceProfitHighDiffDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeBuyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastTickerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flatTradeModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currencyPairDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lossToleranceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lossToleranceMultiplicatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usdtValueDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceLastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highestProfitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highestProfitDiffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toleranceProfitHighDiffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeBuyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastTickerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabsExchanges.SuspendLayout();
            this.tabPoloniex.SuspendLayout();
            this.tabsMarkets.SuspendLayout();
            this.tabUsdt.SuspendLayout();
            this.grbCoinSelectedBalances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbMultiplicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTolerance)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalances)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.grbTrade.SuspendLayout();
            this.gbBuy.SuspendLayout();
            this.gbSell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentTrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClosedTrades)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balanceModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatTradeModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabsExchanges
            // 
            this.tabsExchanges.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabsExchanges.Controls.Add(this.tabPoloniex);
            this.tabsExchanges.Controls.Add(this.tabBinance);
            this.tabsExchanges.Location = new System.Drawing.Point(12, 12);
            this.tabsExchanges.Multiline = true;
            this.tabsExchanges.Name = "tabsExchanges";
            this.tabsExchanges.SelectedIndex = 0;
            this.tabsExchanges.Size = new System.Drawing.Size(492, 435);
            this.tabsExchanges.TabIndex = 0;
            // 
            // tabPoloniex
            // 
            this.tabPoloniex.Controls.Add(this.tabsMarkets);
            this.tabPoloniex.Controls.Add(this.grbCoinSelectedBalances);
            this.tabPoloniex.Controls.Add(this.groupBox2);
            this.tabPoloniex.Location = new System.Drawing.Point(23, 4);
            this.tabPoloniex.Name = "tabPoloniex";
            this.tabPoloniex.Padding = new System.Windows.Forms.Padding(3);
            this.tabPoloniex.Size = new System.Drawing.Size(465, 427);
            this.tabPoloniex.TabIndex = 0;
            this.tabPoloniex.Text = "Poloniex";
            this.tabPoloniex.UseVisualStyleBackColor = true;
            // 
            // tabsMarkets
            // 
            this.tabsMarkets.Controls.Add(this.tabUsdt);
            this.tabsMarkets.Controls.Add(this.tabBtc);
            this.tabsMarkets.Controls.Add(this.tabEth);
            this.tabsMarkets.Controls.Add(this.tabXmr);
            this.tabsMarkets.Location = new System.Drawing.Point(6, 179);
            this.tabsMarkets.Name = "tabsMarkets";
            this.tabsMarkets.SelectedIndex = 0;
            this.tabsMarkets.Size = new System.Drawing.Size(189, 240);
            this.tabsMarkets.TabIndex = 0;
            // 
            // tabUsdt
            // 
            this.tabUsdt.BackColor = System.Drawing.Color.AliceBlue;
            this.tabUsdt.Controls.Add(this.lbCoins);
            this.tabUsdt.Location = new System.Drawing.Point(4, 22);
            this.tabUsdt.Name = "tabUsdt";
            this.tabUsdt.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsdt.Size = new System.Drawing.Size(181, 214);
            this.tabUsdt.TabIndex = 0;
            this.tabUsdt.Text = "USDT";
            // 
            // lbCoins
            // 
            this.lbCoins.FormattingEnabled = true;
            this.lbCoins.Location = new System.Drawing.Point(9, 6);
            this.lbCoins.Name = "lbCoins";
            this.lbCoins.Size = new System.Drawing.Size(166, 199);
            this.lbCoins.TabIndex = 5;
            this.lbCoins.SelectedIndexChanged += new System.EventHandler(this.lbCoins_SelectedIndexChanged);
            // 
            // tabBtc
            // 
            this.tabBtc.Location = new System.Drawing.Point(4, 22);
            this.tabBtc.Name = "tabBtc";
            this.tabBtc.Padding = new System.Windows.Forms.Padding(3);
            this.tabBtc.Size = new System.Drawing.Size(181, 214);
            this.tabBtc.TabIndex = 1;
            this.tabBtc.Text = "BTC";
            this.tabBtc.UseVisualStyleBackColor = true;
            // 
            // tabEth
            // 
            this.tabEth.Location = new System.Drawing.Point(4, 22);
            this.tabEth.Name = "tabEth";
            this.tabEth.Padding = new System.Windows.Forms.Padding(3);
            this.tabEth.Size = new System.Drawing.Size(181, 214);
            this.tabEth.TabIndex = 2;
            this.tabEth.Text = "ETH";
            this.tabEth.UseVisualStyleBackColor = true;
            // 
            // tabXmr
            // 
            this.tabXmr.Location = new System.Drawing.Point(4, 22);
            this.tabXmr.Name = "tabXmr";
            this.tabXmr.Padding = new System.Windows.Forms.Padding(3);
            this.tabXmr.Size = new System.Drawing.Size(181, 214);
            this.tabXmr.TabIndex = 3;
            this.tabXmr.Text = "XMR";
            this.tabXmr.UseVisualStyleBackColor = true;
            // 
            // grbCoinSelectedBalances
            // 
            this.grbCoinSelectedBalances.BackColor = System.Drawing.Color.AliceBlue;
            this.grbCoinSelectedBalances.Controls.Add(this.textBox1);
            this.grbCoinSelectedBalances.Controls.Add(this.label3);
            this.grbCoinSelectedBalances.Controls.Add(this.lblValueMultiplicator);
            this.grbCoinSelectedBalances.Controls.Add(this.trbMultiplicator);
            this.grbCoinSelectedBalances.Controls.Add(this.lblValueTolerance);
            this.grbCoinSelectedBalances.Controls.Add(this.trbTolerance);
            this.grbCoinSelectedBalances.Controls.Add(this.label2);
            this.grbCoinSelectedBalances.Controls.Add(this.txtBotAmount);
            this.grbCoinSelectedBalances.Controls.Add(this.lblLossTolerance);
            this.grbCoinSelectedBalances.Controls.Add(this.lblBalancesQuote);
            this.grbCoinSelectedBalances.Controls.Add(this.lblBalancesBase);
            this.grbCoinSelectedBalances.Controls.Add(this.label1);
            this.grbCoinSelectedBalances.Controls.Add(this.lblBalancesTitleQuote);
            this.grbCoinSelectedBalances.Controls.Add(this.lblBalancesTitleBase);
            this.grbCoinSelectedBalances.Controls.Add(this.btnStartBot);
            this.grbCoinSelectedBalances.Location = new System.Drawing.Point(197, 179);
            this.grbCoinSelectedBalances.Name = "grbCoinSelectedBalances";
            this.grbCoinSelectedBalances.Size = new System.Drawing.Size(262, 240);
            this.grbCoinSelectedBalances.TabIndex = 6;
            this.grbCoinSelectedBalances.TabStop = false;
            this.grbCoinSelectedBalances.Text = "Balances";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "(%)";
            // 
            // lblValueMultiplicator
            // 
            this.lblValueMultiplicator.AutoSize = true;
            this.lblValueMultiplicator.Location = new System.Drawing.Point(176, 173);
            this.lblValueMultiplicator.Name = "lblValueMultiplicator";
            this.lblValueMultiplicator.Size = new System.Drawing.Size(13, 13);
            this.lblValueMultiplicator.TabIndex = 28;
            this.lblValueMultiplicator.Text = "0";
            // 
            // trbMultiplicator
            // 
            this.trbMultiplicator.Location = new System.Drawing.Point(6, 166);
            this.trbMultiplicator.Maximum = 6;
            this.trbMultiplicator.Name = "trbMultiplicator";
            this.trbMultiplicator.Size = new System.Drawing.Size(169, 45);
            this.trbMultiplicator.TabIndex = 27;
            this.trbMultiplicator.Value = 1;
            this.trbMultiplicator.ValueChanged += new System.EventHandler(this.trbMultiplicator_ValueChanged);
            // 
            // lblValueTolerance
            // 
            this.lblValueTolerance.AutoSize = true;
            this.lblValueTolerance.Location = new System.Drawing.Point(176, 116);
            this.lblValueTolerance.Name = "lblValueTolerance";
            this.lblValueTolerance.Size = new System.Drawing.Size(13, 13);
            this.lblValueTolerance.TabIndex = 26;
            this.lblValueTolerance.Text = "0";
            // 
            // trbTolerance
            // 
            this.trbTolerance.Location = new System.Drawing.Point(4, 110);
            this.trbTolerance.Maximum = 40;
            this.trbTolerance.Minimum = 1;
            this.trbTolerance.Name = "trbTolerance";
            this.trbTolerance.Size = new System.Drawing.Size(169, 45);
            this.trbTolerance.TabIndex = 25;
            this.trbTolerance.Value = 1;
            this.trbTolerance.ValueChanged += new System.EventHandler(this.trbTolerance_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Amount";
            // 
            // txtBotAmount
            // 
            this.txtBotAmount.Location = new System.Drawing.Point(91, 66);
            this.txtBotAmount.Name = "txtBotAmount";
            this.txtBotAmount.Size = new System.Drawing.Size(82, 20);
            this.txtBotAmount.TabIndex = 23;
            this.txtBotAmount.TextChanged += new System.EventHandler(this.txtBotAmount_TextChanged);
            // 
            // lblLossTolerance
            // 
            this.lblLossTolerance.AutoSize = true;
            this.lblLossTolerance.Location = new System.Drawing.Point(11, 97);
            this.lblLossTolerance.Name = "lblLossTolerance";
            this.lblLossTolerance.Size = new System.Drawing.Size(76, 13);
            this.lblLossTolerance.TabIndex = 21;
            this.lblLossTolerance.Text = "Loss tolerance";
            // 
            // lblBalancesQuote
            // 
            this.lblBalancesQuote.AutoSize = true;
            this.lblBalancesQuote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBalancesQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalancesQuote.Location = new System.Drawing.Point(90, 43);
            this.lblBalancesQuote.Name = "lblBalancesQuote";
            this.lblBalancesQuote.Size = new System.Drawing.Size(14, 15);
            this.lblBalancesQuote.TabIndex = 20;
            this.lblBalancesQuote.Text = "0";
            // 
            // lblBalancesBase
            // 
            this.lblBalancesBase.AutoSize = true;
            this.lblBalancesBase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBalancesBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalancesBase.Location = new System.Drawing.Point(90, 20);
            this.lblBalancesBase.Name = "lblBalancesBase";
            this.lblBalancesBase.Size = new System.Drawing.Size(14, 15);
            this.lblBalancesBase.TabIndex = 19;
            this.lblBalancesBase.Text = "0";
            this.lblBalancesBase.Click += new System.EventHandler(this.lblBalancesBase_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Multiplicator";
            // 
            // lblBalancesTitleQuote
            // 
            this.lblBalancesTitleQuote.AutoSize = true;
            this.lblBalancesTitleQuote.Location = new System.Drawing.Point(11, 45);
            this.lblBalancesTitleQuote.Name = "lblBalancesTitleQuote";
            this.lblBalancesTitleQuote.Size = new System.Drawing.Size(39, 13);
            this.lblBalancesTitleQuote.TabIndex = 7;
            this.lblBalancesTitleQuote.Text = "Quote:";
            // 
            // lblBalancesTitleBase
            // 
            this.lblBalancesTitleBase.AutoSize = true;
            this.lblBalancesTitleBase.Location = new System.Drawing.Point(11, 22);
            this.lblBalancesTitleBase.Name = "lblBalancesTitleBase";
            this.lblBalancesTitleBase.Size = new System.Drawing.Size(34, 13);
            this.lblBalancesTitleBase.TabIndex = 6;
            this.lblBalancesTitleBase.Text = "Base:";
            // 
            // btnStartBot
            // 
            this.btnStartBot.Location = new System.Drawing.Point(69, 211);
            this.btnStartBot.Name = "btnStartBot";
            this.btnStartBot.Size = new System.Drawing.Size(106, 23);
            this.btnStartBot.TabIndex = 3;
            this.btnStartBot.Text = "Start bot";
            this.btnStartBot.UseVisualStyleBackColor = true;
            this.btnStartBot.Click += new System.EventHandler(this.btnStartBot_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.dgvBalances);
            this.groupBox2.Location = new System.Drawing.Point(6, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 165);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Balances";
            // 
            // dgvBalances
            // 
            this.dgvBalances.AllowUserToAddRows = false;
            this.dgvBalances.AllowUserToDeleteRows = false;
            this.dgvBalances.AllowUserToOrderColumns = true;
            this.dgvBalances.AllowUserToResizeColumns = false;
            this.dgvBalances.AllowUserToResizeRows = false;
            this.dgvBalances.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBalances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBalances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.quoteAvailableDataGridViewTextBoxColumn,
            this.quoteOnOrdersDataGridViewTextBoxColumn,
            this.uSDTValueDataGridViewTextBoxColumn});
            this.dgvBalances.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBalances.Location = new System.Drawing.Point(6, 20);
            this.dgvBalances.MultiSelect = false;
            this.dgvBalances.Name = "dgvBalances";
            this.dgvBalances.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBalances.Size = new System.Drawing.Size(368, 136);
            this.dgvBalances.TabIndex = 2;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quoteAvailableDataGridViewTextBoxColumn
            // 
            this.quoteAvailableDataGridViewTextBoxColumn.DataPropertyName = "QuoteAvailable";
            this.quoteAvailableDataGridViewTextBoxColumn.HeaderText = "QuoteAvailable";
            this.quoteAvailableDataGridViewTextBoxColumn.Name = "quoteAvailableDataGridViewTextBoxColumn";
            this.quoteAvailableDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quoteOnOrdersDataGridViewTextBoxColumn
            // 
            this.quoteOnOrdersDataGridViewTextBoxColumn.DataPropertyName = "QuoteOnOrders";
            this.quoteOnOrdersDataGridViewTextBoxColumn.HeaderText = "QuoteOnOrders";
            this.quoteOnOrdersDataGridViewTextBoxColumn.Name = "quoteOnOrdersDataGridViewTextBoxColumn";
            this.quoteOnOrdersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uSDTValueDataGridViewTextBoxColumn
            // 
            this.uSDTValueDataGridViewTextBoxColumn.DataPropertyName = "USDT_Value";
            this.uSDTValueDataGridViewTextBoxColumn.HeaderText = "USDT_Value";
            this.uSDTValueDataGridViewTextBoxColumn.Name = "uSDTValueDataGridViewTextBoxColumn";
            this.uSDTValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tabBinance
            // 
            this.tabBinance.Location = new System.Drawing.Point(23, 4);
            this.tabBinance.Name = "tabBinance";
            this.tabBinance.Padding = new System.Windows.Forms.Padding(3);
            this.tabBinance.Size = new System.Drawing.Size(465, 427);
            this.tabBinance.TabIndex = 1;
            this.tabBinance.Text = "Binance";
            this.tabBinance.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox3.Controls.Add(this.txtLogs);
            this.groupBox3.Location = new System.Drawing.Point(1043, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 435);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Logs";
            // 
            // txtLogs
            // 
            this.txtLogs.Location = new System.Drawing.Point(6, 19);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogs.Size = new System.Drawing.Size(373, 410);
            this.txtLogs.TabIndex = 0;
            // 
            // grbTrade
            // 
            this.grbTrade.BackColor = System.Drawing.Color.AliceBlue;
            this.grbTrade.Controls.Add(this.gbBuy);
            this.grbTrade.Controls.Add(this.gbSell);
            this.grbTrade.Location = new System.Drawing.Point(510, 12);
            this.grbTrade.Name = "grbTrade";
            this.grbTrade.Size = new System.Drawing.Size(527, 283);
            this.grbTrade.TabIndex = 6;
            this.grbTrade.TabStop = false;
            this.grbTrade.Text = "Trade";
            // 
            // gbBuy
            // 
            this.gbBuy.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.gbBuy.Controls.Add(this.lblBalanceBuy);
            this.gbBuy.Controls.Add(this.lblBalanceTitleBuy);
            this.gbBuy.Controls.Add(this.txtBuyTotalUsdt);
            this.gbBuy.Controls.Add(this.lblTotalUsdt);
            this.gbBuy.Controls.Add(this.btnBuy);
            this.gbBuy.Controls.Add(this.txtBuyTotal);
            this.gbBuy.Controls.Add(this.lblBuyTotal);
            this.gbBuy.Controls.Add(this.btnBuy100);
            this.gbBuy.Controls.Add(this.btnBuy75);
            this.gbBuy.Controls.Add(this.btnBuy50);
            this.gbBuy.Controls.Add(this.btnBuy25);
            this.gbBuy.Controls.Add(this.txtBuyAmountUsdt);
            this.gbBuy.Controls.Add(this.lblBuyAmountUsdt);
            this.gbBuy.Controls.Add(this.txtBuyAmount);
            this.gbBuy.Controls.Add(this.lblBuyAmount);
            this.gbBuy.Controls.Add(this.txtBuyPriceUsdt);
            this.gbBuy.Controls.Add(this.lblBuyPriceUsdt);
            this.gbBuy.Controls.Add(this.txtBuyPrice);
            this.gbBuy.Controls.Add(this.lblBuyPrice);
            this.gbBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBuy.Location = new System.Drawing.Point(6, 19);
            this.gbBuy.Name = "gbBuy";
            this.gbBuy.Size = new System.Drawing.Size(255, 253);
            this.gbBuy.TabIndex = 1;
            this.gbBuy.TabStop = false;
            this.gbBuy.Text = "Buy";
            // 
            // lblBalanceBuy
            // 
            this.lblBalanceBuy.AutoSize = true;
            this.lblBalanceBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBalanceBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceBuy.Location = new System.Drawing.Point(127, 25);
            this.lblBalanceBuy.Name = "lblBalanceBuy";
            this.lblBalanceBuy.Size = new System.Drawing.Size(14, 15);
            this.lblBalanceBuy.TabIndex = 18;
            this.lblBalanceBuy.Text = "0";
            this.lblBalanceBuy.Click += new System.EventHandler(this.lblBalanceBuy_Click);
            // 
            // lblBalanceTitleBuy
            // 
            this.lblBalanceTitleBuy.AutoSize = true;
            this.lblBalanceTitleBuy.Location = new System.Drawing.Point(15, 25);
            this.lblBalanceTitleBuy.Name = "lblBalanceTitleBuy";
            this.lblBalanceTitleBuy.Size = new System.Drawing.Size(55, 15);
            this.lblBalanceTitleBuy.TabIndex = 17;
            this.lblBalanceTitleBuy.Text = "Balance:";
            // 
            // txtBuyTotalUsdt
            // 
            this.txtBuyTotalUsdt.Location = new System.Drawing.Point(130, 194);
            this.txtBuyTotalUsdt.Name = "txtBuyTotalUsdt";
            this.txtBuyTotalUsdt.Size = new System.Drawing.Size(106, 21);
            this.txtBuyTotalUsdt.TabIndex = 16;
            // 
            // lblTotalUsdt
            // 
            this.lblTotalUsdt.AutoSize = true;
            this.lblTotalUsdt.Location = new System.Drawing.Point(127, 176);
            this.lblTotalUsdt.Name = "lblTotalUsdt";
            this.lblTotalUsdt.Size = new System.Drawing.Size(40, 15);
            this.lblTotalUsdt.TabIndex = 15;
            this.lblTotalUsdt.Text = "USDT";
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(49, 221);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(156, 23);
            this.btnBuy.TabIndex = 14;
            this.btnBuy.Text = "BUY";
            this.btnBuy.UseVisualStyleBackColor = true;
            // 
            // txtBuyTotal
            // 
            this.txtBuyTotal.Location = new System.Drawing.Point(18, 194);
            this.txtBuyTotal.Name = "txtBuyTotal";
            this.txtBuyTotal.Size = new System.Drawing.Size(106, 21);
            this.txtBuyTotal.TabIndex = 13;
            this.txtBuyTotal.TextChanged += new System.EventHandler(this.txtBuyTotal_TextChanged);
            // 
            // lblBuyTotal
            // 
            this.lblBuyTotal.AutoSize = true;
            this.lblBuyTotal.Location = new System.Drawing.Point(15, 176);
            this.lblBuyTotal.Name = "lblBuyTotal";
            this.lblBuyTotal.Size = new System.Drawing.Size(34, 15);
            this.lblBuyTotal.TabIndex = 12;
            this.lblBuyTotal.Text = "Total";
            // 
            // btnBuy100
            // 
            this.btnBuy100.Location = new System.Drawing.Point(186, 145);
            this.btnBuy100.Name = "btnBuy100";
            this.btnBuy100.Size = new System.Drawing.Size(50, 23);
            this.btnBuy100.TabIndex = 11;
            this.btnBuy100.Text = "100%";
            this.btnBuy100.UseVisualStyleBackColor = true;
            this.btnBuy100.Click += new System.EventHandler(this.btnBuy100_Click);
            // 
            // btnBuy75
            // 
            this.btnBuy75.Location = new System.Drawing.Point(130, 145);
            this.btnBuy75.Name = "btnBuy75";
            this.btnBuy75.Size = new System.Drawing.Size(50, 23);
            this.btnBuy75.TabIndex = 10;
            this.btnBuy75.Text = "75%";
            this.btnBuy75.UseVisualStyleBackColor = true;
            this.btnBuy75.Click += new System.EventHandler(this.btnBuy75_Click);
            // 
            // btnBuy50
            // 
            this.btnBuy50.Location = new System.Drawing.Point(74, 145);
            this.btnBuy50.Name = "btnBuy50";
            this.btnBuy50.Size = new System.Drawing.Size(50, 23);
            this.btnBuy50.TabIndex = 9;
            this.btnBuy50.Text = "50%";
            this.btnBuy50.UseVisualStyleBackColor = true;
            this.btnBuy50.Click += new System.EventHandler(this.btnBuy50_Click);
            // 
            // btnBuy25
            // 
            this.btnBuy25.Location = new System.Drawing.Point(18, 145);
            this.btnBuy25.Name = "btnBuy25";
            this.btnBuy25.Size = new System.Drawing.Size(50, 23);
            this.btnBuy25.TabIndex = 8;
            this.btnBuy25.Text = "25%";
            this.btnBuy25.UseVisualStyleBackColor = true;
            this.btnBuy25.Click += new System.EventHandler(this.btnBuy25_Click);
            // 
            // txtBuyAmountUsdt
            // 
            this.txtBuyAmountUsdt.Location = new System.Drawing.Point(130, 118);
            this.txtBuyAmountUsdt.Name = "txtBuyAmountUsdt";
            this.txtBuyAmountUsdt.Size = new System.Drawing.Size(106, 21);
            this.txtBuyAmountUsdt.TabIndex = 7;
            this.txtBuyAmountUsdt.TextChanged += new System.EventHandler(this.txtBuyAmountUsdt_TextChanged);
            // 
            // lblBuyAmountUsdt
            // 
            this.lblBuyAmountUsdt.AutoSize = true;
            this.lblBuyAmountUsdt.Location = new System.Drawing.Point(127, 100);
            this.lblBuyAmountUsdt.Name = "lblBuyAmountUsdt";
            this.lblBuyAmountUsdt.Size = new System.Drawing.Size(40, 15);
            this.lblBuyAmountUsdt.TabIndex = 6;
            this.lblBuyAmountUsdt.Text = "USDT";
            // 
            // txtBuyAmount
            // 
            this.txtBuyAmount.Location = new System.Drawing.Point(18, 118);
            this.txtBuyAmount.Name = "txtBuyAmount";
            this.txtBuyAmount.Size = new System.Drawing.Size(106, 21);
            this.txtBuyAmount.TabIndex = 5;
            this.txtBuyAmount.TextChanged += new System.EventHandler(this.txtBuyAmount_TextChanged);
            // 
            // lblBuyAmount
            // 
            this.lblBuyAmount.AutoSize = true;
            this.lblBuyAmount.Location = new System.Drawing.Point(15, 100);
            this.lblBuyAmount.Name = "lblBuyAmount";
            this.lblBuyAmount.Size = new System.Drawing.Size(49, 15);
            this.lblBuyAmount.TabIndex = 4;
            this.lblBuyAmount.Text = "Amount";
            // 
            // txtBuyPriceUsdt
            // 
            this.txtBuyPriceUsdt.Location = new System.Drawing.Point(130, 74);
            this.txtBuyPriceUsdt.Name = "txtBuyPriceUsdt";
            this.txtBuyPriceUsdt.Size = new System.Drawing.Size(106, 21);
            this.txtBuyPriceUsdt.TabIndex = 3;
            // 
            // lblBuyPriceUsdt
            // 
            this.lblBuyPriceUsdt.AutoSize = true;
            this.lblBuyPriceUsdt.Location = new System.Drawing.Point(127, 56);
            this.lblBuyPriceUsdt.Name = "lblBuyPriceUsdt";
            this.lblBuyPriceUsdt.Size = new System.Drawing.Size(40, 15);
            this.lblBuyPriceUsdt.TabIndex = 2;
            this.lblBuyPriceUsdt.Text = "USDT";
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.Location = new System.Drawing.Point(18, 74);
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.Size = new System.Drawing.Size(106, 21);
            this.txtBuyPrice.TabIndex = 1;
            this.txtBuyPrice.TextChanged += new System.EventHandler(this.txtBuyPrice_TextChanged);
            // 
            // lblBuyPrice
            // 
            this.lblBuyPrice.AutoSize = true;
            this.lblBuyPrice.Location = new System.Drawing.Point(15, 56);
            this.lblBuyPrice.Name = "lblBuyPrice";
            this.lblBuyPrice.Size = new System.Drawing.Size(35, 15);
            this.lblBuyPrice.TabIndex = 0;
            this.lblBuyPrice.Text = "Price";
            // 
            // gbSell
            // 
            this.gbSell.BackColor = System.Drawing.Color.RosyBrown;
            this.gbSell.Controls.Add(this.lblBalanceTitleSell);
            this.gbSell.Controls.Add(this.lblBalanceSell);
            this.gbSell.Controls.Add(this.txtSellTotalUsdt);
            this.gbSell.Controls.Add(this.lblSellTotalUsdt);
            this.gbSell.Controls.Add(this.btnSell);
            this.gbSell.Controls.Add(this.txtSellTotal);
            this.gbSell.Controls.Add(this.lblSellTotal);
            this.gbSell.Controls.Add(this.btnSell100);
            this.gbSell.Controls.Add(this.txtSellAmountUsdt);
            this.gbSell.Controls.Add(this.btnSell75);
            this.gbSell.Controls.Add(this.btnSell50);
            this.gbSell.Controls.Add(this.lblSellAmountUsdt);
            this.gbSell.Controls.Add(this.btnSell25);
            this.gbSell.Controls.Add(this.txtSellAmount);
            this.gbSell.Controls.Add(this.lblSellAmount);
            this.gbSell.Controls.Add(this.txtSellPriceUsdt);
            this.gbSell.Controls.Add(this.lblSellPriceUsdt);
            this.gbSell.Controls.Add(this.txtSellPrice);
            this.gbSell.Controls.Add(this.lblSellPrice);
            this.gbSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSell.Location = new System.Drawing.Point(267, 19);
            this.gbSell.Name = "gbSell";
            this.gbSell.Size = new System.Drawing.Size(254, 253);
            this.gbSell.TabIndex = 2;
            this.gbSell.TabStop = false;
            this.gbSell.Text = "Sell";
            // 
            // lblBalanceTitleSell
            // 
            this.lblBalanceTitleSell.AutoSize = true;
            this.lblBalanceTitleSell.Location = new System.Drawing.Point(14, 25);
            this.lblBalanceTitleSell.Name = "lblBalanceTitleSell";
            this.lblBalanceTitleSell.Size = new System.Drawing.Size(55, 15);
            this.lblBalanceTitleSell.TabIndex = 18;
            this.lblBalanceTitleSell.Text = "Balance:";
            // 
            // lblBalanceSell
            // 
            this.lblBalanceSell.AutoSize = true;
            this.lblBalanceSell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBalanceSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceSell.Location = new System.Drawing.Point(126, 25);
            this.lblBalanceSell.Name = "lblBalanceSell";
            this.lblBalanceSell.Size = new System.Drawing.Size(14, 15);
            this.lblBalanceSell.TabIndex = 19;
            this.lblBalanceSell.Text = "0";
            this.lblBalanceSell.Click += new System.EventHandler(this.lblBalanceSell_Click);
            // 
            // txtSellTotalUsdt
            // 
            this.txtSellTotalUsdt.Location = new System.Drawing.Point(129, 194);
            this.txtSellTotalUsdt.Name = "txtSellTotalUsdt";
            this.txtSellTotalUsdt.Size = new System.Drawing.Size(106, 21);
            this.txtSellTotalUsdt.TabIndex = 17;
            // 
            // lblSellTotalUsdt
            // 
            this.lblSellTotalUsdt.AutoSize = true;
            this.lblSellTotalUsdt.Location = new System.Drawing.Point(126, 176);
            this.lblSellTotalUsdt.Name = "lblSellTotalUsdt";
            this.lblSellTotalUsdt.Size = new System.Drawing.Size(40, 15);
            this.lblSellTotalUsdt.TabIndex = 16;
            this.lblSellTotalUsdt.Text = "USDT";
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(51, 222);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(156, 22);
            this.btnSell.TabIndex = 15;
            this.btnSell.Text = "SELL";
            this.btnSell.UseVisualStyleBackColor = true;
            // 
            // txtSellTotal
            // 
            this.txtSellTotal.Location = new System.Drawing.Point(17, 194);
            this.txtSellTotal.Name = "txtSellTotal";
            this.txtSellTotal.Size = new System.Drawing.Size(106, 21);
            this.txtSellTotal.TabIndex = 14;
            this.txtSellTotal.TextChanged += new System.EventHandler(this.txtSellTotal_TextChanged);
            // 
            // lblSellTotal
            // 
            this.lblSellTotal.AutoSize = true;
            this.lblSellTotal.Location = new System.Drawing.Point(14, 176);
            this.lblSellTotal.Name = "lblSellTotal";
            this.lblSellTotal.Size = new System.Drawing.Size(34, 15);
            this.lblSellTotal.TabIndex = 13;
            this.lblSellTotal.Text = "Total";
            // 
            // btnSell100
            // 
            this.btnSell100.Location = new System.Drawing.Point(185, 146);
            this.btnSell100.Name = "btnSell100";
            this.btnSell100.Size = new System.Drawing.Size(50, 22);
            this.btnSell100.TabIndex = 15;
            this.btnSell100.Text = "100%";
            this.btnSell100.UseVisualStyleBackColor = true;
            this.btnSell100.Click += new System.EventHandler(this.btnSell100_Click);
            // 
            // txtSellAmountUsdt
            // 
            this.txtSellAmountUsdt.Location = new System.Drawing.Point(129, 118);
            this.txtSellAmountUsdt.Name = "txtSellAmountUsdt";
            this.txtSellAmountUsdt.Size = new System.Drawing.Size(106, 21);
            this.txtSellAmountUsdt.TabIndex = 8;
            // 
            // btnSell75
            // 
            this.btnSell75.Location = new System.Drawing.Point(129, 146);
            this.btnSell75.Name = "btnSell75";
            this.btnSell75.Size = new System.Drawing.Size(50, 22);
            this.btnSell75.TabIndex = 14;
            this.btnSell75.Text = "75%";
            this.btnSell75.UseVisualStyleBackColor = true;
            this.btnSell75.Click += new System.EventHandler(this.btnSell75_Click);
            // 
            // btnSell50
            // 
            this.btnSell50.Location = new System.Drawing.Point(73, 146);
            this.btnSell50.Name = "btnSell50";
            this.btnSell50.Size = new System.Drawing.Size(50, 22);
            this.btnSell50.TabIndex = 13;
            this.btnSell50.Text = "50%";
            this.btnSell50.UseVisualStyleBackColor = true;
            this.btnSell50.Click += new System.EventHandler(this.btnSell50_Click);
            // 
            // lblSellAmountUsdt
            // 
            this.lblSellAmountUsdt.AutoSize = true;
            this.lblSellAmountUsdt.Location = new System.Drawing.Point(126, 100);
            this.lblSellAmountUsdt.Name = "lblSellAmountUsdt";
            this.lblSellAmountUsdt.Size = new System.Drawing.Size(40, 15);
            this.lblSellAmountUsdt.TabIndex = 7;
            this.lblSellAmountUsdt.Text = "USDT";
            // 
            // btnSell25
            // 
            this.btnSell25.Location = new System.Drawing.Point(17, 146);
            this.btnSell25.Name = "btnSell25";
            this.btnSell25.Size = new System.Drawing.Size(50, 22);
            this.btnSell25.TabIndex = 12;
            this.btnSell25.Text = "25%";
            this.btnSell25.UseVisualStyleBackColor = true;
            this.btnSell25.Click += new System.EventHandler(this.btnSell25_Click);
            // 
            // txtSellAmount
            // 
            this.txtSellAmount.Location = new System.Drawing.Point(17, 118);
            this.txtSellAmount.Name = "txtSellAmount";
            this.txtSellAmount.Size = new System.Drawing.Size(106, 21);
            this.txtSellAmount.TabIndex = 6;
            this.txtSellAmount.TextChanged += new System.EventHandler(this.txtSellAmount_TextChanged);
            // 
            // lblSellAmount
            // 
            this.lblSellAmount.AutoSize = true;
            this.lblSellAmount.Location = new System.Drawing.Point(14, 100);
            this.lblSellAmount.Name = "lblSellAmount";
            this.lblSellAmount.Size = new System.Drawing.Size(49, 15);
            this.lblSellAmount.TabIndex = 5;
            this.lblSellAmount.Text = "Amount";
            // 
            // txtSellPriceUsdt
            // 
            this.txtSellPriceUsdt.Location = new System.Drawing.Point(129, 74);
            this.txtSellPriceUsdt.Name = "txtSellPriceUsdt";
            this.txtSellPriceUsdt.Size = new System.Drawing.Size(106, 21);
            this.txtSellPriceUsdt.TabIndex = 4;
            // 
            // lblSellPriceUsdt
            // 
            this.lblSellPriceUsdt.AutoSize = true;
            this.lblSellPriceUsdt.Location = new System.Drawing.Point(126, 56);
            this.lblSellPriceUsdt.Name = "lblSellPriceUsdt";
            this.lblSellPriceUsdt.Size = new System.Drawing.Size(40, 15);
            this.lblSellPriceUsdt.TabIndex = 3;
            this.lblSellPriceUsdt.Text = "USDT";
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Location = new System.Drawing.Point(17, 74);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(106, 21);
            this.txtSellPrice.TabIndex = 2;
            this.txtSellPrice.TextChanged += new System.EventHandler(this.txtSellPrice_TextChanged);
            // 
            // lblSellPrice
            // 
            this.lblSellPrice.AutoSize = true;
            this.lblSellPrice.Location = new System.Drawing.Point(14, 56);
            this.lblSellPrice.Name = "lblSellPrice";
            this.lblSellPrice.Size = new System.Drawing.Size(35, 15);
            this.lblSellPrice.TabIndex = 1;
            this.lblSellPrice.Text = "Price";
            // 
            // dgvCurrentTrades
            // 
            this.dgvCurrentTrades.AllowUserToAddRows = false;
            this.dgvCurrentTrades.AllowUserToDeleteRows = false;
            this.dgvCurrentTrades.AllowUserToOrderColumns = true;
            this.dgvCurrentTrades.AllowUserToResizeColumns = false;
            this.dgvCurrentTrades.AllowUserToResizeRows = false;
            this.dgvCurrentTrades.AutoGenerateColumns = false;
            this.dgvCurrentTrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCurrentTrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentTrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.currencyPairDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.lossToleranceDataGridViewTextBoxColumn,
            this.lossToleranceMultiplicatorDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.usdtValueDataGridViewTextBoxColumn1,
            this.pricePaidDataGridViewTextBoxColumn,
            this.priceLastDataGridViewTextBoxColumn,
            this.profitDataGridViewTextBoxColumn,
            this.highestProfitDataGridViewTextBoxColumn,
            this.highestProfitDiffDataGridViewTextBoxColumn,
            this.toleranceProfitHighDiffDataGridViewTextBoxColumn,
            this.timeBuyDataGridViewTextBoxColumn,
            this.lastTickerDataGridViewTextBoxColumn,
            this.Action});
            this.dgvCurrentTrades.DataSource = this.flatTradeModelBindingSource;
            this.dgvCurrentTrades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCurrentTrades.Location = new System.Drawing.Point(35, 487);
            this.dgvCurrentTrades.Name = "dgvCurrentTrades";
            this.dgvCurrentTrades.Size = new System.Drawing.Size(1321, 81);
            this.dgvCurrentTrades.TabIndex = 3;
            this.dgvCurrentTrades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurrentTrades_CellContentClick_1);
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            // 
            // dgvClosedTrades
            // 
            this.dgvClosedTrades.AllowUserToAddRows = false;
            this.dgvClosedTrades.AllowUserToDeleteRows = false;
            this.dgvClosedTrades.AllowUserToOrderColumns = true;
            this.dgvClosedTrades.AllowUserToResizeColumns = false;
            this.dgvClosedTrades.AllowUserToResizeRows = false;
            this.dgvClosedTrades.AutoGenerateColumns = false;
            this.dgvClosedTrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClosedTrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClosedTrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.currencyPairDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn1,
            this.lossToleranceDataGridViewTextBoxColumn1,
            this.lossToleranceMultiplicatorDataGridViewTextBoxColumn1,
            this.amountDataGridViewTextBoxColumn1,
            this.usdtValueDataGridViewTextBoxColumn2,
            this.pricePaidDataGridViewTextBoxColumn1,
            this.priceLastDataGridViewTextBoxColumn1,
            this.profitDataGridViewTextBoxColumn1,
            this.highestProfitDataGridViewTextBoxColumn1,
            this.highestProfitDiffDataGridViewTextBoxColumn1,
            this.toleranceProfitHighDiffDataGridViewTextBoxColumn1,
            this.timeBuyDataGridViewTextBoxColumn1,
            this.lastTickerDataGridViewTextBoxColumn1});
            this.dgvClosedTrades.DataSource = this.flatTradeModelBindingSource;
            this.dgvClosedTrades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClosedTrades.Location = new System.Drawing.Point(35, 574);
            this.dgvClosedTrades.Name = "dgvClosedTrades";
            this.dgvClosedTrades.Size = new System.Drawing.Size(1237, 169);
            this.dgvClosedTrades.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox4.Controls.Add(this.Total);
            this.groupBox4.Location = new System.Drawing.Point(515, 300);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(522, 145);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Stats";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(21, 28);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(58, 13);
            this.Total.TabIndex = 0;
            this.Total.Text = "Total Profit";
            // 
            // balanceModelBindingSource
            // 
            this.balanceModelBindingSource.DataSource = typeof(Jojatekok.PoloniexAPI.BalanceModel);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 20);
            this.textBox1.TabIndex = 30;
            // 
            // currencyPairDataGridViewTextBoxColumn1
            // 
            this.currencyPairDataGridViewTextBoxColumn1.DataPropertyName = "CurrencyPair";
            this.currencyPairDataGridViewTextBoxColumn1.HeaderText = "CurrencyPair";
            this.currencyPairDataGridViewTextBoxColumn1.Name = "currencyPairDataGridViewTextBoxColumn1";
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            // 
            // lossToleranceDataGridViewTextBoxColumn1
            // 
            this.lossToleranceDataGridViewTextBoxColumn1.DataPropertyName = "LossTolerance";
            this.lossToleranceDataGridViewTextBoxColumn1.HeaderText = "LossTolerance";
            this.lossToleranceDataGridViewTextBoxColumn1.Name = "lossToleranceDataGridViewTextBoxColumn1";
            // 
            // lossToleranceMultiplicatorDataGridViewTextBoxColumn1
            // 
            this.lossToleranceMultiplicatorDataGridViewTextBoxColumn1.DataPropertyName = "LossToleranceMultiplicator";
            this.lossToleranceMultiplicatorDataGridViewTextBoxColumn1.HeaderText = "LossToleranceMultiplicator";
            this.lossToleranceMultiplicatorDataGridViewTextBoxColumn1.Name = "lossToleranceMultiplicatorDataGridViewTextBoxColumn1";
            // 
            // amountDataGridViewTextBoxColumn1
            // 
            this.amountDataGridViewTextBoxColumn1.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn1.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn1.Name = "amountDataGridViewTextBoxColumn1";
            // 
            // usdtValueDataGridViewTextBoxColumn2
            // 
            this.usdtValueDataGridViewTextBoxColumn2.DataPropertyName = "UsdtValue";
            this.usdtValueDataGridViewTextBoxColumn2.HeaderText = "UsdtValue";
            this.usdtValueDataGridViewTextBoxColumn2.Name = "usdtValueDataGridViewTextBoxColumn2";
            // 
            // pricePaidDataGridViewTextBoxColumn1
            // 
            this.pricePaidDataGridViewTextBoxColumn1.DataPropertyName = "PricePaid";
            this.pricePaidDataGridViewTextBoxColumn1.HeaderText = "PricePaid";
            this.pricePaidDataGridViewTextBoxColumn1.Name = "pricePaidDataGridViewTextBoxColumn1";
            // 
            // priceLastDataGridViewTextBoxColumn1
            // 
            this.priceLastDataGridViewTextBoxColumn1.DataPropertyName = "PriceLast";
            this.priceLastDataGridViewTextBoxColumn1.HeaderText = "PriceLast";
            this.priceLastDataGridViewTextBoxColumn1.Name = "priceLastDataGridViewTextBoxColumn1";
            // 
            // profitDataGridViewTextBoxColumn1
            // 
            this.profitDataGridViewTextBoxColumn1.DataPropertyName = "Profit";
            this.profitDataGridViewTextBoxColumn1.HeaderText = "Profit";
            this.profitDataGridViewTextBoxColumn1.Name = "profitDataGridViewTextBoxColumn1";
            // 
            // highestProfitDataGridViewTextBoxColumn1
            // 
            this.highestProfitDataGridViewTextBoxColumn1.DataPropertyName = "HighestProfit";
            this.highestProfitDataGridViewTextBoxColumn1.HeaderText = "HighestProfit";
            this.highestProfitDataGridViewTextBoxColumn1.Name = "highestProfitDataGridViewTextBoxColumn1";
            // 
            // highestProfitDiffDataGridViewTextBoxColumn1
            // 
            this.highestProfitDiffDataGridViewTextBoxColumn1.DataPropertyName = "HighestProfitDiff";
            this.highestProfitDiffDataGridViewTextBoxColumn1.HeaderText = "HighestProfitDiff";
            this.highestProfitDiffDataGridViewTextBoxColumn1.Name = "highestProfitDiffDataGridViewTextBoxColumn1";
            // 
            // toleranceProfitHighDiffDataGridViewTextBoxColumn1
            // 
            this.toleranceProfitHighDiffDataGridViewTextBoxColumn1.DataPropertyName = "ToleranceProfitHighDiff";
            this.toleranceProfitHighDiffDataGridViewTextBoxColumn1.HeaderText = "ToleranceProfitHighDiff";
            this.toleranceProfitHighDiffDataGridViewTextBoxColumn1.Name = "toleranceProfitHighDiffDataGridViewTextBoxColumn1";
            // 
            // timeBuyDataGridViewTextBoxColumn1
            // 
            this.timeBuyDataGridViewTextBoxColumn1.DataPropertyName = "TimeBuy";
            this.timeBuyDataGridViewTextBoxColumn1.HeaderText = "TimeBuy";
            this.timeBuyDataGridViewTextBoxColumn1.Name = "timeBuyDataGridViewTextBoxColumn1";
            // 
            // lastTickerDataGridViewTextBoxColumn1
            // 
            this.lastTickerDataGridViewTextBoxColumn1.DataPropertyName = "LastTicker";
            this.lastTickerDataGridViewTextBoxColumn1.HeaderText = "LastTicker";
            this.lastTickerDataGridViewTextBoxColumn1.Name = "lastTickerDataGridViewTextBoxColumn1";
            // 
            // flatTradeModelBindingSource
            // 
            this.flatTradeModelBindingSource.DataSource = typeof(FormConsole.FlatTradeModel);
            // 
            // currencyPairDataGridViewTextBoxColumn
            // 
            this.currencyPairDataGridViewTextBoxColumn.DataPropertyName = "CurrencyPair";
            this.currencyPairDataGridViewTextBoxColumn.HeaderText = "CurrencyPair";
            this.currencyPairDataGridViewTextBoxColumn.Name = "currencyPairDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // lossToleranceDataGridViewTextBoxColumn
            // 
            this.lossToleranceDataGridViewTextBoxColumn.DataPropertyName = "LossTolerance";
            this.lossToleranceDataGridViewTextBoxColumn.HeaderText = "LossTolerance";
            this.lossToleranceDataGridViewTextBoxColumn.Name = "lossToleranceDataGridViewTextBoxColumn";
            // 
            // lossToleranceMultiplicatorDataGridViewTextBoxColumn
            // 
            this.lossToleranceMultiplicatorDataGridViewTextBoxColumn.DataPropertyName = "LossToleranceMultiplicator";
            this.lossToleranceMultiplicatorDataGridViewTextBoxColumn.HeaderText = "LossToleranceMultiplicator";
            this.lossToleranceMultiplicatorDataGridViewTextBoxColumn.Name = "lossToleranceMultiplicatorDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // usdtValueDataGridViewTextBoxColumn1
            // 
            this.usdtValueDataGridViewTextBoxColumn1.DataPropertyName = "UsdtValue";
            this.usdtValueDataGridViewTextBoxColumn1.HeaderText = "UsdtValue";
            this.usdtValueDataGridViewTextBoxColumn1.Name = "usdtValueDataGridViewTextBoxColumn1";
            // 
            // pricePaidDataGridViewTextBoxColumn
            // 
            this.pricePaidDataGridViewTextBoxColumn.DataPropertyName = "PricePaid";
            this.pricePaidDataGridViewTextBoxColumn.HeaderText = "PricePaid";
            this.pricePaidDataGridViewTextBoxColumn.Name = "pricePaidDataGridViewTextBoxColumn";
            // 
            // priceLastDataGridViewTextBoxColumn
            // 
            this.priceLastDataGridViewTextBoxColumn.DataPropertyName = "PriceLast";
            this.priceLastDataGridViewTextBoxColumn.HeaderText = "PriceLast";
            this.priceLastDataGridViewTextBoxColumn.Name = "priceLastDataGridViewTextBoxColumn";
            // 
            // profitDataGridViewTextBoxColumn
            // 
            this.profitDataGridViewTextBoxColumn.DataPropertyName = "Profit";
            this.profitDataGridViewTextBoxColumn.HeaderText = "Profit";
            this.profitDataGridViewTextBoxColumn.Name = "profitDataGridViewTextBoxColumn";
            // 
            // highestProfitDataGridViewTextBoxColumn
            // 
            this.highestProfitDataGridViewTextBoxColumn.DataPropertyName = "HighestProfit";
            this.highestProfitDataGridViewTextBoxColumn.HeaderText = "HighestProfit";
            this.highestProfitDataGridViewTextBoxColumn.Name = "highestProfitDataGridViewTextBoxColumn";
            // 
            // highestProfitDiffDataGridViewTextBoxColumn
            // 
            this.highestProfitDiffDataGridViewTextBoxColumn.DataPropertyName = "HighestProfitDiff";
            this.highestProfitDiffDataGridViewTextBoxColumn.HeaderText = "HighestProfitDiff";
            this.highestProfitDiffDataGridViewTextBoxColumn.Name = "highestProfitDiffDataGridViewTextBoxColumn";
            // 
            // toleranceProfitHighDiffDataGridViewTextBoxColumn
            // 
            this.toleranceProfitHighDiffDataGridViewTextBoxColumn.DataPropertyName = "ToleranceProfitHighDiff";
            this.toleranceProfitHighDiffDataGridViewTextBoxColumn.HeaderText = "ToleranceProfitHighDiff";
            this.toleranceProfitHighDiffDataGridViewTextBoxColumn.Name = "toleranceProfitHighDiffDataGridViewTextBoxColumn";
            // 
            // timeBuyDataGridViewTextBoxColumn
            // 
            this.timeBuyDataGridViewTextBoxColumn.DataPropertyName = "TimeBuy";
            this.timeBuyDataGridViewTextBoxColumn.HeaderText = "TimeBuy";
            this.timeBuyDataGridViewTextBoxColumn.Name = "timeBuyDataGridViewTextBoxColumn";
            // 
            // lastTickerDataGridViewTextBoxColumn
            // 
            this.lastTickerDataGridViewTextBoxColumn.DataPropertyName = "LastTicker";
            this.lastTickerDataGridViewTextBoxColumn.HeaderText = "LastTicker";
            this.lastTickerDataGridViewTextBoxColumn.Name = "lastTickerDataGridViewTextBoxColumn";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 753);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgvClosedTrades);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvCurrentTrades);
            this.Controls.Add(this.tabsExchanges);
            this.Controls.Add(this.grbTrade);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabsExchanges.ResumeLayout(false);
            this.tabPoloniex.ResumeLayout(false);
            this.tabsMarkets.ResumeLayout(false);
            this.tabUsdt.ResumeLayout(false);
            this.grbCoinSelectedBalances.ResumeLayout(false);
            this.grbCoinSelectedBalances.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbMultiplicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTolerance)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalances)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grbTrade.ResumeLayout(false);
            this.gbBuy.ResumeLayout(false);
            this.gbBuy.PerformLayout();
            this.gbSell.ResumeLayout(false);
            this.gbSell.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentTrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClosedTrades)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balanceModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatTradeModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabsExchanges;
        private System.Windows.Forms.TabPage tabPoloniex;
        private System.Windows.Forms.TabControl tabsMarkets;
        private System.Windows.Forms.TabPage tabUsdt;
        private System.Windows.Forms.TabPage tabBtc;
        private System.Windows.Forms.TabPage tabBinance;
        private System.Windows.Forms.TabPage tabEth;
        private System.Windows.Forms.TabPage tabXmr;
        private System.Windows.Forms.GroupBox gbSell;
        private System.Windows.Forms.GroupBox gbBuy;
        private System.Windows.Forms.Button btnStartBot;
        private System.Windows.Forms.Label lblBuyPrice;
        private System.Windows.Forms.TextBox txtSellPriceUsdt;
        private System.Windows.Forms.Label lblSellPriceUsdt;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.Label lblSellPrice;
        private System.Windows.Forms.TextBox txtBuyPriceUsdt;
        private System.Windows.Forms.Label lblBuyPriceUsdt;
        private System.Windows.Forms.TextBox txtBuyPrice;
        private System.Windows.Forms.Label lblBuyAmount;
        private System.Windows.Forms.Button btnSell100;
        private System.Windows.Forms.TextBox txtSellAmountUsdt;
        private System.Windows.Forms.Button btnSell75;
        private System.Windows.Forms.Button btnSell50;
        private System.Windows.Forms.Label lblSellAmountUsdt;
        private System.Windows.Forms.Button btnSell25;
        private System.Windows.Forms.TextBox txtSellAmount;
        private System.Windows.Forms.Label lblSellAmount;
        private System.Windows.Forms.Button btnBuy100;
        private System.Windows.Forms.Button btnBuy75;
        private System.Windows.Forms.Button btnBuy50;
        private System.Windows.Forms.Button btnBuy25;
        private System.Windows.Forms.TextBox txtBuyAmountUsdt;
        private System.Windows.Forms.Label lblBuyAmountUsdt;
        private System.Windows.Forms.TextBox txtBuyAmount;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.TextBox txtSellTotal;
        private System.Windows.Forms.Label lblSellTotal;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.TextBox txtBuyTotal;
        private System.Windows.Forms.Label lblBuyTotal;
        private System.Windows.Forms.TextBox txtSellTotalUsdt;
        private System.Windows.Forms.Label lblSellTotalUsdt;
        private System.Windows.Forms.TextBox txtBuyTotalUsdt;
        private System.Windows.Forms.Label lblTotalUsdt;
        private System.Windows.Forms.DataGridView dgvCurrentTrades;
        private System.Windows.Forms.DataGridView dgvBalances;
        private System.Windows.Forms.ListBox lbCoins;
        private System.Windows.Forms.Label lblBalanceTitleBuy;
        private System.Windows.Forms.Label lblBalanceBuy;
        private System.Windows.Forms.Label lblBalanceSell;
        private System.Windows.Forms.Label lblBalanceTitleSell;
        private System.Windows.Forms.GroupBox grbTrade;
        private System.Windows.Forms.GroupBox grbCoinSelectedBalances;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBalancesTitleQuote;
        private System.Windows.Forms.Label lblBalancesTitleBase;
        private System.Windows.Forms.Label lblBalancesQuote;
        private System.Windows.Forms.Label lblBalancesBase;
        private System.Windows.Forms.DataGridView dgvClosedTrades;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteAvailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteOnOrdersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSDTValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource balanceModelBindingSource;
        private System.Windows.Forms.Label lblLossTolerance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBotAmount;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.BindingSource flatTradeModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyPairDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lossToleranceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lossToleranceMultiplicatorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usdtValueDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePaidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceLastDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn highestProfitDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn highestProfitDiffDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn toleranceProfitHighDiffDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeBuyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastTickerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyPairDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lossToleranceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lossToleranceMultiplicatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usdtValueDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceLastDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn highestProfitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn highestProfitDiffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toleranceProfitHighDiffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeBuyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastTickerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.TrackBar trbTolerance;
        private System.Windows.Forms.Label lblValueMultiplicator;
        private System.Windows.Forms.TrackBar trbMultiplicator;
        private System.Windows.Forms.Label lblValueTolerance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

