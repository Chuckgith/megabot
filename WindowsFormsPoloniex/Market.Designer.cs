namespace WindowsFormsPoloniex
{
    partial class Market
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
            this.gridMarkets = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridMarkets)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMarkets
            // 
            this.gridMarkets.AllowUserToAddRows = false;
            this.gridMarkets.AllowUserToDeleteRows = false;
            this.gridMarkets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMarkets.Location = new System.Drawing.Point(189, 102);
            this.gridMarkets.Name = "gridMarkets";
            this.gridMarkets.ReadOnly = true;
            this.gridMarkets.Size = new System.Drawing.Size(661, 362);
            this.gridMarkets.TabIndex = 28;
            // 
            // Market
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 567);
            this.Controls.Add(this.gridMarkets);
            this.Name = "Market";
            this.Text = "Market";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Trading_FormClosing);
            this.Shown += new System.EventHandler(this.Trading_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridMarkets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMarkets;
    }
}