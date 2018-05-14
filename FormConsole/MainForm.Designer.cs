namespace FormConsole
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvBots = new System.Windows.Forms.DataGridView();
            this.tickerModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBalances = new System.Windows.Forms.DataGridView();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoteAvailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoteOnOrdersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSDTValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbTrade = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBalancesQuote = new System.Windows.Forms.Label();
            this.lblBalancesBase = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBalancesTitleQuote = new System.Windows.Forms.Label();
            this.lblBalancesTitleBase = new System.Windows.Forms.Label();
            this.btnStartBot = new System.Windows.Forms.Button();
            this.txtBotAmount = new System.Windows.Forms.TextBox();
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
            this.tabsMarkets = new System.Windows.Forms.TabControl();
            this.tabUsdt = new System.Windows.Forms.TabPage();
            this.lbCoins = new System.Windows.Forms.ListBox();
            this.tabBtc = new System.Windows.Forms.TabPage();
            this.tabEth = new System.Windows.Forms.TabPage();
            this.tabXmr = new System.Windows.Forms.TabPage();
            this.tabBinance = new System.Windows.Forms.TabPage();
            this.dgvCurrentTrades = new System.Windows.Forms.DataGridView();
            this.tickerModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvClosedTrades = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyPairDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceLastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highestPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.higuestProfitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highestProfitDiffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lossToleranceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseCurrencyTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usdTotalValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tickerModelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.currencyPairDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePaidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceLastDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highestPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.higuestProfitDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highestProfitDiffDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lossToleranceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseCurrencyTotalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usdTotalValueDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyPairDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabsExchanges.SuspendLayout();
            this.tabPoloniex.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickerModelBindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceModelBindingSource)).BeginInit();
            this.gbTrade.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbBuy.SuspendLayout();
            this.gbSell.SuspendLayout();
            this.tabsMarkets.SuspendLayout();
            this.tabUsdt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentTrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickerModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClosedTrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickerModelBindingSource2)).BeginInit();
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
            this.tabsExchanges.Size = new System.Drawing.Size(1258, 412);
            this.tabsExchanges.TabIndex = 0;
            // 
            // tabPoloniex
            // 
            this.tabPoloniex.Controls.Add(this.groupBox3);
            this.tabPoloniex.Controls.Add(this.groupBox2);
            this.tabPoloniex.Controls.Add(this.gbTrade);
            this.tabPoloniex.Controls.Add(this.tabsMarkets);
            this.tabPoloniex.Location = new System.Drawing.Point(23, 4);
            this.tabPoloniex.Name = "tabPoloniex";
            this.tabPoloniex.Padding = new System.Windows.Forms.Padding(3);
            this.tabPoloniex.Size = new System.Drawing.Size(1231, 404);
            this.tabPoloniex.TabIndex = 0;
            this.tabPoloniex.Text = "Poloniex";
            this.tabPoloniex.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox3.Controls.Add(this.dgvBots);
            this.groupBox3.Location = new System.Drawing.Point(6, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(470, 192);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bots";
            // 
            // dgvBots
            // 
            this.dgvBots.AutoGenerateColumns = false;
            this.dgvBots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.currencyPairDataGridViewTextBoxColumn1,
            this.statusDataGridViewTextBoxColumn2});
            this.dgvBots.DataSource = this.tickerModelBindingSource1;
            this.dgvBots.Location = new System.Drawing.Point(6, 19);
            this.dgvBots.Name = "dgvBots";
            this.dgvBots.Size = new System.Drawing.Size(458, 161);
            this.dgvBots.TabIndex = 7;
            // 
            // tickerModelBindingSource1
            // 
            this.tickerModelBindingSource1.DataSource = typeof(Jojatekok.PoloniexAPI.TickerModel);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.dgvBalances);
            this.groupBox2.Location = new System.Drawing.Point(6, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 188);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Balances";
            // 
            // dgvBalances
            // 
            this.dgvBalances.AutoGenerateColumns = false;
            this.dgvBalances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBalances.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.quoteAvailableDataGridViewTextBoxColumn,
            this.quoteOnOrdersDataGridViewTextBoxColumn,
            this.uSDTValueDataGridViewTextBoxColumn});
            this.dgvBalances.DataSource = this.balanceModelBindingSource;
            this.dgvBalances.Location = new System.Drawing.Point(6, 20);
            this.dgvBalances.Name = "dgvBalances";
            this.dgvBalances.Size = new System.Drawing.Size(458, 153);
            this.dgvBalances.TabIndex = 2;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // quoteAvailableDataGridViewTextBoxColumn
            // 
            this.quoteAvailableDataGridViewTextBoxColumn.DataPropertyName = "QuoteAvailable";
            this.quoteAvailableDataGridViewTextBoxColumn.HeaderText = "QuoteAvailable";
            this.quoteAvailableDataGridViewTextBoxColumn.Name = "quoteAvailableDataGridViewTextBoxColumn";
            // 
            // quoteOnOrdersDataGridViewTextBoxColumn
            // 
            this.quoteOnOrdersDataGridViewTextBoxColumn.DataPropertyName = "QuoteOnOrders";
            this.quoteOnOrdersDataGridViewTextBoxColumn.HeaderText = "QuoteOnOrders";
            this.quoteOnOrdersDataGridViewTextBoxColumn.Name = "quoteOnOrdersDataGridViewTextBoxColumn";
            // 
            // uSDTValueDataGridViewTextBoxColumn
            // 
            this.uSDTValueDataGridViewTextBoxColumn.DataPropertyName = "USDT_Value";
            this.uSDTValueDataGridViewTextBoxColumn.HeaderText = "USDT_Value";
            this.uSDTValueDataGridViewTextBoxColumn.Name = "uSDTValueDataGridViewTextBoxColumn";
            // 
            // balanceModelBindingSource
            // 
            this.balanceModelBindingSource.DataSource = typeof(Jojatekok.PoloniexAPI.BalanceModel);
            // 
            // gbTrade
            // 
            this.gbTrade.Controls.Add(this.groupBox1);
            this.gbTrade.Controls.Add(this.gbBuy);
            this.gbTrade.Controls.Add(this.gbSell);
            this.gbTrade.Location = new System.Drawing.Point(680, 6);
            this.gbTrade.Name = "gbTrade";
            this.gbTrade.Size = new System.Drawing.Size(538, 388);
            this.gbTrade.TabIndex = 6;
            this.gbTrade.TabStop = false;
            this.gbTrade.Text = "Trade";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.lblBalancesQuote);
            this.groupBox1.Controls.Add(this.lblBalancesBase);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblBalancesTitleQuote);
            this.groupBox1.Controls.Add(this.lblBalancesTitleBase);
            this.groupBox1.Controls.Add(this.btnStartBot);
            this.groupBox1.Controls.Add(this.txtBotAmount);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 83);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Balances";
            // 
            // lblBalancesQuote
            // 
            this.lblBalancesQuote.AutoSize = true;
            this.lblBalancesQuote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBalancesQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalancesQuote.Location = new System.Drawing.Point(71, 45);
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
            this.lblBalancesBase.Location = new System.Drawing.Point(71, 26);
            this.lblBalancesBase.Name = "lblBalancesBase";
            this.lblBalancesBase.Size = new System.Drawing.Size(14, 15);
            this.lblBalancesBase.TabIndex = 19;
            this.lblBalancesBase.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Amount";
            // 
            // lblBalancesTitleQuote
            // 
            this.lblBalancesTitleQuote.AutoSize = true;
            this.lblBalancesTitleQuote.Location = new System.Drawing.Point(15, 47);
            this.lblBalancesTitleQuote.Name = "lblBalancesTitleQuote";
            this.lblBalancesTitleQuote.Size = new System.Drawing.Size(39, 13);
            this.lblBalancesTitleQuote.TabIndex = 7;
            this.lblBalancesTitleQuote.Text = "Quote:";
            // 
            // lblBalancesTitleBase
            // 
            this.lblBalancesTitleBase.AutoSize = true;
            this.lblBalancesTitleBase.Location = new System.Drawing.Point(15, 28);
            this.lblBalancesTitleBase.Name = "lblBalancesTitleBase";
            this.lblBalancesTitleBase.Size = new System.Drawing.Size(34, 13);
            this.lblBalancesTitleBase.TabIndex = 6;
            this.lblBalancesTitleBase.Text = "Base:";
            // 
            // btnStartBot
            // 
            this.btnStartBot.Location = new System.Drawing.Point(355, 51);
            this.btnStartBot.Name = "btnStartBot";
            this.btnStartBot.Size = new System.Drawing.Size(151, 23);
            this.btnStartBot.TabIndex = 3;
            this.btnStartBot.Text = "Start bot";
            this.btnStartBot.UseVisualStyleBackColor = true;
            this.btnStartBot.Click += new System.EventHandler(this.btnStartBot_Click);
            // 
            // txtBotAmount
            // 
            this.txtBotAmount.Location = new System.Drawing.Point(355, 25);
            this.txtBotAmount.Name = "txtBotAmount";
            this.txtBotAmount.Size = new System.Drawing.Size(151, 20);
            this.txtBotAmount.TabIndex = 5;
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
            this.gbBuy.Location = new System.Drawing.Point(6, 112);
            this.gbBuy.Name = "gbBuy";
            this.gbBuy.Size = new System.Drawing.Size(254, 264);
            this.gbBuy.TabIndex = 1;
            this.gbBuy.TabStop = false;
            this.gbBuy.Text = "Buy";
            // 
            // lblBalanceBuy
            // 
            this.lblBalanceBuy.AutoSize = true;
            this.lblBalanceBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBalanceBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceBuy.Location = new System.Drawing.Point(110, 26);
            this.lblBalanceBuy.Name = "lblBalanceBuy";
            this.lblBalanceBuy.Size = new System.Drawing.Size(14, 15);
            this.lblBalanceBuy.TabIndex = 18;
            this.lblBalanceBuy.Text = "0";
            this.lblBalanceBuy.Click += new System.EventHandler(this.lblBalanceBuy_Click);
            // 
            // lblBalanceTitleBuy
            // 
            this.lblBalanceTitleBuy.AutoSize = true;
            this.lblBalanceTitleBuy.Location = new System.Drawing.Point(15, 26);
            this.lblBalanceTitleBuy.Name = "lblBalanceTitleBuy";
            this.lblBalanceTitleBuy.Size = new System.Drawing.Size(55, 15);
            this.lblBalanceTitleBuy.TabIndex = 17;
            this.lblBalanceTitleBuy.Text = "Balance:";
            // 
            // txtBuyTotalUsdt
            // 
            this.txtBuyTotalUsdt.Location = new System.Drawing.Point(130, 201);
            this.txtBuyTotalUsdt.Name = "txtBuyTotalUsdt";
            this.txtBuyTotalUsdt.Size = new System.Drawing.Size(106, 21);
            this.txtBuyTotalUsdt.TabIndex = 16;
            // 
            // lblTotalUsdt
            // 
            this.lblTotalUsdt.AutoSize = true;
            this.lblTotalUsdt.Location = new System.Drawing.Point(127, 183);
            this.lblTotalUsdt.Name = "lblTotalUsdt";
            this.lblTotalUsdt.Size = new System.Drawing.Size(40, 15);
            this.lblTotalUsdt.TabIndex = 15;
            this.lblTotalUsdt.Text = "USDT";
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(49, 228);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(156, 23);
            this.btnBuy.TabIndex = 14;
            this.btnBuy.Text = "BUY";
            this.btnBuy.UseVisualStyleBackColor = true;
            // 
            // txtBuyTotal
            // 
            this.txtBuyTotal.Location = new System.Drawing.Point(18, 201);
            this.txtBuyTotal.Name = "txtBuyTotal";
            this.txtBuyTotal.Size = new System.Drawing.Size(106, 21);
            this.txtBuyTotal.TabIndex = 13;
            this.txtBuyTotal.TextChanged += new System.EventHandler(this.txtBuyTotal_TextChanged);
            // 
            // lblBuyTotal
            // 
            this.lblBuyTotal.AutoSize = true;
            this.lblBuyTotal.Location = new System.Drawing.Point(15, 183);
            this.lblBuyTotal.Name = "lblBuyTotal";
            this.lblBuyTotal.Size = new System.Drawing.Size(34, 15);
            this.lblBuyTotal.TabIndex = 12;
            this.lblBuyTotal.Text = "Total";
            // 
            // btnBuy100
            // 
            this.btnBuy100.Location = new System.Drawing.Point(186, 152);
            this.btnBuy100.Name = "btnBuy100";
            this.btnBuy100.Size = new System.Drawing.Size(50, 23);
            this.btnBuy100.TabIndex = 11;
            this.btnBuy100.Text = "100%";
            this.btnBuy100.UseVisualStyleBackColor = true;
            this.btnBuy100.Click += new System.EventHandler(this.btnBuy100_Click);
            // 
            // btnBuy75
            // 
            this.btnBuy75.Location = new System.Drawing.Point(130, 152);
            this.btnBuy75.Name = "btnBuy75";
            this.btnBuy75.Size = new System.Drawing.Size(50, 23);
            this.btnBuy75.TabIndex = 10;
            this.btnBuy75.Text = "75%";
            this.btnBuy75.UseVisualStyleBackColor = true;
            this.btnBuy75.Click += new System.EventHandler(this.btnBuy75_Click);
            // 
            // btnBuy50
            // 
            this.btnBuy50.Location = new System.Drawing.Point(74, 152);
            this.btnBuy50.Name = "btnBuy50";
            this.btnBuy50.Size = new System.Drawing.Size(50, 23);
            this.btnBuy50.TabIndex = 9;
            this.btnBuy50.Text = "50%";
            this.btnBuy50.UseVisualStyleBackColor = true;
            this.btnBuy50.Click += new System.EventHandler(this.btnBuy50_Click);
            // 
            // btnBuy25
            // 
            this.btnBuy25.Location = new System.Drawing.Point(18, 152);
            this.btnBuy25.Name = "btnBuy25";
            this.btnBuy25.Size = new System.Drawing.Size(50, 23);
            this.btnBuy25.TabIndex = 8;
            this.btnBuy25.Text = "25%";
            this.btnBuy25.UseVisualStyleBackColor = true;
            this.btnBuy25.Click += new System.EventHandler(this.btnBuy25_Click);
            // 
            // txtBuyAmountUsdt
            // 
            this.txtBuyAmountUsdt.Location = new System.Drawing.Point(130, 125);
            this.txtBuyAmountUsdt.Name = "txtBuyAmountUsdt";
            this.txtBuyAmountUsdt.Size = new System.Drawing.Size(106, 21);
            this.txtBuyAmountUsdt.TabIndex = 7;
            this.txtBuyAmountUsdt.TextChanged += new System.EventHandler(this.txtBuyAmountUsdt_TextChanged);
            // 
            // lblBuyAmountUsdt
            // 
            this.lblBuyAmountUsdt.AutoSize = true;
            this.lblBuyAmountUsdt.Location = new System.Drawing.Point(127, 107);
            this.lblBuyAmountUsdt.Name = "lblBuyAmountUsdt";
            this.lblBuyAmountUsdt.Size = new System.Drawing.Size(40, 15);
            this.lblBuyAmountUsdt.TabIndex = 6;
            this.lblBuyAmountUsdt.Text = "USDT";
            // 
            // txtBuyAmount
            // 
            this.txtBuyAmount.Location = new System.Drawing.Point(18, 125);
            this.txtBuyAmount.Name = "txtBuyAmount";
            this.txtBuyAmount.Size = new System.Drawing.Size(106, 21);
            this.txtBuyAmount.TabIndex = 5;
            this.txtBuyAmount.TextChanged += new System.EventHandler(this.txtBuyAmount_TextChanged);
            // 
            // lblBuyAmount
            // 
            this.lblBuyAmount.AutoSize = true;
            this.lblBuyAmount.Location = new System.Drawing.Point(15, 107);
            this.lblBuyAmount.Name = "lblBuyAmount";
            this.lblBuyAmount.Size = new System.Drawing.Size(49, 15);
            this.lblBuyAmount.TabIndex = 4;
            this.lblBuyAmount.Text = "Amount";
            // 
            // txtBuyPriceUsdt
            // 
            this.txtBuyPriceUsdt.Location = new System.Drawing.Point(130, 81);
            this.txtBuyPriceUsdt.Name = "txtBuyPriceUsdt";
            this.txtBuyPriceUsdt.Size = new System.Drawing.Size(106, 21);
            this.txtBuyPriceUsdt.TabIndex = 3;
            // 
            // lblBuyPriceUsdt
            // 
            this.lblBuyPriceUsdt.AutoSize = true;
            this.lblBuyPriceUsdt.Location = new System.Drawing.Point(127, 63);
            this.lblBuyPriceUsdt.Name = "lblBuyPriceUsdt";
            this.lblBuyPriceUsdt.Size = new System.Drawing.Size(40, 15);
            this.lblBuyPriceUsdt.TabIndex = 2;
            this.lblBuyPriceUsdt.Text = "USDT";
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.Location = new System.Drawing.Point(18, 81);
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.Size = new System.Drawing.Size(106, 21);
            this.txtBuyPrice.TabIndex = 1;
            this.txtBuyPrice.TextChanged += new System.EventHandler(this.txtBuyPrice_TextChanged);
            // 
            // lblBuyPrice
            // 
            this.lblBuyPrice.AutoSize = true;
            this.lblBuyPrice.Location = new System.Drawing.Point(15, 63);
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
            this.gbSell.Location = new System.Drawing.Point(266, 112);
            this.gbSell.Name = "gbSell";
            this.gbSell.Size = new System.Drawing.Size(252, 264);
            this.gbSell.TabIndex = 2;
            this.gbSell.TabStop = false;
            this.gbSell.Text = "Sell";
            // 
            // lblBalanceTitleSell
            // 
            this.lblBalanceTitleSell.AutoSize = true;
            this.lblBalanceTitleSell.Location = new System.Drawing.Point(14, 26);
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
            this.lblBalanceSell.Location = new System.Drawing.Point(109, 26);
            this.lblBalanceSell.Name = "lblBalanceSell";
            this.lblBalanceSell.Size = new System.Drawing.Size(14, 15);
            this.lblBalanceSell.TabIndex = 19;
            this.lblBalanceSell.Text = "0";
            this.lblBalanceSell.Click += new System.EventHandler(this.lblBalanceSell_Click);
            // 
            // txtSellTotalUsdt
            // 
            this.txtSellTotalUsdt.Location = new System.Drawing.Point(129, 201);
            this.txtSellTotalUsdt.Name = "txtSellTotalUsdt";
            this.txtSellTotalUsdt.Size = new System.Drawing.Size(106, 21);
            this.txtSellTotalUsdt.TabIndex = 17;
            // 
            // lblSellTotalUsdt
            // 
            this.lblSellTotalUsdt.AutoSize = true;
            this.lblSellTotalUsdt.Location = new System.Drawing.Point(126, 183);
            this.lblSellTotalUsdt.Name = "lblSellTotalUsdt";
            this.lblSellTotalUsdt.Size = new System.Drawing.Size(40, 15);
            this.lblSellTotalUsdt.TabIndex = 16;
            this.lblSellTotalUsdt.Text = "USDT";
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(51, 229);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(156, 22);
            this.btnSell.TabIndex = 15;
            this.btnSell.Text = "SELL";
            this.btnSell.UseVisualStyleBackColor = true;
            // 
            // txtSellTotal
            // 
            this.txtSellTotal.Location = new System.Drawing.Point(17, 201);
            this.txtSellTotal.Name = "txtSellTotal";
            this.txtSellTotal.Size = new System.Drawing.Size(106, 21);
            this.txtSellTotal.TabIndex = 14;
            this.txtSellTotal.TextChanged += new System.EventHandler(this.txtSellTotal_TextChanged);
            // 
            // lblSellTotal
            // 
            this.lblSellTotal.AutoSize = true;
            this.lblSellTotal.Location = new System.Drawing.Point(14, 183);
            this.lblSellTotal.Name = "lblSellTotal";
            this.lblSellTotal.Size = new System.Drawing.Size(34, 15);
            this.lblSellTotal.TabIndex = 13;
            this.lblSellTotal.Text = "Total";
            // 
            // btnSell100
            // 
            this.btnSell100.Location = new System.Drawing.Point(185, 153);
            this.btnSell100.Name = "btnSell100";
            this.btnSell100.Size = new System.Drawing.Size(50, 22);
            this.btnSell100.TabIndex = 15;
            this.btnSell100.Text = "100%";
            this.btnSell100.UseVisualStyleBackColor = true;
            this.btnSell100.Click += new System.EventHandler(this.btnSell100_Click);
            // 
            // txtSellAmountUsdt
            // 
            this.txtSellAmountUsdt.Location = new System.Drawing.Point(129, 125);
            this.txtSellAmountUsdt.Name = "txtSellAmountUsdt";
            this.txtSellAmountUsdt.Size = new System.Drawing.Size(106, 21);
            this.txtSellAmountUsdt.TabIndex = 8;
            // 
            // btnSell75
            // 
            this.btnSell75.Location = new System.Drawing.Point(129, 153);
            this.btnSell75.Name = "btnSell75";
            this.btnSell75.Size = new System.Drawing.Size(50, 22);
            this.btnSell75.TabIndex = 14;
            this.btnSell75.Text = "75%";
            this.btnSell75.UseVisualStyleBackColor = true;
            this.btnSell75.Click += new System.EventHandler(this.btnSell75_Click);
            // 
            // btnSell50
            // 
            this.btnSell50.Location = new System.Drawing.Point(73, 153);
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
            this.lblSellAmountUsdt.Location = new System.Drawing.Point(126, 107);
            this.lblSellAmountUsdt.Name = "lblSellAmountUsdt";
            this.lblSellAmountUsdt.Size = new System.Drawing.Size(40, 15);
            this.lblSellAmountUsdt.TabIndex = 7;
            this.lblSellAmountUsdt.Text = "USDT";
            // 
            // btnSell25
            // 
            this.btnSell25.Location = new System.Drawing.Point(17, 153);
            this.btnSell25.Name = "btnSell25";
            this.btnSell25.Size = new System.Drawing.Size(50, 22);
            this.btnSell25.TabIndex = 12;
            this.btnSell25.Text = "25%";
            this.btnSell25.UseVisualStyleBackColor = true;
            this.btnSell25.Click += new System.EventHandler(this.btnSell25_Click);
            // 
            // txtSellAmount
            // 
            this.txtSellAmount.Location = new System.Drawing.Point(17, 125);
            this.txtSellAmount.Name = "txtSellAmount";
            this.txtSellAmount.Size = new System.Drawing.Size(106, 21);
            this.txtSellAmount.TabIndex = 6;
            this.txtSellAmount.TextChanged += new System.EventHandler(this.txtSellAmount_TextChanged);
            // 
            // lblSellAmount
            // 
            this.lblSellAmount.AutoSize = true;
            this.lblSellAmount.Location = new System.Drawing.Point(14, 107);
            this.lblSellAmount.Name = "lblSellAmount";
            this.lblSellAmount.Size = new System.Drawing.Size(49, 15);
            this.lblSellAmount.TabIndex = 5;
            this.lblSellAmount.Text = "Amount";
            // 
            // txtSellPriceUsdt
            // 
            this.txtSellPriceUsdt.Location = new System.Drawing.Point(129, 81);
            this.txtSellPriceUsdt.Name = "txtSellPriceUsdt";
            this.txtSellPriceUsdt.Size = new System.Drawing.Size(106, 21);
            this.txtSellPriceUsdt.TabIndex = 4;
            // 
            // lblSellPriceUsdt
            // 
            this.lblSellPriceUsdt.AutoSize = true;
            this.lblSellPriceUsdt.Location = new System.Drawing.Point(126, 63);
            this.lblSellPriceUsdt.Name = "lblSellPriceUsdt";
            this.lblSellPriceUsdt.Size = new System.Drawing.Size(40, 15);
            this.lblSellPriceUsdt.TabIndex = 3;
            this.lblSellPriceUsdt.Text = "USDT";
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Location = new System.Drawing.Point(17, 81);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(106, 21);
            this.txtSellPrice.TabIndex = 2;
            this.txtSellPrice.TextChanged += new System.EventHandler(this.txtSellPrice_TextChanged);
            // 
            // lblSellPrice
            // 
            this.lblSellPrice.AutoSize = true;
            this.lblSellPrice.Location = new System.Drawing.Point(14, 63);
            this.lblSellPrice.Name = "lblSellPrice";
            this.lblSellPrice.Size = new System.Drawing.Size(35, 15);
            this.lblSellPrice.TabIndex = 1;
            this.lblSellPrice.Text = "Price";
            // 
            // tabsMarkets
            // 
            this.tabsMarkets.Controls.Add(this.tabUsdt);
            this.tabsMarkets.Controls.Add(this.tabBtc);
            this.tabsMarkets.Controls.Add(this.tabEth);
            this.tabsMarkets.Controls.Add(this.tabXmr);
            this.tabsMarkets.Location = new System.Drawing.Point(482, 6);
            this.tabsMarkets.Name = "tabsMarkets";
            this.tabsMarkets.SelectedIndex = 0;
            this.tabsMarkets.Size = new System.Drawing.Size(192, 392);
            this.tabsMarkets.TabIndex = 0;
            // 
            // tabUsdt
            // 
            this.tabUsdt.BackColor = System.Drawing.Color.AliceBlue;
            this.tabUsdt.Controls.Add(this.lbCoins);
            this.tabUsdt.Location = new System.Drawing.Point(4, 22);
            this.tabUsdt.Name = "tabUsdt";
            this.tabUsdt.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsdt.Size = new System.Drawing.Size(184, 366);
            this.tabUsdt.TabIndex = 0;
            this.tabUsdt.Text = "USDT";
            // 
            // lbCoins
            // 
            this.lbCoins.FormattingEnabled = true;
            this.lbCoins.Location = new System.Drawing.Point(16, 18);
            this.lbCoins.Name = "lbCoins";
            this.lbCoins.Size = new System.Drawing.Size(151, 329);
            this.lbCoins.TabIndex = 5;
            this.lbCoins.SelectedIndexChanged += new System.EventHandler(this.lbCoins_SelectedIndexChanged);
            // 
            // tabBtc
            // 
            this.tabBtc.Location = new System.Drawing.Point(4, 22);
            this.tabBtc.Name = "tabBtc";
            this.tabBtc.Padding = new System.Windows.Forms.Padding(3);
            this.tabBtc.Size = new System.Drawing.Size(184, 366);
            this.tabBtc.TabIndex = 1;
            this.tabBtc.Text = "BTC";
            this.tabBtc.UseVisualStyleBackColor = true;
            // 
            // tabEth
            // 
            this.tabEth.Location = new System.Drawing.Point(4, 22);
            this.tabEth.Name = "tabEth";
            this.tabEth.Padding = new System.Windows.Forms.Padding(3);
            this.tabEth.Size = new System.Drawing.Size(184, 366);
            this.tabEth.TabIndex = 2;
            this.tabEth.Text = "ETH";
            this.tabEth.UseVisualStyleBackColor = true;
            // 
            // tabXmr
            // 
            this.tabXmr.Location = new System.Drawing.Point(4, 22);
            this.tabXmr.Name = "tabXmr";
            this.tabXmr.Padding = new System.Windows.Forms.Padding(3);
            this.tabXmr.Size = new System.Drawing.Size(184, 366);
            this.tabXmr.TabIndex = 3;
            this.tabXmr.Text = "XMR";
            this.tabXmr.UseVisualStyleBackColor = true;
            // 
            // tabBinance
            // 
            this.tabBinance.Location = new System.Drawing.Point(23, 4);
            this.tabBinance.Name = "tabBinance";
            this.tabBinance.Padding = new System.Windows.Forms.Padding(3);
            this.tabBinance.Size = new System.Drawing.Size(1231, 404);
            this.tabBinance.TabIndex = 1;
            this.tabBinance.Text = "Binance";
            this.tabBinance.UseVisualStyleBackColor = true;
            // 
            // dgvCurrentTrades
            // 
            this.dgvCurrentTrades.AutoGenerateColumns = false;
            this.dgvCurrentTrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentTrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.currencyPairDataGridViewTextBoxColumn2,
            this.statusDataGridViewTextBoxColumn1,
            this.amountDataGridViewTextBoxColumn1,
            this.pricePaidDataGridViewTextBoxColumn1,
            this.priceLastDataGridViewTextBoxColumn1,
            this.highestPriceDataGridViewTextBoxColumn1,
            this.profitDataGridViewTextBoxColumn1,
            this.higuestProfitDataGridViewTextBoxColumn1,
            this.highestProfitDiffDataGridViewTextBoxColumn1,
            this.lossToleranceDataGridViewTextBoxColumn1,
            this.baseCurrencyTotalDataGridViewTextBoxColumn1,
            this.usdTotalValueDataGridViewTextBoxColumn1,
            this.timeDataGridViewTextBoxColumn1});
            this.dgvCurrentTrades.DataSource = this.tickerModelBindingSource2;
            this.dgvCurrentTrades.Location = new System.Drawing.Point(35, 430);
            this.dgvCurrentTrades.Name = "dgvCurrentTrades";
            this.dgvCurrentTrades.Size = new System.Drawing.Size(1235, 107);
            this.dgvCurrentTrades.TabIndex = 3;
            // 
            // tickerModelBindingSource
            // 
            this.tickerModelBindingSource.DataSource = typeof(Jojatekok.PoloniexAPI.TickerModel);
            // 
            // dgvClosedTrades
            // 
            this.dgvClosedTrades.AutoGenerateColumns = false;
            this.dgvClosedTrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClosedTrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn12,
            this.currencyPairDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.pricePaidDataGridViewTextBoxColumn,
            this.priceLastDataGridViewTextBoxColumn,
            this.highestPriceDataGridViewTextBoxColumn,
            this.profitDataGridViewTextBoxColumn,
            this.higuestProfitDataGridViewTextBoxColumn,
            this.highestProfitDiffDataGridViewTextBoxColumn,
            this.lossToleranceDataGridViewTextBoxColumn,
            this.baseCurrencyTotalDataGridViewTextBoxColumn,
            this.usdTotalValueDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn});
            this.dgvClosedTrades.DataSource = this.tickerModelBindingSource;
            this.dgvClosedTrades.Location = new System.Drawing.Point(35, 543);
            this.dgvClosedTrades.Name = "dgvClosedTrades";
            this.dgvClosedTrades.Size = new System.Drawing.Size(1235, 103);
            this.dgvClosedTrades.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "priceLast";
            this.dataGridViewTextBoxColumn4.HeaderText = "priceLast";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "time";
            this.dataGridViewTextBoxColumn12.HeaderText = "time";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
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
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
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
            // highestPriceDataGridViewTextBoxColumn
            // 
            this.highestPriceDataGridViewTextBoxColumn.DataPropertyName = "HighestPrice";
            this.highestPriceDataGridViewTextBoxColumn.HeaderText = "HighestPrice";
            this.highestPriceDataGridViewTextBoxColumn.Name = "highestPriceDataGridViewTextBoxColumn";
            // 
            // profitDataGridViewTextBoxColumn
            // 
            this.profitDataGridViewTextBoxColumn.DataPropertyName = "Profit";
            this.profitDataGridViewTextBoxColumn.HeaderText = "Profit";
            this.profitDataGridViewTextBoxColumn.Name = "profitDataGridViewTextBoxColumn";
            // 
            // higuestProfitDataGridViewTextBoxColumn
            // 
            this.higuestProfitDataGridViewTextBoxColumn.DataPropertyName = "HiguestProfit";
            this.higuestProfitDataGridViewTextBoxColumn.HeaderText = "HiguestProfit";
            this.higuestProfitDataGridViewTextBoxColumn.Name = "higuestProfitDataGridViewTextBoxColumn";
            // 
            // highestProfitDiffDataGridViewTextBoxColumn
            // 
            this.highestProfitDiffDataGridViewTextBoxColumn.DataPropertyName = "HighestProfitDiff";
            this.highestProfitDiffDataGridViewTextBoxColumn.HeaderText = "HighestProfitDiff";
            this.highestProfitDiffDataGridViewTextBoxColumn.Name = "highestProfitDiffDataGridViewTextBoxColumn";
            // 
            // lossToleranceDataGridViewTextBoxColumn
            // 
            this.lossToleranceDataGridViewTextBoxColumn.DataPropertyName = "LossTolerance";
            this.lossToleranceDataGridViewTextBoxColumn.HeaderText = "LossTolerance";
            this.lossToleranceDataGridViewTextBoxColumn.Name = "lossToleranceDataGridViewTextBoxColumn";
            // 
            // baseCurrencyTotalDataGridViewTextBoxColumn
            // 
            this.baseCurrencyTotalDataGridViewTextBoxColumn.DataPropertyName = "BaseCurrencyTotal";
            this.baseCurrencyTotalDataGridViewTextBoxColumn.HeaderText = "BaseCurrencyTotal";
            this.baseCurrencyTotalDataGridViewTextBoxColumn.Name = "baseCurrencyTotalDataGridViewTextBoxColumn";
            // 
            // usdTotalValueDataGridViewTextBoxColumn
            // 
            this.usdTotalValueDataGridViewTextBoxColumn.DataPropertyName = "UsdTotalValue";
            this.usdTotalValueDataGridViewTextBoxColumn.HeaderText = "UsdTotalValue";
            this.usdTotalValueDataGridViewTextBoxColumn.Name = "usdTotalValueDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // tickerModelBindingSource2
            // 
            this.tickerModelBindingSource2.DataSource = typeof(Jojatekok.PoloniexAPI.TickerModel);
            // 
            // currencyPairDataGridViewTextBoxColumn2
            // 
            this.currencyPairDataGridViewTextBoxColumn2.DataPropertyName = "CurrencyPair";
            this.currencyPairDataGridViewTextBoxColumn2.HeaderText = "CurrencyPair";
            this.currencyPairDataGridViewTextBoxColumn2.Name = "currencyPairDataGridViewTextBoxColumn2";
            // 
            // statusDataGridViewTextBoxColumn1
            // 
            this.statusDataGridViewTextBoxColumn1.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn1.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn1.Name = "statusDataGridViewTextBoxColumn1";
            // 
            // amountDataGridViewTextBoxColumn1
            // 
            this.amountDataGridViewTextBoxColumn1.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn1.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn1.Name = "amountDataGridViewTextBoxColumn1";
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
            // highestPriceDataGridViewTextBoxColumn1
            // 
            this.highestPriceDataGridViewTextBoxColumn1.DataPropertyName = "HighestPrice";
            this.highestPriceDataGridViewTextBoxColumn1.HeaderText = "HighestPrice";
            this.highestPriceDataGridViewTextBoxColumn1.Name = "highestPriceDataGridViewTextBoxColumn1";
            // 
            // profitDataGridViewTextBoxColumn1
            // 
            this.profitDataGridViewTextBoxColumn1.DataPropertyName = "Profit";
            this.profitDataGridViewTextBoxColumn1.HeaderText = "Profit";
            this.profitDataGridViewTextBoxColumn1.Name = "profitDataGridViewTextBoxColumn1";
            // 
            // higuestProfitDataGridViewTextBoxColumn1
            // 
            this.higuestProfitDataGridViewTextBoxColumn1.DataPropertyName = "HiguestProfit";
            this.higuestProfitDataGridViewTextBoxColumn1.HeaderText = "HiguestProfit";
            this.higuestProfitDataGridViewTextBoxColumn1.Name = "higuestProfitDataGridViewTextBoxColumn1";
            // 
            // highestProfitDiffDataGridViewTextBoxColumn1
            // 
            this.highestProfitDiffDataGridViewTextBoxColumn1.DataPropertyName = "HighestProfitDiff";
            this.highestProfitDiffDataGridViewTextBoxColumn1.HeaderText = "HighestProfitDiff";
            this.highestProfitDiffDataGridViewTextBoxColumn1.Name = "highestProfitDiffDataGridViewTextBoxColumn1";
            // 
            // lossToleranceDataGridViewTextBoxColumn1
            // 
            this.lossToleranceDataGridViewTextBoxColumn1.DataPropertyName = "LossTolerance";
            this.lossToleranceDataGridViewTextBoxColumn1.HeaderText = "LossTolerance";
            this.lossToleranceDataGridViewTextBoxColumn1.Name = "lossToleranceDataGridViewTextBoxColumn1";
            // 
            // baseCurrencyTotalDataGridViewTextBoxColumn1
            // 
            this.baseCurrencyTotalDataGridViewTextBoxColumn1.DataPropertyName = "BaseCurrencyTotal";
            this.baseCurrencyTotalDataGridViewTextBoxColumn1.HeaderText = "BaseCurrencyTotal";
            this.baseCurrencyTotalDataGridViewTextBoxColumn1.Name = "baseCurrencyTotalDataGridViewTextBoxColumn1";
            // 
            // usdTotalValueDataGridViewTextBoxColumn1
            // 
            this.usdTotalValueDataGridViewTextBoxColumn1.DataPropertyName = "UsdTotalValue";
            this.usdTotalValueDataGridViewTextBoxColumn1.HeaderText = "UsdTotalValue";
            this.usdTotalValueDataGridViewTextBoxColumn1.Name = "usdTotalValueDataGridViewTextBoxColumn1";
            // 
            // timeDataGridViewTextBoxColumn1
            // 
            this.timeDataGridViewTextBoxColumn1.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn1.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn1.Name = "timeDataGridViewTextBoxColumn1";
            // 
            // currencyPairDataGridViewTextBoxColumn1
            // 
            this.currencyPairDataGridViewTextBoxColumn1.DataPropertyName = "CurrencyPair";
            this.currencyPairDataGridViewTextBoxColumn1.HeaderText = "CurrencyPair";
            this.currencyPairDataGridViewTextBoxColumn1.Name = "currencyPairDataGridViewTextBoxColumn1";
            // 
            // statusDataGridViewTextBoxColumn2
            // 
            this.statusDataGridViewTextBoxColumn2.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn2.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn2.Name = "statusDataGridViewTextBoxColumn2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 681);
            this.Controls.Add(this.dgvClosedTrades);
            this.Controls.Add(this.dgvCurrentTrades);
            this.Controls.Add(this.tabsExchanges);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabsExchanges.ResumeLayout(false);
            this.tabPoloniex.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickerModelBindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceModelBindingSource)).EndInit();
            this.gbTrade.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbBuy.ResumeLayout(false);
            this.gbBuy.PerformLayout();
            this.gbSell.ResumeLayout(false);
            this.gbSell.PerformLayout();
            this.tabsMarkets.ResumeLayout(false);
            this.tabUsdt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentTrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickerModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClosedTrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickerModelBindingSource2)).EndInit();
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
        private System.Windows.Forms.BindingSource tickerModelBindingSource;
        private System.Windows.Forms.DataGridView dgvBalances;
        private System.Windows.Forms.BindingSource balanceModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteAvailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteOnOrdersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSDTValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox lbCoins;
        private System.Windows.Forms.Label lblBalanceTitleBuy;
        private System.Windows.Forms.Label lblBalanceBuy;
        private System.Windows.Forms.Label lblBalanceSell;
        private System.Windows.Forms.Label lblBalanceTitleSell;
        private System.Windows.Forms.GroupBox gbTrade;
        private System.Windows.Forms.TextBox txtBotAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBalancesTitleQuote;
        private System.Windows.Forms.Label lblBalancesTitleBase;
        private System.Windows.Forms.Label lblBalancesQuote;
        private System.Windows.Forms.Label lblBalancesBase;
        private System.Windows.Forms.DataGridView dgvClosedTrades;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvBots;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource tickerModelBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyPairDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePaidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceLastDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn highestPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn higuestProfitDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn highestProfitDiffDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lossToleranceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseCurrencyTotalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usdTotalValueDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource tickerModelBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyPairDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceLastDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn highestPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn higuestProfitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn highestProfitDiffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lossToleranceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseCurrencyTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usdTotalValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyPairDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn2;
    }
}

