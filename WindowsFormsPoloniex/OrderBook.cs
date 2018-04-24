using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jojatekok.PoloniexAPI;

namespace WindowsFormsPoloniex
{
    public partial class OrderBook : UserControl
    {
        public OrderBook()
        {
            InitializeComponent();
        }

        private void OrderBook_Load(object sender, EventArgs e)
        {

            OrderBookRefresh();
        }

        public void OrderBookRefresh()
        {
            var trading = new TradingController();
            gridOrdersBook.DataSource = trading.GetAllOpenOrders();


            //gridOrdersBook.Columns.Add(new DataGridViewColumn() { Name = "test"});

            
        }
    }
}
