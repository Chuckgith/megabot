namespace WindowsFormsPoloniex
{
    partial class OrderBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridOrdersBook = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrdersBook)).BeginInit();
            this.SuspendLayout();
            // 
            // gridOrdersBook
            // 
            this.gridOrdersBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOrdersBook.Location = new System.Drawing.Point(24, 12);
            this.gridOrdersBook.Name = "gridOrdersBook";
            this.gridOrdersBook.Size = new System.Drawing.Size(922, 190);
            this.gridOrdersBook.TabIndex = 0;
            // 
            // OrderBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridOrdersBook);
            this.Name = "OrderBook";
            this.Size = new System.Drawing.Size(985, 227);
            this.Load += new System.EventHandler(this.OrderBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrdersBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridOrdersBook;
    }
}
