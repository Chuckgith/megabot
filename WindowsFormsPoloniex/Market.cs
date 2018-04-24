using Jojatekok.PoloniexAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsPoloniex.ViewModel;

namespace WindowsFormsPoloniex
{
    public partial class Market : Form
    {
        public Market()
        {
            InitializeComponent();
        }
        BusinessLive bLive = new BusinessLive();

        private async void Trading_Shown(object sender, EventArgs e)
        {
            try
            {
                while (true)
                {
                    if (!bLive.live.WampChannelOpenTask.IsFaulted)
                    {
                        if (bLive.live.Tickers.Count > 0)
                        {
                            //text = (b.live.Tickers[new Jojatekok.PoloniexAPI.CurrencyPair("USDT", "LTC")].PriceLast).ToString();

                            var list = new List<MarketsViewModel>();

                            var collection = bLive.live.Tickers.ToList();

                            var tickers = (from ticker in collection
                                           orderby ticker.Key.QuoteCurrency
                                           where ticker.Key.BaseCurrency == "USDT"

                                           select new MarketsViewModel
                                           {
                                               Coin = ticker.Key.QuoteCurrency,
                                               Change = ticker.Value.PriceChangePercentage.ToString("P2"),
                                               Price = ticker.Value.PriceLast.ToString()
                                           }).ToList();

                            foreach (var item in collection)
                            {
                                if (item.Key.BaseCurrency == "USDT")
                                {
                                    list.Add(new MarketsViewModel() { Coin = item.Key.QuoteCurrency, Change = item.Value.PriceChangePercentage.ToString("P2"), Price = item.Value.PriceLast.ToString() });
                                }
                            }

                            //var tickers = (from ticker in b.live.Tickers orderby ticker select new MarketsViewModel { Coin = ticker.Key.QuoteCurrency }).ToList();

                            gridMarkets.Invoke(new Action(() => gridMarkets.DataSource = tickers));

                        };

                        await Task.Delay(1000).ConfigureAwait(false);
                    }
                    else
                    {
                        bLive.live.Stop();

                        Application.Exit();
                    }

                }

            }
            catch (Exception)
            {

                bLive.live.Stop();
            }
        }

        private void Trading_FormClosing(object sender, FormClosingEventArgs e)
        {
            bLive.live.Stop();
        }
    }
}
