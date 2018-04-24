using Jojatekok.PoloniexAPI;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using System.Threading;

namespace WindowsFormsPoloniex
{
    public partial class Trading : Form
    {
        static Business BIZ = new Business();

        private void FeedListMarket()
        {
            listMarket.Items.Add("USDT");
            listMarket.Items.Add("BTC");
            listMarket.Items.Add("ETH");
            listMarket.Items.Add("XMR");            
        }

        public void FeedComboBoxCurrency(string baseCurrency)
        {
            var mc = new MarketController();
            IList<CurrencyPair> cps = (mc.GetMarket(baseCurrency).ToArray());

            cbCurrencyAchat.Items.Clear();
            cbCurrencyVente.Items.Clear();
            cbCurrencyAchat.Items.AddRange(cps.ToArray());
            cbCurrencyVente.Items.AddRange(cps.ToArray());
        }

        System.Threading.Thread t;
        public Trading()
        {
            InitializeComponent();

            FeedListMarket();

            listMarket.SetSelected(0, true);

            //t = new System.Threading.Thread(DoThisAllTheTime);
            //t.Start();

            //StartTrading(listMarket.SelectedItem.ToString());
        }

        public void DoThisAllTheTime()
        {
            
            
        }

        private void StartTrading(string baseCurrency)
        {
            FeedComboBoxCurrency(baseCurrency);

            try
            {
                double usdt = (from x in BIZ.GetBalances() where x.Type == baseCurrency select x.QuoteAvailable).SingleOrDefault();
                txtUSDTAchat.Text = string.Format("{0:0.00000000}", usdt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0}\nPenser à regarder si mon IP est dans les Trusted IPs de Poloniex", ex.Message));
            }
        }

        private void btnVendre_Click(object sender, EventArgs e)
        {
         //ToDo
        }
 
        private void btnAcheter_Click(object sender, EventArgs e)
        {
            if (txtPrixAchat.Text != string.Empty && txtUSDTAchat.Text != string.Empty)
            {
                var tradingController = new TradingController();

                double price = Convert.ToDouble(txtPrixAchat.Text);
                double amount = Convert.ToDouble(txtAmountAchat.Text);
                double usdt = Math.Floor(Convert.ToDouble(txtUSDTAchat.Text));
                var currencyPair = cbCurrencyAchat.SelectedItem.ToString();
                var id = tradingController.PostOrder(new CurrencyPair(currencyPair), OrderType.Buy, price, amount);

                Reinitialisation();
            }
            else
            {
                MessageBox.Show("Make sure the price or USDT value is not empty ");
            }
        }

        private void btnVendreAuto_Click(object sender, EventArgs e)
        {
            try
            {
                var currencyPair = cbCurrencyVente.SelectedItem.ToString();
                BIZ.PostBestSellOrder(new CurrencyPair(currencyPair), double.Parse(txtUSDTVente.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAchatAuto_Click(object sender, EventArgs e)
        {
            try
            {
                var currencyPair = new CurrencyPair(cbCurrencyAchat.SelectedItem.ToString());
                ulong idOrder = 0;
                double amountQuote = 0;

                amountQuote = double.Parse(txtUSDTAchat.Text);
                idOrder = BIZ.PostBestBuyOrder(currencyPair, amountQuote).IdOrder;

                if (idOrder != 0 && checkBoxAutoRunCoinBot.Checked)
                {
                    //string[] args = new string[] { currencyPair.BaseCurrency, currencyPair.QuoteCurrency, amountQuote, idOrder.ToString() };
                    //CoinBot_Cv2.Program  test = new CoinBot_Cv2.Program();
                    //CoinBot_Cv2.Program.Main(args);

                    Debug.WriteLine(string.Format("Call CoinBot... {0}, {1}, {2}, {3}, {4}", currencyPair.BaseCurrency, currencyPair.QuoteCurrency, amountQuote, 0, idOrder));

                    Process.Start("D:\\code\\Polov3\\CoinBot_Cv2\\bin\\Debug\\CoinBot_Cv2.exe",
                    string.Format(" {0} {1} {2} {3} {4}", currencyPair.BaseCurrency, currencyPair.QuoteCurrency, amountQuote, 0, idOrder));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPrix_TextChanged(object sender, EventArgs e)
        {
            double prix = 0;
            double usdt = 0;

            if (double.TryParse(txtUSDTAchat.Text.Replace(".", ","), out double parseUsdt))
            {
                usdt = parseUsdt;

                if (usdt != 0)
                {
                    if (double.TryParse(txtPrixAchat.Text.Replace(".", ","), out double parsePrix))
                        prix = parsePrix;

                    SetAmount(prix, usdt);
                }
            }
        }

        private void txtUSDT_TextChanged(object sender, EventArgs e)
        {
            double prix = 0;
            double usdt = 0;

            if (double.TryParse(txtPrixAchat.Text.Replace(".", ","), out double parsePrix))
            {
                prix = parsePrix;

                if (prix != 0)
                {
                    if (double.TryParse(txtUSDTAchat.Text.Replace(".", ","), out double parseUsdt))
                        usdt = parseUsdt;

                    SetAmount(prix, usdt);
                }
            }
        }

        private void SetAmount(double prix, double usdt)
        {
            if (prix != 0 && usdt != 0)
                txtAmountAchat.Text = Math.Round(usdt/prix, 8).ToString();
        }

        //va tout rafraichir la form
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //txtLogTrade.Clear();
        }

        public void Reinitialisation()
        {
            txtUSDTAchat.Text = (from x in BIZ.GetBalances() where x.Type == listMarket.SelectedItem.ToString() select x.QuoteAvailable.ToString()).SingleOrDefault();

            orderBook1.OrderBookRefresh();
        }

        private void marketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var market = new Market();
            market.Show();
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            TradingController tc = new TradingController();
            var orders = tc.GetAllOpenOrders();
            var currencyPair = new CurrencyPair(listMarket.SelectedItem.ToString(), cbCurrencyAchat.SelectedItem.ToString());
            foreach (var item in orders)
            {
                if (item.CurrencyPair == currencyPair)
                {
                    tc.DeleteOrder(currencyPair, item.IdOrder);

                    Reinitialisation();
                }
            }
        }

        private void btnStopAutoTrade_Click(object sender, EventArgs e)
        {

        }

        private void cbCurrencyVente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var currencyPair = new CurrencyPair(cbCurrencyVente.SelectedItem.ToString());

                double usdt = (from x in BIZ.GetBalances() where x.Type == currencyPair.QuoteCurrency select x.USDT_Value).SingleOrDefault();
                txtUSDTVente.Text = string.Format("{0:0.00000000}", usdt);

                //DoWorkAsyncInfiniteLoop(currencyPair);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task DoWorkAsyncInfiniteLoop(CurrencyPair currencyPair)
        {
            while (true)
            {
                lblLivePrice.Text = string.Format("{0:0.00000000}", (from x in BIZ.GetBalances() where x.Type == currencyPair.QuoteCurrency select x.USDT_Value).SingleOrDefault());
                await Task.Delay(5000);
            }
        }

        //while (true)
        //    {
        //        if (cbCurrencyVente != null && cbCurrencyVente.SelectedItem != null)
        //        {
        //            var currencyPair = new CurrencyPair(cbCurrencyVente.SelectedItem.ToString());

        //double usdt = (from x in BIZ.GetBalances() where x.Type == currencyPair.QuoteCurrency select x.USDT_Value).SingleOrDefault();

        ////you need to use Invoke because the new thread can't access the UI elements directly
        //MethodInvoker mi = delegate () { lblLivePrice.Text = string.Format("{0:0.00000000}", usdt); };
        //            this.Invoke(mi);

        //Thread.Sleep(5000);
        //        }
        //}

        private void listMarket_SelectedIndexChanged(object sender, EventArgs e)
        {
            StartTrading(listMarket.SelectedItem.ToString());
        }
    }
}
