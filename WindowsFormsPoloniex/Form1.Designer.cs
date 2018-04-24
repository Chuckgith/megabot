namespace WindowsFormsPoloniex
{
    partial class Trading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAcheter = new System.Windows.Forms.Button();
            this.btnVendre = new System.Windows.Forms.Button();
            this.cbCurrencyAchat = new System.Windows.Forms.ComboBox();
            this.txtUSDTAchat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmountAchat = new System.Windows.Forms.TextBox();
            this.btnAchatAuto = new System.Windows.Forms.Button();
            this.txtPrixAchat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.checkBoxAutoRunCoinBot = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLivePrice = new System.Windows.Forms.Label();
            this.txtPrixVente = new System.Windows.Forms.TextBox();
            this.txtUSDTVente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAmountVente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCurrencyVente = new System.Windows.Forms.ComboBox();
            this.btnVendreAuto = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbCurrencyOrder = new System.Windows.Forms.ComboBox();
            this.listMarket = new System.Windows.Forms.ListBox();
            this.orderBook1 = new WindowsFormsPoloniex.OrderBook();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAcheter
            // 
            this.btnAcheter.Location = new System.Drawing.Point(206, 99);
            this.btnAcheter.Name = "btnAcheter";
            this.btnAcheter.Size = new System.Drawing.Size(75, 23);
            this.btnAcheter.TabIndex = 0;
            this.btnAcheter.Text = "Acheter";
            this.btnAcheter.UseVisualStyleBackColor = true;
            this.btnAcheter.Click += new System.EventHandler(this.btnAcheter_Click);
            // 
            // btnVendre
            // 
            this.btnVendre.Location = new System.Drawing.Point(210, 99);
            this.btnVendre.Name = "btnVendre";
            this.btnVendre.Size = new System.Drawing.Size(75, 23);
            this.btnVendre.TabIndex = 1;
            this.btnVendre.Text = "Vendre";
            this.btnVendre.UseVisualStyleBackColor = true;
            this.btnVendre.Click += new System.EventHandler(this.btnVendre_Click);
            // 
            // cbCurrencyAchat
            // 
            this.cbCurrencyAchat.FormattingEnabled = true;
            this.cbCurrencyAchat.Location = new System.Drawing.Point(98, 150);
            this.cbCurrencyAchat.Name = "cbCurrencyAchat";
            this.cbCurrencyAchat.Size = new System.Drawing.Size(128, 21);
            this.cbCurrencyAchat.TabIndex = 2;
            // 
            // txtUSDTAchat
            // 
            this.txtUSDTAchat.Location = new System.Drawing.Point(61, 38);
            this.txtUSDTAchat.Name = "txtUSDTAchat";
            this.txtUSDTAchat.Size = new System.Drawing.Size(128, 20);
            this.txtUSDTAchat.TabIndex = 5;
            this.txtUSDTAchat.TextChanged += new System.EventHandler(this.txtUSDT_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "USDT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Currency";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Amount";
            // 
            // txtAmountAchat
            // 
            this.txtAmountAchat.Location = new System.Drawing.Point(61, 64);
            this.txtAmountAchat.Name = "txtAmountAchat";
            this.txtAmountAchat.Size = new System.Drawing.Size(128, 20);
            this.txtAmountAchat.TabIndex = 9;
            // 
            // btnAchatAuto
            // 
            this.btnAchatAuto.Location = new System.Drawing.Point(232, 150);
            this.btnAchatAuto.Name = "btnAchatAuto";
            this.btnAchatAuto.Size = new System.Drawing.Size(103, 23);
            this.btnAchatAuto.TabIndex = 12;
            this.btnAchatAuto.Text = "Acheter Auto";
            this.btnAchatAuto.UseVisualStyleBackColor = true;
            this.btnAchatAuto.Click += new System.EventHandler(this.btnAchatAuto_Click);
            // 
            // txtPrixAchat
            // 
            this.txtPrixAchat.Location = new System.Drawing.Point(61, 11);
            this.txtPrixAchat.Name = "txtPrixAchat";
            this.txtPrixAchat.Size = new System.Drawing.Size(128, 20);
            this.txtPrixAchat.TabIndex = 3;
            this.txtPrixAchat.TextChanged += new System.EventHandler(this.txtPrix_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prix";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(654, 1);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marketToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // marketToolStripMenuItem
            // 
            this.marketToolStripMenuItem.Name = "marketToolStripMenuItem";
            this.marketToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.marketToolStripMenuItem.Text = "Market";
            this.marketToolStripMenuItem.Click += new System.EventHandler(this.marketToolStripMenuItem_Click);
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.Location = new System.Drawing.Point(232, 356);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(75, 23);
            this.btnClearOrder.TabIndex = 26;
            this.btnClearOrder.Text = "Clear Order";
            this.btnClearOrder.UseVisualStyleBackColor = true;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // checkBoxAutoRunCoinBot
            // 
            this.checkBoxAutoRunCoinBot.AutoSize = true;
            this.checkBoxAutoRunCoinBot.Checked = true;
            this.checkBoxAutoRunCoinBot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoRunCoinBot.Location = new System.Drawing.Point(12, 105);
            this.checkBoxAutoRunCoinBot.Name = "checkBoxAutoRunCoinBot";
            this.checkBoxAutoRunCoinBot.Size = new System.Drawing.Size(173, 17);
            this.checkBoxAutoRunCoinBot.TabIndex = 27;
            this.checkBoxAutoRunCoinBot.Text = "Lancer la console après l\'achat";
            this.checkBoxAutoRunCoinBot.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnAcheter);
            this.panel1.Controls.Add(this.txtPrixAchat);
            this.panel1.Controls.Add(this.txtUSDTAchat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtAmountAchat);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.checkBoxAutoRunCoinBot);
            this.panel1.Location = new System.Drawing.Point(37, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 137);
            this.panel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.lblLivePrice);
            this.panel2.Controls.Add(this.txtPrixVente);
            this.panel2.Controls.Add(this.txtUSDTVente);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtAmountVente);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnVendre);
            this.panel2.Location = new System.Drawing.Point(393, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 137);
            this.panel2.TabIndex = 32;
            // 
            // lblLivePrice
            // 
            this.lblLivePrice.AutoSize = true;
            this.lblLivePrice.Location = new System.Drawing.Point(195, 41);
            this.lblLivePrice.Name = "lblLivePrice";
            this.lblLivePrice.Size = new System.Drawing.Size(0, 13);
            this.lblLivePrice.TabIndex = 11;
            // 
            // txtPrixVente
            // 
            this.txtPrixVente.Location = new System.Drawing.Point(64, 7);
            this.txtPrixVente.Name = "txtPrixVente";
            this.txtPrixVente.Size = new System.Drawing.Size(128, 20);
            this.txtPrixVente.TabIndex = 3;
            // 
            // txtUSDTVente
            // 
            this.txtUSDTVente.Location = new System.Drawing.Point(64, 38);
            this.txtUSDTVente.Name = "txtUSDTVente";
            this.txtUSDTVente.Size = new System.Drawing.Size(128, 20);
            this.txtUSDTVente.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "USDT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Prix";
            // 
            // txtAmountVente
            // 
            this.txtAmountVente.Location = new System.Drawing.Point(64, 68);
            this.txtAmountVente.Name = "txtAmountVente";
            this.txtAmountVente.Size = new System.Drawing.Size(128, 20);
            this.txtAmountVente.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(402, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Currency";
            // 
            // cbCurrencyVente
            // 
            this.cbCurrencyVente.FormattingEnabled = true;
            this.cbCurrencyVente.Location = new System.Drawing.Point(457, 150);
            this.cbCurrencyVente.Name = "cbCurrencyVente";
            this.cbCurrencyVente.Size = new System.Drawing.Size(128, 21);
            this.cbCurrencyVente.TabIndex = 29;
            this.cbCurrencyVente.SelectedIndexChanged += new System.EventHandler(this.cbCurrencyVente_SelectedIndexChanged);
            // 
            // btnVendreAuto
            // 
            this.btnVendreAuto.Location = new System.Drawing.Point(591, 150);
            this.btnVendreAuto.Name = "btnVendreAuto";
            this.btnVendreAuto.Size = new System.Drawing.Size(103, 23);
            this.btnVendreAuto.TabIndex = 11;
            this.btnVendreAuto.Text = "Vendre Auto";
            this.btnVendreAuto.UseVisualStyleBackColor = true;
            this.btnVendreAuto.Click += new System.EventHandler(this.btnVendreAuto_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(41, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 25);
            this.label10.TabIndex = 33;
            this.label10.Text = "Achat";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 361);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Currency";
            // 
            // cbCurrencyOrder
            // 
            this.cbCurrencyOrder.FormattingEnabled = true;
            this.cbCurrencyOrder.Location = new System.Drawing.Point(98, 358);
            this.cbCurrencyOrder.Name = "cbCurrencyOrder";
            this.cbCurrencyOrder.Size = new System.Drawing.Size(128, 21);
            this.cbCurrencyOrder.TabIndex = 35;
            // 
            // listMarket
            // 
            this.listMarket.FormattingEnabled = true;
            this.listMarket.Location = new System.Drawing.Point(37, 38);
            this.listMarket.Name = "listMarket";
            this.listMarket.Size = new System.Drawing.Size(129, 56);
            this.listMarket.TabIndex = 37;
            this.listMarket.SelectedIndexChanged += new System.EventHandler(this.listMarket_SelectedIndexChanged);
            // 
            // orderBook1
            // 
            this.orderBook1.Location = new System.Drawing.Point(12, 326);
            this.orderBook1.Name = "orderBook1";
            this.orderBook1.Size = new System.Drawing.Size(775, 227);
            this.orderBook1.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(400, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "Vente";
            // 
            // Trading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 634);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listMarket);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbCurrencyOrder);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbCurrencyVente);
            this.Controls.Add(this.btnClearOrder);
            this.Controls.Add(this.orderBook1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAchatAuto);
            this.Controls.Add(this.btnVendreAuto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCurrencyAchat);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Trading";
            this.Text = "Trading";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAcheter;
        private System.Windows.Forms.Button btnVendre;
        private System.Windows.Forms.ComboBox cbCurrencyAchat;
        private System.Windows.Forms.TextBox txtUSDTAchat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmountAchat;
        private System.Windows.Forms.Button btnAchatAuto;
        private System.Windows.Forms.TextBox txtPrixAchat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marketToolStripMenuItem;
        private OrderBook orderBook1;
        private System.Windows.Forms.Button btnClearOrder;
        private System.Windows.Forms.CheckBox checkBoxAutoRunCoinBot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPrixVente;
        private System.Windows.Forms.TextBox txtUSDTVente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAmountVente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbCurrencyVente;
        private System.Windows.Forms.Button btnVendreAuto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbCurrencyOrder;
        private System.Windows.Forms.ListBox listMarket;
        private System.Windows.Forms.Label lblLivePrice;
        private System.Windows.Forms.Label label5;
    }
}

