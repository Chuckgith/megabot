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
            this.tabsMarkets = new System.Windows.Forms.TabControl();
            this.tabUsdt = new System.Windows.Forms.TabPage();
            this.lbCoins = new System.Windows.Forms.ListBox();
            this.tabBtc = new System.Windows.Forms.TabPage();
            this.tabEth = new System.Windows.Forms.TabPage();
            this.tabXmr = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBotAmount = new System.Windows.Forms.TextBox();
            this.txtBotLossTolerance = new System.Windows.Forms.TextBox();
            this.lblLossTolerance = new System.Windows.Forms.Label();
            this.lblBalancesQuote = new System.Windows.Forms.Label();
            this.lblBalancesBase = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBalancesTitleQuote = new System.Windows.Forms.Label();
            this.lblBalancesTitleBase = new System.Windows.Forms.Label();
            this.btnStartBot = new System.Windows.Forms.Button();
            this.txtBotMultiplicator = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBalances = new System.Windows.Forms.DataGridView();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoteAvailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoteOnOrdersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSDTValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabBinance = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.gbTrade = new System.Windows.Forms.GroupBox();
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
            this.dgvClosedTrades = new System.Windows.Forms.DataGridView();
            this.balanceModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flatBotModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lossToleranceMultiplicatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toleranceProfitHighDiffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastTickerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lossToleranceMultiplicatorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toleranceProfitHighDiffDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastTickerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabsExchanges.SuspendLayout();
            this.tabPoloniex.SuspendLayout();
            this.tabsMarkets.SuspendLayout();
            this.tabUsdt.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalances)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.gbTrade.SuspendLayout();
            this.gbBuy.SuspendLayout();
            this.gbSell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentTrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClosedTrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatBotModelBindingSource)).BeginInit();
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
            this.tabsExchanges.Size = new System.Drawing.Size(514, 435);
            this.tabsExchanges.TabIndex = 0;
            // 
            // tabPoloniex
            // 
            this.tabPoloniex.Controls.Add(this.tabsMarkets);
            this.tabPoloniex.Controls.Add(this.groupBox1);
            this.tabPoloniex.Controls.Add(this.groupBox2);
            this.tabPoloniex.Location = new System.Drawing.Point(23, 4);
            this.tabPoloniex.Name = "tabPoloniex";
            this.tabPoloniex.Padding = new System.Windows.Forms.Padding(3);
            this.tabPoloniex.Size = new System.Drawing.Size(487, 427);
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
            this.tabsMarkets.Size = new System.Drawing.Size(243, 240);
            this.tabsMarkets.TabIndex = 0;
            // 
            // tabUsdt
            // 
            this.tabUsdt.BackColor = System.Drawing.Color.AliceBlue;
            this.tabUsdt.Controls.Add(this.lbCoins);
            this.tabUsdt.Location = new System.Drawing.Point(4, 22);
            this.tabUsdt.Name = "tabUsdt";
            this.tabUsdt.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsdt.Size = new System.Drawing.Size(235, 214);
            this.tabUsdt.TabIndex = 0;
            this.tabUsdt.Text = "USDT";
            // 
            // lbCoins
            // 
            this.lbCoins.FormattingEnabled = true;
            this.lbCoins.Location = new System.Drawing.Point(9, 6);
            this.lbCoins.Name = "lbCoins";
            this.lbCoins.Size = new System.Drawing.Size(220, 199);
            this.lbCoins.TabIndex = 5;
            this.lbCoins.SelectedIndexChanged += new System.EventHandler(this.lbCoins_SelectedIndexChanged);
            // 
            // tabBtc
            // 
            this.tabBtc.Location = new System.Drawing.Point(4, 22);
            this.tabBtc.Name = "tabBtc";
            this.tabBtc.Padding = new System.Windows.Forms.Padding(3);
            this.tabBtc.Size = new System.Drawing.Size(235, 214);
            this.tabBtc.TabIndex = 1;
            this.tabBtc.Text = "BTC";
            this.tabBtc.UseVisualStyleBackColor = true;
            // 
            // tabEth
            // 
            this.tabEth.Location = new System.Drawing.Point(4, 22);
            this.tabEth.Name = "tabEth";
            this.tabEth.Padding = new System.Windows.Forms.Padding(3);
            this.tabEth.Size = new System.Drawing.Size(235, 214);
            this.tabEth.TabIndex = 2;
            this.tabEth.Text = "ETH";
            this.tabEth.UseVisualStyleBackColor = true;
            // 
            // tabXmr
            // 
            this.tabXmr.Location = new System.Drawing.Point(4, 22);
            this.tabXmr.Name = "tabXmr";
            this.tabXmr.Padding = new System.Windows.Forms.Padding(3);
            this.tabXmr.Size = new System.Drawing.Size(235, 214);
            this.tabXmr.TabIndex = 3;
            this.tabXmr.Text = "XMR";
            this.tabXmr.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBotAmount);
            this.groupBox1.Controls.Add(this.txtBotLossTolerance);
            this.groupBox1.Controls.Add(this.lblLossTolerance);
            this.groupBox1.Controls.Add(this.lblBalancesQuote);
            this.groupBox1.Controls.Add(this.lblBalancesBase);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblBalancesTitleQuote);
            this.groupBox1.Controls.Add(this.lblBalancesTitleBase);
            this.groupBox1.Controls.Add(this.btnStartBot);
            this.groupBox1.Controls.Add(this.txtBotMultiplicator);
            this.groupBox1.Location = new System.Drawing.Point(255, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 240);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Balances";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Amount";
            // 
            // txtBotAmount
            // 
            this.txtBotAmount.Location = new System.Drawing.Point(93, 74);
            this.txtBotAmount.Name = "txtBotAmount";
            this.txtBotAmount.Size = new System.Drawing.Size(106, 20);
            this.txtBotAmount.TabIndex = 23;
            // 
            // txtBotLossTolerance
            // 
            this.txtBotLossTolerance.Location = new System.Drawing.Point(93, 99);
            this.txtBotLossTolerance.Name = "txtBotLossTolerance";
            this.txtBotLossTolerance.Size = new System.Drawing.Size(106, 20);
            this.txtBotLossTolerance.TabIndex = 22;
            // 
            // lblLossTolerance
            // 
            this.lblLossTolerance.AutoSize = true;
            this.lblLossTolerance.Location = new System.Drawing.Point(11, 102);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 128);
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
            this.btnStartBot.Location = new System.Drawing.Point(109, 211);
            this.btnStartBot.Name = "btnStartBot";
            this.btnStartBot.Size = new System.Drawing.Size(106, 23);
            this.btnStartBot.TabIndex = 3;
            this.btnStartBot.Text = "Start bot";
            this.btnStartBot.UseVisualStyleBackColor = true;
            this.btnStartBot.Click += new System.EventHandler(this.btnStartBot_Click);
            // 
            // txtBotMultiplicator
            // 
            this.txtBotMultiplicator.Location = new System.Drawing.Point(93, 125);
            this.txtBotMultiplicator.Name = "txtBotMultiplicator";
            this.txtBotMultiplicator.Size = new System.Drawing.Size(106, 20);
            this.txtBotMultiplicator.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.dgvBalances);
            this.groupBox2.Location = new System.Drawing.Point(6, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 165);
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
            this.dgvBalances.Size = new System.Drawing.Size(458, 136);
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
            this.tabBinance.Size = new System.Drawing.Size(487, 427);
            this.tabBinance.TabIndex = 1;
            this.tabBinance.Text = "Binance";
            this.tabBinance.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox3.Controls.Add(this.txtLogs);
            this.groupBox3.Location = new System.Drawing.Point(532, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(549, 146);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Logs";
            // 
            // txtLogs
            // 
            this.txtLogs.Location = new System.Drawing.Point(15, 19);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogs.Size = new System.Drawing.Size(515, 121);
            this.txtLogs.TabIndex = 0;
            // 
            // gbTrade
            // 
            this.gbTrade.BackColor = System.Drawing.Color.Azure;
            this.gbTrade.Controls.Add(this.gbBuy);
            this.gbTrade.Controls.Add(this.gbSell);
            this.gbTrade.Location = new System.Drawing.Point(532, 12);
            this.gbTrade.Name = "gbTrade";
            this.gbTrade.Size = new System.Drawing.Size(549, 283);
            this.gbTrade.TabIndex = 6;
            this.gbTrade.TabStop = false;
            this.gbTrade.Text = "Trade";
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
            this.gbBuy.Location = new System.Drawing.Point(15, 19);
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
            this.gbSell.Location = new System.Drawing.Point(276, 19);
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
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.lossToleranceMultiplicatorDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.toleranceProfitHighDiffDataGridViewTextBoxColumn,
            this.lastTickerDataGridViewTextBoxColumn});
            this.dgvCurrentTrades.DataSource = this.flatBotModelBindingSource;
            this.dgvCurrentTrades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCurrentTrades.Location = new System.Drawing.Point(35, 453);
            this.dgvCurrentTrades.Name = "dgvCurrentTrades";
            this.dgvCurrentTrades.Size = new System.Drawing.Size(1321, 115);
            this.dgvCurrentTrades.TabIndex = 3;
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
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.lossToleranceMultiplicatorDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.toleranceProfitHighDiffDataGridViewTextBoxColumn1,
            this.lastTickerDataGridViewTextBoxColumn1});
            this.dgvClosedTrades.DataSource = this.flatBotModelBindingSource;
            this.dgvClosedTrades.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClosedTrades.Location = new System.Drawing.Point(35, 574);
            this.dgvClosedTrades.Name = "dgvClosedTrades";
            this.dgvClosedTrades.Size = new System.Drawing.Size(1321, 282);
            this.dgvClosedTrades.TabIndex = 4;
            // 
            // balanceModelBindingSource
            // 
            this.balanceModelBindingSource.DataSource = typeof(Jojatekok.PoloniexAPI.BalanceModel);
            // 
            // flatBotModelBindingSource
            // 
            this.flatBotModelBindingSource.DataSource = typeof(FormConsole.FlatTradeModel);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CurrencyPair";
            this.dataGridViewTextBoxColumn4.HeaderText = "CurrencyPair";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn12.HeaderText = "Status";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn13.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "LossTolerance";
            this.dataGridViewTextBoxColumn14.HeaderText = "LossTolerance";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // lossToleranceMultiplicatorDataGridViewTextBoxColumn
            // 
            this.lossToleranceMultiplicatorDataGridViewTextBoxColumn.DataPropertyName = "LossToleranceMultiplicator";
            this.lossToleranceMultiplicatorDataGridViewTextBoxColumn.HeaderText = "LossToleranceMultiplicator";
            this.lossToleranceMultiplicatorDataGridViewTextBoxColumn.Name = "lossToleranceMultiplicatorDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "PricePaid";
            this.dataGridViewTextBoxColumn15.HeaderText = "PricePaid";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "UsdTotalValue";
            this.dataGridViewTextBoxColumn16.HeaderText = "UsdTotalValue";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "PriceLast";
            this.dataGridViewTextBoxColumn17.HeaderText = "PriceLast";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Profit";
            this.dataGridViewTextBoxColumn18.HeaderText = "Profit";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "HighestProfit";
            this.dataGridViewTextBoxColumn19.HeaderText = "HighestProfit";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "HighestProfitDiff";
            this.dataGridViewTextBoxColumn20.HeaderText = "HighestProfitDiff";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // toleranceProfitHighDiffDataGridViewTextBoxColumn
            // 
            this.toleranceProfitHighDiffDataGridViewTextBoxColumn.DataPropertyName = "ToleranceProfitHighDiff";
            this.toleranceProfitHighDiffDataGridViewTextBoxColumn.HeaderText = "ToleranceProfitHighDiff";
            this.toleranceProfitHighDiffDataGridViewTextBoxColumn.Name = "toleranceProfitHighDiffDataGridViewTextBoxColumn";
            // 
            // lastTickerDataGridViewTextBoxColumn
            // 
            this.lastTickerDataGridViewTextBoxColumn.DataPropertyName = "LastTicker";
            this.lastTickerDataGridViewTextBoxColumn.HeaderText = "LastTicker";
            this.lastTickerDataGridViewTextBoxColumn.Name = "lastTickerDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "CurrencyPair";
            this.dataGridViewTextBoxColumn22.HeaderText = "CurrencyPair";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn24.HeaderText = "Status";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn25.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "LossTolerance";
            this.dataGridViewTextBoxColumn26.HeaderText = "LossTolerance";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // lossToleranceMultiplicatorDataGridViewTextBoxColumn1
            // 
            this.lossToleranceMultiplicatorDataGridViewTextBoxColumn1.DataPropertyName = "LossToleranceMultiplicator";
            this.lossToleranceMultiplicatorDataGridViewTextBoxColumn1.HeaderText = "LossToleranceMultiplicator";
            this.lossToleranceMultiplicatorDataGridViewTextBoxColumn1.Name = "lossToleranceMultiplicatorDataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "PricePaid";
            this.dataGridViewTextBoxColumn27.HeaderText = "PricePaid";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "UsdTotalValue";
            this.dataGridViewTextBoxColumn28.HeaderText = "UsdTotalValue";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "PriceLast";
            this.dataGridViewTextBoxColumn29.HeaderText = "PriceLast";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "Profit";
            this.dataGridViewTextBoxColumn30.HeaderText = "Profit";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "HighestProfit";
            this.dataGridViewTextBoxColumn31.HeaderText = "HighestProfit";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "HighestProfitDiff";
            this.dataGridViewTextBoxColumn32.HeaderText = "HighestProfitDiff";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            // 
            // toleranceProfitHighDiffDataGridViewTextBoxColumn1
            // 
            this.toleranceProfitHighDiffDataGridViewTextBoxColumn1.DataPropertyName = "ToleranceProfitHighDiff";
            this.toleranceProfitHighDiffDataGridViewTextBoxColumn1.HeaderText = "ToleranceProfitHighDiff";
            this.toleranceProfitHighDiffDataGridViewTextBoxColumn1.Name = "toleranceProfitHighDiffDataGridViewTextBoxColumn1";
            // 
            // lastTickerDataGridViewTextBoxColumn1
            // 
            this.lastTickerDataGridViewTextBoxColumn1.DataPropertyName = "LastTicker";
            this.lastTickerDataGridViewTextBoxColumn1.HeaderText = "LastTicker";
            this.lastTickerDataGridViewTextBoxColumn1.Name = "lastTickerDataGridViewTextBoxColumn1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 868);
            this.Controls.Add(this.dgvClosedTrades);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvCurrentTrades);
            this.Controls.Add(this.tabsExchanges);
            this.Controls.Add(this.gbTrade);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabsExchanges.ResumeLayout(false);
            this.tabPoloniex.ResumeLayout(false);
            this.tabsMarkets.ResumeLayout(false);
            this.tabUsdt.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalances)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbTrade.ResumeLayout(false);
            this.gbBuy.ResumeLayout(false);
            this.gbBuy.PerformLayout();
            this.gbSell.ResumeLayout(false);
            this.gbSell.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentTrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClosedTrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatBotModelBindingSource)).EndInit();
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
        private System.Windows.Forms.GroupBox gbTrade;
        private System.Windows.Forms.TextBox txtBotMultiplicator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBalancesTitleQuote;
        private System.Windows.Forms.Label lblBalancesTitleBase;
        private System.Windows.Forms.Label lblBalancesQuote;
        private System.Windows.Forms.Label lblBalancesBase;
        private System.Windows.Forms.DataGridView dgvClosedTrades;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn pricePaidDataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn lossToleranceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox txtLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteAvailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteOnOrdersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSDTValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource balanceModelBindingSource;
        //private System.Windows.Forms.DataGridViewTextBoxColumn currencyPairDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn pricePaidDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn lossToleranceDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn priceLastDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn highestPriceDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn profitDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn highestProfitDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn highestProfitDiffDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn baseCurrencyTotalDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn usdTotalValueDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn currencyPairDataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn pricePaidDataGridViewTextBoxColumn2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn lossToleranceDataGridViewTextBoxColumn2;
        //private System.Windows.Forms.DataGridViewTextBoxColumn priceLastDataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn highestPriceDataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn profitDataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn highestProfitDataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn highestProfitDiffDataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn baseCurrencyTotalDataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn usdTotalValueDataGridViewTextBoxColumn1;
        //private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox txtBotLossTolerance;
        private System.Windows.Forms.Label lblLossTolerance;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBotAmount;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn lossToleranceMultiplicatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn toleranceProfitHighDiffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastTickerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource flatBotModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn lossToleranceMultiplicatorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn toleranceProfitHighDiffDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastTickerDataGridViewTextBoxColumn1;
    }
}

