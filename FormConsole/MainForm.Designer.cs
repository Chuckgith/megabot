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
            this.btnStartBot = new System.Windows.Forms.Button();
            this.grbSell = new System.Windows.Forms.GroupBox();
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
            this.txtSellUsdt = new System.Windows.Forms.TextBox();
            this.lblSellPriceUsdt = new System.Windows.Forms.Label();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.lblSellPrice = new System.Windows.Forms.Label();
            this.grbBuy = new System.Windows.Forms.GroupBox();
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
            this.txtBuyUsdt = new System.Windows.Forms.TextBox();
            this.lblBuyPriceUsdt = new System.Windows.Forms.Label();
            this.txtBuyPrice = new System.Windows.Forms.TextBox();
            this.lblBuyPrice = new System.Windows.Forms.Label();
            this.cbbCoins = new System.Windows.Forms.ComboBox();
            this.tabBtc = new System.Windows.Forms.TabPage();
            this.tabEth = new System.Windows.Forms.TabPage();
            this.tabXmr = new System.Windows.Forms.TabPage();
            this.txtBot = new System.Windows.Forms.TextBox();
            this.tabBinance = new System.Windows.Forms.TabPage();
            this.txtTicker = new System.Windows.Forms.TextBox();
            this.dgvTrades = new System.Windows.Forms.DataGridView();
            this.currencyPairDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountToTradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highestPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.higuestProfitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highestProfitDiffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lossToleranceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseCurrencyTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usdTotalValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tickerModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvBalances = new System.Windows.Forms.DataGridView();
            this.balanceModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoteAvailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoteOnOrdersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSDTValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabsExchanges.SuspendLayout();
            this.tabPoloniex.SuspendLayout();
            this.tabsMarkets.SuspendLayout();
            this.tabUsdt.SuspendLayout();
            this.grbSell.SuspendLayout();
            this.grbBuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickerModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceModelBindingSource)).BeginInit();
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
            this.tabsExchanges.Size = new System.Drawing.Size(1197, 341);
            this.tabsExchanges.TabIndex = 0;
            // 
            // tabPoloniex
            // 
            this.tabPoloniex.Controls.Add(this.dgvBalances);
            this.tabPoloniex.Controls.Add(this.tabsMarkets);
            this.tabPoloniex.Controls.Add(this.txtBot);
            this.tabPoloniex.Location = new System.Drawing.Point(23, 4);
            this.tabPoloniex.Name = "tabPoloniex";
            this.tabPoloniex.Padding = new System.Windows.Forms.Padding(3);
            this.tabPoloniex.Size = new System.Drawing.Size(1170, 333);
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
            this.tabsMarkets.Location = new System.Drawing.Point(6, 6);
            this.tabsMarkets.Name = "tabsMarkets";
            this.tabsMarkets.SelectedIndex = 0;
            this.tabsMarkets.Size = new System.Drawing.Size(672, 321);
            this.tabsMarkets.TabIndex = 0;
            // 
            // tabUsdt
            // 
            this.tabUsdt.Controls.Add(this.btnStartBot);
            this.tabUsdt.Controls.Add(this.grbSell);
            this.tabUsdt.Controls.Add(this.grbBuy);
            this.tabUsdt.Controls.Add(this.cbbCoins);
            this.tabUsdt.Location = new System.Drawing.Point(4, 22);
            this.tabUsdt.Name = "tabUsdt";
            this.tabUsdt.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsdt.Size = new System.Drawing.Size(664, 295);
            this.tabUsdt.TabIndex = 0;
            this.tabUsdt.Text = "USDT";
            this.tabUsdt.UseVisualStyleBackColor = true;
            // 
            // btnStartBot
            // 
            this.btnStartBot.Location = new System.Drawing.Point(173, 16);
            this.btnStartBot.Name = "btnStartBot";
            this.btnStartBot.Size = new System.Drawing.Size(151, 23);
            this.btnStartBot.TabIndex = 3;
            this.btnStartBot.Text = "Start bot";
            this.btnStartBot.UseVisualStyleBackColor = true;
            this.btnStartBot.Click += new System.EventHandler(this.btnStartBot_Click);
            // 
            // grbSell
            // 
            this.grbSell.BackColor = System.Drawing.Color.RosyBrown;
            this.grbSell.Controls.Add(this.txtSellTotalUsdt);
            this.grbSell.Controls.Add(this.lblSellTotalUsdt);
            this.grbSell.Controls.Add(this.btnSell);
            this.grbSell.Controls.Add(this.txtSellTotal);
            this.grbSell.Controls.Add(this.lblSellTotal);
            this.grbSell.Controls.Add(this.btnSell100);
            this.grbSell.Controls.Add(this.txtSellAmountUsdt);
            this.grbSell.Controls.Add(this.btnSell75);
            this.grbSell.Controls.Add(this.btnSell50);
            this.grbSell.Controls.Add(this.lblSellAmountUsdt);
            this.grbSell.Controls.Add(this.btnSell25);
            this.grbSell.Controls.Add(this.txtSellAmount);
            this.grbSell.Controls.Add(this.lblSellAmount);
            this.grbSell.Controls.Add(this.txtSellUsdt);
            this.grbSell.Controls.Add(this.lblSellPriceUsdt);
            this.grbSell.Controls.Add(this.txtSellPrice);
            this.grbSell.Controls.Add(this.lblSellPrice);
            this.grbSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSell.Location = new System.Drawing.Point(335, 45);
            this.grbSell.Name = "grbSell";
            this.grbSell.Size = new System.Drawing.Size(313, 215);
            this.grbSell.TabIndex = 2;
            this.grbSell.TabStop = false;
            this.grbSell.Text = "Sell";
            // 
            // txtSellTotalUsdt
            // 
            this.txtSellTotalUsdt.Location = new System.Drawing.Point(212, 147);
            this.txtSellTotalUsdt.Name = "txtSellTotalUsdt";
            this.txtSellTotalUsdt.Size = new System.Drawing.Size(75, 21);
            this.txtSellTotalUsdt.TabIndex = 17;
            // 
            // lblSellTotalUsdt
            // 
            this.lblSellTotalUsdt.AutoSize = true;
            this.lblSellTotalUsdt.Location = new System.Drawing.Point(166, 150);
            this.lblSellTotalUsdt.Name = "lblSellTotalUsdt";
            this.lblSellTotalUsdt.Size = new System.Drawing.Size(40, 15);
            this.lblSellTotalUsdt.TabIndex = 16;
            this.lblSellTotalUsdt.Text = "USDT";
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(98, 181);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(156, 23);
            this.btnSell.TabIndex = 15;
            this.btnSell.Text = "SELL";
            this.btnSell.UseVisualStyleBackColor = true;
            // 
            // txtSellTotal
            // 
            this.txtSellTotal.Location = new System.Drawing.Point(69, 147);
            this.txtSellTotal.Name = "txtSellTotal";
            this.txtSellTotal.Size = new System.Drawing.Size(75, 21);
            this.txtSellTotal.TabIndex = 14;
            // 
            // lblSellTotal
            // 
            this.lblSellTotal.AutoSize = true;
            this.lblSellTotal.Location = new System.Drawing.Point(14, 150);
            this.lblSellTotal.Name = "lblSellTotal";
            this.lblSellTotal.Size = new System.Drawing.Size(34, 15);
            this.lblSellTotal.TabIndex = 13;
            this.lblSellTotal.Text = "Total";
            // 
            // btnSell100
            // 
            this.btnSell100.Location = new System.Drawing.Point(237, 111);
            this.btnSell100.Name = "btnSell100";
            this.btnSell100.Size = new System.Drawing.Size(50, 23);
            this.btnSell100.TabIndex = 15;
            this.btnSell100.Text = "100%";
            this.btnSell100.UseVisualStyleBackColor = true;
            // 
            // txtSellAmountUsdt
            // 
            this.txtSellAmountUsdt.Location = new System.Drawing.Point(212, 75);
            this.txtSellAmountUsdt.Name = "txtSellAmountUsdt";
            this.txtSellAmountUsdt.Size = new System.Drawing.Size(75, 21);
            this.txtSellAmountUsdt.TabIndex = 8;
            // 
            // btnSell75
            // 
            this.btnSell75.Location = new System.Drawing.Point(181, 111);
            this.btnSell75.Name = "btnSell75";
            this.btnSell75.Size = new System.Drawing.Size(50, 23);
            this.btnSell75.TabIndex = 14;
            this.btnSell75.Text = "75%";
            this.btnSell75.UseVisualStyleBackColor = true;
            // 
            // btnSell50
            // 
            this.btnSell50.Location = new System.Drawing.Point(125, 111);
            this.btnSell50.Name = "btnSell50";
            this.btnSell50.Size = new System.Drawing.Size(50, 23);
            this.btnSell50.TabIndex = 13;
            this.btnSell50.Text = "50%";
            this.btnSell50.UseVisualStyleBackColor = true;
            // 
            // lblSellAmountUsdt
            // 
            this.lblSellAmountUsdt.AutoSize = true;
            this.lblSellAmountUsdt.Location = new System.Drawing.Point(166, 78);
            this.lblSellAmountUsdt.Name = "lblSellAmountUsdt";
            this.lblSellAmountUsdt.Size = new System.Drawing.Size(40, 15);
            this.lblSellAmountUsdt.TabIndex = 7;
            this.lblSellAmountUsdt.Text = "USDT";
            // 
            // btnSell25
            // 
            this.btnSell25.Location = new System.Drawing.Point(69, 111);
            this.btnSell25.Name = "btnSell25";
            this.btnSell25.Size = new System.Drawing.Size(50, 23);
            this.btnSell25.TabIndex = 12;
            this.btnSell25.Text = "25%";
            this.btnSell25.UseVisualStyleBackColor = true;
            // 
            // txtSellAmount
            // 
            this.txtSellAmount.Location = new System.Drawing.Point(69, 75);
            this.txtSellAmount.Name = "txtSellAmount";
            this.txtSellAmount.Size = new System.Drawing.Size(75, 21);
            this.txtSellAmount.TabIndex = 6;
            // 
            // lblSellAmount
            // 
            this.lblSellAmount.AutoSize = true;
            this.lblSellAmount.Location = new System.Drawing.Point(14, 78);
            this.lblSellAmount.Name = "lblSellAmount";
            this.lblSellAmount.Size = new System.Drawing.Size(49, 15);
            this.lblSellAmount.TabIndex = 5;
            this.lblSellAmount.Text = "Amount";
            // 
            // txtSellUsdt
            // 
            this.txtSellUsdt.Location = new System.Drawing.Point(212, 37);
            this.txtSellUsdt.Name = "txtSellUsdt";
            this.txtSellUsdt.Size = new System.Drawing.Size(75, 21);
            this.txtSellUsdt.TabIndex = 4;
            // 
            // lblSellPriceUsdt
            // 
            this.lblSellPriceUsdt.AutoSize = true;
            this.lblSellPriceUsdt.Location = new System.Drawing.Point(166, 40);
            this.lblSellPriceUsdt.Name = "lblSellPriceUsdt";
            this.lblSellPriceUsdt.Size = new System.Drawing.Size(40, 15);
            this.lblSellPriceUsdt.TabIndex = 3;
            this.lblSellPriceUsdt.Text = "USDT";
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Location = new System.Drawing.Point(69, 37);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(75, 21);
            this.txtSellPrice.TabIndex = 2;
            // 
            // lblSellPrice
            // 
            this.lblSellPrice.AutoSize = true;
            this.lblSellPrice.Location = new System.Drawing.Point(14, 40);
            this.lblSellPrice.Name = "lblSellPrice";
            this.lblSellPrice.Size = new System.Drawing.Size(35, 15);
            this.lblSellPrice.TabIndex = 1;
            this.lblSellPrice.Text = "Price";
            // 
            // grbBuy
            // 
            this.grbBuy.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.grbBuy.Controls.Add(this.txtBuyTotalUsdt);
            this.grbBuy.Controls.Add(this.lblTotalUsdt);
            this.grbBuy.Controls.Add(this.btnBuy);
            this.grbBuy.Controls.Add(this.txtBuyTotal);
            this.grbBuy.Controls.Add(this.lblBuyTotal);
            this.grbBuy.Controls.Add(this.btnBuy100);
            this.grbBuy.Controls.Add(this.btnBuy75);
            this.grbBuy.Controls.Add(this.btnBuy50);
            this.grbBuy.Controls.Add(this.btnBuy25);
            this.grbBuy.Controls.Add(this.txtBuyAmountUsdt);
            this.grbBuy.Controls.Add(this.lblBuyAmountUsdt);
            this.grbBuy.Controls.Add(this.txtBuyAmount);
            this.grbBuy.Controls.Add(this.lblBuyAmount);
            this.grbBuy.Controls.Add(this.txtBuyUsdt);
            this.grbBuy.Controls.Add(this.lblBuyPriceUsdt);
            this.grbBuy.Controls.Add(this.txtBuyPrice);
            this.grbBuy.Controls.Add(this.lblBuyPrice);
            this.grbBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBuy.Location = new System.Drawing.Point(16, 45);
            this.grbBuy.Name = "grbBuy";
            this.grbBuy.Size = new System.Drawing.Size(313, 215);
            this.grbBuy.TabIndex = 1;
            this.grbBuy.TabStop = false;
            this.grbBuy.Text = "Buy";
            // 
            // txtBuyTotalUsdt
            // 
            this.txtBuyTotalUsdt.Location = new System.Drawing.Point(213, 147);
            this.txtBuyTotalUsdt.Name = "txtBuyTotalUsdt";
            this.txtBuyTotalUsdt.Size = new System.Drawing.Size(75, 21);
            this.txtBuyTotalUsdt.TabIndex = 16;
            // 
            // lblTotalUsdt
            // 
            this.lblTotalUsdt.AutoSize = true;
            this.lblTotalUsdt.Location = new System.Drawing.Point(168, 150);
            this.lblTotalUsdt.Name = "lblTotalUsdt";
            this.lblTotalUsdt.Size = new System.Drawing.Size(40, 15);
            this.lblTotalUsdt.TabIndex = 15;
            this.lblTotalUsdt.Text = "USDT";
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(98, 181);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(156, 23);
            this.btnBuy.TabIndex = 14;
            this.btnBuy.Text = "BUY";
            this.btnBuy.UseVisualStyleBackColor = true;
            // 
            // txtBuyTotal
            // 
            this.txtBuyTotal.Location = new System.Drawing.Point(70, 147);
            this.txtBuyTotal.Name = "txtBuyTotal";
            this.txtBuyTotal.Size = new System.Drawing.Size(75, 21);
            this.txtBuyTotal.TabIndex = 13;
            // 
            // lblBuyTotal
            // 
            this.lblBuyTotal.AutoSize = true;
            this.lblBuyTotal.Location = new System.Drawing.Point(15, 150);
            this.lblBuyTotal.Name = "lblBuyTotal";
            this.lblBuyTotal.Size = new System.Drawing.Size(34, 15);
            this.lblBuyTotal.TabIndex = 12;
            this.lblBuyTotal.Text = "Total";
            // 
            // btnBuy100
            // 
            this.btnBuy100.Location = new System.Drawing.Point(238, 111);
            this.btnBuy100.Name = "btnBuy100";
            this.btnBuy100.Size = new System.Drawing.Size(50, 23);
            this.btnBuy100.TabIndex = 11;
            this.btnBuy100.Text = "100%";
            this.btnBuy100.UseVisualStyleBackColor = true;
            // 
            // btnBuy75
            // 
            this.btnBuy75.Location = new System.Drawing.Point(182, 111);
            this.btnBuy75.Name = "btnBuy75";
            this.btnBuy75.Size = new System.Drawing.Size(50, 23);
            this.btnBuy75.TabIndex = 10;
            this.btnBuy75.Text = "75%";
            this.btnBuy75.UseVisualStyleBackColor = true;
            // 
            // btnBuy50
            // 
            this.btnBuy50.Location = new System.Drawing.Point(126, 111);
            this.btnBuy50.Name = "btnBuy50";
            this.btnBuy50.Size = new System.Drawing.Size(50, 23);
            this.btnBuy50.TabIndex = 9;
            this.btnBuy50.Text = "50%";
            this.btnBuy50.UseVisualStyleBackColor = true;
            // 
            // btnBuy25
            // 
            this.btnBuy25.Location = new System.Drawing.Point(70, 111);
            this.btnBuy25.Name = "btnBuy25";
            this.btnBuy25.Size = new System.Drawing.Size(50, 23);
            this.btnBuy25.TabIndex = 8;
            this.btnBuy25.Text = "25%";
            this.btnBuy25.UseVisualStyleBackColor = true;
            // 
            // txtBuyAmountUsdt
            // 
            this.txtBuyAmountUsdt.Location = new System.Drawing.Point(213, 75);
            this.txtBuyAmountUsdt.Name = "txtBuyAmountUsdt";
            this.txtBuyAmountUsdt.Size = new System.Drawing.Size(75, 21);
            this.txtBuyAmountUsdt.TabIndex = 7;
            // 
            // lblBuyAmountUsdt
            // 
            this.lblBuyAmountUsdt.AutoSize = true;
            this.lblBuyAmountUsdt.Location = new System.Drawing.Point(168, 78);
            this.lblBuyAmountUsdt.Name = "lblBuyAmountUsdt";
            this.lblBuyAmountUsdt.Size = new System.Drawing.Size(40, 15);
            this.lblBuyAmountUsdt.TabIndex = 6;
            this.lblBuyAmountUsdt.Text = "USDT";
            // 
            // txtBuyAmount
            // 
            this.txtBuyAmount.Location = new System.Drawing.Point(70, 75);
            this.txtBuyAmount.Name = "txtBuyAmount";
            this.txtBuyAmount.Size = new System.Drawing.Size(75, 21);
            this.txtBuyAmount.TabIndex = 5;
            // 
            // lblBuyAmount
            // 
            this.lblBuyAmount.AutoSize = true;
            this.lblBuyAmount.Location = new System.Drawing.Point(15, 78);
            this.lblBuyAmount.Name = "lblBuyAmount";
            this.lblBuyAmount.Size = new System.Drawing.Size(49, 15);
            this.lblBuyAmount.TabIndex = 4;
            this.lblBuyAmount.Text = "Amount";
            // 
            // txtBuyUsdt
            // 
            this.txtBuyUsdt.Location = new System.Drawing.Point(213, 37);
            this.txtBuyUsdt.Name = "txtBuyUsdt";
            this.txtBuyUsdt.Size = new System.Drawing.Size(75, 21);
            this.txtBuyUsdt.TabIndex = 3;
            // 
            // lblBuyPriceUsdt
            // 
            this.lblBuyPriceUsdt.AutoSize = true;
            this.lblBuyPriceUsdt.Location = new System.Drawing.Point(168, 40);
            this.lblBuyPriceUsdt.Name = "lblBuyPriceUsdt";
            this.lblBuyPriceUsdt.Size = new System.Drawing.Size(40, 15);
            this.lblBuyPriceUsdt.TabIndex = 2;
            this.lblBuyPriceUsdt.Text = "USDT";
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.Location = new System.Drawing.Point(70, 37);
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.Size = new System.Drawing.Size(75, 21);
            this.txtBuyPrice.TabIndex = 1;
            // 
            // lblBuyPrice
            // 
            this.lblBuyPrice.AutoSize = true;
            this.lblBuyPrice.Location = new System.Drawing.Point(15, 40);
            this.lblBuyPrice.Name = "lblBuyPrice";
            this.lblBuyPrice.Size = new System.Drawing.Size(35, 15);
            this.lblBuyPrice.TabIndex = 0;
            this.lblBuyPrice.Text = "Price";
            // 
            // cbbCoins
            // 
            this.cbbCoins.FormattingEnabled = true;
            this.cbbCoins.Location = new System.Drawing.Point(16, 16);
            this.cbbCoins.Name = "cbbCoins";
            this.cbbCoins.Size = new System.Drawing.Size(151, 21);
            this.cbbCoins.TabIndex = 0;
            // 
            // tabBtc
            // 
            this.tabBtc.Location = new System.Drawing.Point(4, 22);
            this.tabBtc.Name = "tabBtc";
            this.tabBtc.Padding = new System.Windows.Forms.Padding(3);
            this.tabBtc.Size = new System.Drawing.Size(830, 246);
            this.tabBtc.TabIndex = 1;
            this.tabBtc.Text = "BTC";
            this.tabBtc.UseVisualStyleBackColor = true;
            // 
            // tabEth
            // 
            this.tabEth.Location = new System.Drawing.Point(4, 22);
            this.tabEth.Name = "tabEth";
            this.tabEth.Padding = new System.Windows.Forms.Padding(3);
            this.tabEth.Size = new System.Drawing.Size(830, 246);
            this.tabEth.TabIndex = 2;
            this.tabEth.Text = "ETH";
            this.tabEth.UseVisualStyleBackColor = true;
            // 
            // tabXmr
            // 
            this.tabXmr.Location = new System.Drawing.Point(4, 22);
            this.tabXmr.Name = "tabXmr";
            this.tabXmr.Padding = new System.Windows.Forms.Padding(3);
            this.tabXmr.Size = new System.Drawing.Size(830, 246);
            this.tabXmr.TabIndex = 3;
            this.tabXmr.Text = "XMR";
            this.tabXmr.UseVisualStyleBackColor = true;
            // 
            // txtBot
            // 
            this.txtBot.Location = new System.Drawing.Point(684, 204);
            this.txtBot.Multiline = true;
            this.txtBot.Name = "txtBot";
            this.txtBot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBot.Size = new System.Drawing.Size(471, 123);
            this.txtBot.TabIndex = 1;
            // 
            // tabBinance
            // 
            this.tabBinance.Location = new System.Drawing.Point(23, 4);
            this.tabBinance.Name = "tabBinance";
            this.tabBinance.Padding = new System.Windows.Forms.Padding(3);
            this.tabBinance.Size = new System.Drawing.Size(1170, 285);
            this.tabBinance.TabIndex = 1;
            this.tabBinance.Text = "Binance";
            this.tabBinance.UseVisualStyleBackColor = true;
            // 
            // txtTicker
            // 
            this.txtTicker.Location = new System.Drawing.Point(35, 458);
            this.txtTicker.Multiline = true;
            this.txtTicker.Name = "txtTicker";
            this.txtTicker.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTicker.Size = new System.Drawing.Size(1174, 72);
            this.txtTicker.TabIndex = 2;
            // 
            // dgvTrades
            // 
            this.dgvTrades.AutoGenerateColumns = false;
            this.dgvTrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.currencyPairDataGridViewTextBoxColumn,
            this.amountToTradeDataGridViewTextBoxColumn,
            this.pricePaidDataGridViewTextBoxColumn,
            this.priceLast,
            this.highestPriceDataGridViewTextBoxColumn,
            this.profitDataGridViewTextBoxColumn,
            this.higuestProfitDataGridViewTextBoxColumn,
            this.highestProfitDiffDataGridViewTextBoxColumn,
            this.lossToleranceDataGridViewTextBoxColumn,
            this.baseCurrencyTotalDataGridViewTextBoxColumn,
            this.usdTotalValueDataGridViewTextBoxColumn,
            this.time});
            this.dgvTrades.DataSource = this.tickerModelBindingSource;
            this.dgvTrades.Location = new System.Drawing.Point(35, 359);
            this.dgvTrades.Name = "dgvTrades";
            this.dgvTrades.Size = new System.Drawing.Size(1174, 93);
            this.dgvTrades.TabIndex = 3;
            // 
            // currencyPairDataGridViewTextBoxColumn
            // 
            this.currencyPairDataGridViewTextBoxColumn.DataPropertyName = "currencyPair";
            this.currencyPairDataGridViewTextBoxColumn.HeaderText = "currencyPair";
            this.currencyPairDataGridViewTextBoxColumn.Name = "currencyPairDataGridViewTextBoxColumn";
            this.currencyPairDataGridViewTextBoxColumn.Width = 75;
            // 
            // amountToTradeDataGridViewTextBoxColumn
            // 
            this.amountToTradeDataGridViewTextBoxColumn.DataPropertyName = "amountToTrade";
            this.amountToTradeDataGridViewTextBoxColumn.HeaderText = "amountToTrade";
            this.amountToTradeDataGridViewTextBoxColumn.Name = "amountToTradeDataGridViewTextBoxColumn";
            this.amountToTradeDataGridViewTextBoxColumn.Width = 50;
            // 
            // pricePaidDataGridViewTextBoxColumn
            // 
            this.pricePaidDataGridViewTextBoxColumn.DataPropertyName = "pricePaid";
            this.pricePaidDataGridViewTextBoxColumn.HeaderText = "pricePaid";
            this.pricePaidDataGridViewTextBoxColumn.Name = "pricePaidDataGridViewTextBoxColumn";
            // 
            // priceLast
            // 
            this.priceLast.DataPropertyName = "priceLast";
            this.priceLast.HeaderText = "priceLast";
            this.priceLast.Name = "priceLast";
            // 
            // highestPriceDataGridViewTextBoxColumn
            // 
            this.highestPriceDataGridViewTextBoxColumn.DataPropertyName = "highestPrice";
            this.highestPriceDataGridViewTextBoxColumn.HeaderText = "highestPrice";
            this.highestPriceDataGridViewTextBoxColumn.Name = "highestPriceDataGridViewTextBoxColumn";
            // 
            // profitDataGridViewTextBoxColumn
            // 
            this.profitDataGridViewTextBoxColumn.DataPropertyName = "profit";
            this.profitDataGridViewTextBoxColumn.HeaderText = "profit";
            this.profitDataGridViewTextBoxColumn.Name = "profitDataGridViewTextBoxColumn";
            this.profitDataGridViewTextBoxColumn.Width = 75;
            // 
            // higuestProfitDataGridViewTextBoxColumn
            // 
            this.higuestProfitDataGridViewTextBoxColumn.DataPropertyName = "higuestProfit";
            this.higuestProfitDataGridViewTextBoxColumn.HeaderText = "higuestProfit";
            this.higuestProfitDataGridViewTextBoxColumn.Name = "higuestProfitDataGridViewTextBoxColumn";
            this.higuestProfitDataGridViewTextBoxColumn.Width = 75;
            // 
            // highestProfitDiffDataGridViewTextBoxColumn
            // 
            this.highestProfitDiffDataGridViewTextBoxColumn.DataPropertyName = "highestProfitDiff";
            this.highestProfitDiffDataGridViewTextBoxColumn.HeaderText = "highestProfitDiff";
            this.highestProfitDiffDataGridViewTextBoxColumn.Name = "highestProfitDiffDataGridViewTextBoxColumn";
            this.highestProfitDiffDataGridViewTextBoxColumn.Width = 75;
            // 
            // lossToleranceDataGridViewTextBoxColumn
            // 
            this.lossToleranceDataGridViewTextBoxColumn.DataPropertyName = "lossTolerance";
            this.lossToleranceDataGridViewTextBoxColumn.HeaderText = "lossTolerance";
            this.lossToleranceDataGridViewTextBoxColumn.Name = "lossToleranceDataGridViewTextBoxColumn";
            this.lossToleranceDataGridViewTextBoxColumn.Width = 75;
            // 
            // baseCurrencyTotalDataGridViewTextBoxColumn
            // 
            this.baseCurrencyTotalDataGridViewTextBoxColumn.DataPropertyName = "baseCurrencyTotal";
            this.baseCurrencyTotalDataGridViewTextBoxColumn.HeaderText = "baseCurrencyTotal";
            this.baseCurrencyTotalDataGridViewTextBoxColumn.Name = "baseCurrencyTotalDataGridViewTextBoxColumn";
            // 
            // usdTotalValueDataGridViewTextBoxColumn
            // 
            this.usdTotalValueDataGridViewTextBoxColumn.DataPropertyName = "usdTotalValue";
            this.usdTotalValueDataGridViewTextBoxColumn.HeaderText = "usdTotalValue";
            this.usdTotalValueDataGridViewTextBoxColumn.Name = "usdTotalValueDataGridViewTextBoxColumn";
            // 
            // time
            // 
            this.time.DataPropertyName = "time";
            this.time.HeaderText = "time";
            this.time.Name = "time";
            this.time.Width = 125;
            // 
            // tickerModelBindingSource
            // 
            this.tickerModelBindingSource.DataSource = typeof(Jojatekok.PoloniexAPI.TickerModel);
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
            this.dgvBalances.Location = new System.Drawing.Point(684, 28);
            this.dgvBalances.Name = "dgvBalances";
            this.dgvBalances.Size = new System.Drawing.Size(470, 170);
            this.dgvBalances.TabIndex = 2;
            // 
            // balanceModelBindingSource
            // 
            this.balanceModelBindingSource.DataSource = typeof(Jojatekok.PoloniexAPI.BalanceModel);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 576);
            this.Controls.Add(this.dgvTrades);
            this.Controls.Add(this.txtTicker);
            this.Controls.Add(this.tabsExchanges);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabsExchanges.ResumeLayout(false);
            this.tabPoloniex.ResumeLayout(false);
            this.tabPoloniex.PerformLayout();
            this.tabsMarkets.ResumeLayout(false);
            this.tabUsdt.ResumeLayout(false);
            this.grbSell.ResumeLayout(false);
            this.grbSell.PerformLayout();
            this.grbBuy.ResumeLayout(false);
            this.grbBuy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickerModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txtBot;
        private System.Windows.Forms.ComboBox cbbCoins;
        private System.Windows.Forms.GroupBox grbSell;
        private System.Windows.Forms.GroupBox grbBuy;
        private System.Windows.Forms.Button btnStartBot;
        private System.Windows.Forms.TextBox txtTicker;
        private System.Windows.Forms.Label lblBuyPrice;
        private System.Windows.Forms.TextBox txtSellUsdt;
        private System.Windows.Forms.Label lblSellPriceUsdt;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.Label lblSellPrice;
        private System.Windows.Forms.TextBox txtBuyUsdt;
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
        private System.Windows.Forms.DataGridView dgvTrades;
        private System.Windows.Forms.BindingSource tickerModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyPairDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountToTradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn highestPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn profitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn higuestProfitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn highestProfitDiffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lossToleranceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseCurrencyTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usdTotalValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridView dgvBalances;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteAvailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoteOnOrdersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSDTValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource balanceModelBindingSource;
    }
}

