using FormConsole.Sources;
using Jojatekok.PoloniexAPI;
using Jojatekok.PoloniexAPI.MarketTools;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormConsole
{
    public partial class MainForm : Form
    {
        const string CURRENCY_USDT = "USDT";

        Business BIZ = new Business();        

        Balances _balances;
        IDisposable _subsBalances;
        Signal _signal;
        IDisposable _subsSignal;
        Ticker _ticker;
        IDisposable _subsTicker;

        //IList<TickerModel> _trades = new List<TickerModel>();
        BindingList<TickerModel> _blBots = new BindingList<TickerModel>();
        BindingSource _bsBots = null;
        BindingList<TickerModel> _blTrades = new BindingList<TickerModel>();
        BindingSource _bsTrades = null;

        #region Properties

        private CurrencyPair CurrencyPair
        {
            get
            {
                //return new CurrencyPair(tabsMarkets.SelectedTab.Text, cbbCoins.SelectedText);
                return new CurrencyPair(lbCoins.SelectedItem.ToString());
            }
        }

        private string BalancesBase
        {
            get
            {
                return lblBalancesBase.Text;
            }
            set
            {
                lblBalancesBase.Text = value;
            }
        }

        private string BalancesQuote
        {
            get
            {
                return lblBalancesQuote.Text;
            }
            set
            {
                lblBalancesQuote.Text = value;
            }
        }

        private string BotAmount
        {
            get
            {
                return txtBotAmount.Text;
            }
            set
            {
                txtBotAmount.Text = value;
            }
        }

        private string BalanceBuy
        {
            get
            {
                return lblBalanceBuy.Text;
            }
            set
            {
                lblBalanceBuy.Text = value;
            }
        }

        private string BalanceSell
        {
            get
            {
                return lblBalanceSell.Text;
            }
            set
            {
                lblBalanceSell.Text = value;
            }
        }

        private string BuyPrice
        {
            get
            {
                return txtBuyPrice.Text;
            }
            set
            {
                txtBuyPrice.Text = value;
            }
        }

        private string BuyPriceUsdt
        {
            get
            {
                return txtBuyPriceUsdt.Text;
            }
            set
            {
                txtBuyPriceUsdt.Text = value;
            }
        }

        private string BuyAmount
        {
            get
            {
                return txtBuyAmount.Text;
            }
            set
            {
                txtBuyAmount.Text = value;
            }
        }

        private string BuyAmountUsdt
        {
            get
            {
                return txtBuyAmountUsdt.Text;
            }
            set
            {
                txtBuyAmountUsdt.Text = value;
            }
        }

        private string BuyTotal
        {
            get
            {
                return txtBuyTotal.Text;
            }
            set
            {
                txtBuyTotal.Text = value;
            }
        }

        private string BuyTotalUsdt
        {
            get
            {
                return txtBuyTotalUsdt.Text;
            }
            set
            {
                txtBuyTotalUsdt.Text = value;
            }
        }

        private string SellPrice
        {
            get
            {
                return txtSellPrice.Text;
            }
            set
            {
                txtSellPrice.Text = value;
            }
        }

        private string SellPriceUsdt
        {
            get
            {
                return txtSellPriceUsdt.Text;
            }
            set
            {
                txtSellPriceUsdt.Text = value;
            }
        }

        private string SellAmount
        {
            get
            {
                return txtSellAmount.Text;
            }
            set
            {
                txtSellAmount.Text = value;
            }
        }

        private string SellAmountUsdt
        {
            get
            {
                return txtSellAmountUsdt.Text;
            }
            set
            {
                txtSellAmountUsdt.Text = value;
            }
        }

        private string SellTotal
        {
            get
            {
                return txtSellTotal.Text;
            }
            set
            {
                txtSellTotal.Text = value;
            }
        }

        private string SellTotalUsdt
        {
            get
            {
                return txtSellTotalUsdt.Text;
            }
            set
            {
                txtSellTotalUsdt.Text = value;
            }
        }

        private double GetBuyBalance(IList<BalanceModel> balances)
        {
            
            return (from x in BIZ.GetBalances() where x.Type == CurrencyPair.BaseCurrency select x.QuoteAvailable).SingleOrDefault();
        }

        private double GetSellBalance(IList<BalanceModel> balances)
        {

            return (from x in BIZ.GetBalances() where x.Type == CurrencyPair.QuoteCurrency select x.QuoteAvailable).SingleOrDefault();
        }

        private double GetBuySellPrice(IDictionary<CurrencyPair, IMarketData> markets)
        {
            return BIZ.GetCurrency(markets, CurrencyPair).PriceLast;
        }

        private double GetBotAmount()
        {
            double? amount = Utilities.TryParseDouble(BotAmount);

            if (amount != null)
                return double.Parse(amount.ToString());

            return 0;
        }

        private double? GetBuySellPriceUsdt(IDictionary<CurrencyPair, IMarketData> markets)
        {
            if (CurrencyPair.BaseCurrency == CURRENCY_USDT)
            {
                txtBuyPriceUsdt.Enabled = false;
                txtBuyPriceUsdt.BackColor = System.Drawing.Color.LightGray;
                txtSellPriceUsdt.Enabled = false;
                txtSellPriceUsdt.BackColor = System.Drawing.Color.LightGray;
                txtBuyAmountUsdt.Enabled = false;
                txtBuyAmountUsdt.BackColor = System.Drawing.Color.LightGray;
                txtSellAmountUsdt.Enabled = false;
                txtSellAmountUsdt.BackColor = System.Drawing.Color.LightGray;
                txtBuyTotalUsdt.Enabled = false;
                txtBuyTotalUsdt.BackColor = System.Drawing.Color.LightGray;
                txtSellTotalUsdt.Enabled = false;
                txtSellTotalUsdt.BackColor = System.Drawing.Color.LightGray;

                return Utilities.TryParseDouble(BuyPrice);
            }
            else
            {
                //usdtMarket = BIZ.GetCurrency(markets, currencyPairUsdt);
                //baseCurrencyUnitPrice = (amountToTrade / usdtMarket.PriceLast) / marketToTrade.PriceLast;
            }
            //return BIZ.GetCurrency(markets, new CurrencyPair(CURRENCY_USDT, CurrencyPair.BaseCurrency)).PriceLast;
            return null;
        }

        private double? GetBuyAmountUsdt()
        {
            IDictionary<CurrencyPair, IMarketData> markets = BIZ.GetSummary();
            IMarketData market = BIZ.GetCurrency(markets, CurrencyPair);

            if (CurrencyPair.BaseCurrency == CURRENCY_USDT)
            {
                return Utilities.TryParseDouble(BuyAmount);
            }
            else
            {
                //usdtMarket = BIZ.GetCurrency(markets, currencyPairUsdt);
                //baseCurrencyUnitPrice = (amountToTrade / usdtMarket.PriceLast) / marketToTrade.PriceLast;
            }
            return 0;
        }

        private double? GetSellAmountUsdt()
        {
            IDictionary<CurrencyPair, IMarketData> markets = BIZ.GetSummary();
            IMarketData market = BIZ.GetCurrency(markets, CurrencyPair);

            if (CurrencyPair.BaseCurrency == CURRENCY_USDT)
            {
                var baseCurrencyUnitPrice = Utilities.TryParseDouble(SellAmount) / market.PriceLast;
                var baseCurrencyTotal = Utilities.TryParseDouble(SellPrice) * baseCurrencyUnitPrice;
                return baseCurrencyTotal * Utilities.TryParseDouble(SellPrice);
            }
            else
            {
                //usdtMarket = BIZ.GetCurrency(markets, currencyPairUsdt);
                //baseCurrencyUnitPrice = (amountToTrade / usdtMarket.PriceLast) / marketToTrade.PriceLast;
            }
            return 0;
        }

        #endregion Properties

        public MainForm()
        {
            InitializeComponent();
            FillCbbCoins();

            dgvCurrentTrades.Columns[1].DefaultCellStyle.Format = "N4";
            dgvCurrentTrades.Columns[5].DefaultCellStyle.Format = "N4";
            dgvCurrentTrades.Columns[6].DefaultCellStyle.Format = "N4";
            dgvCurrentTrades.Columns[7].DefaultCellStyle.Format = "N4";
            dgvCurrentTrades.Columns[8].DefaultCellStyle.Format = "N4";
            dgvCurrentTrades.Columns[9].DefaultCellStyle.Format = "C";
            dgvCurrentTrades.Columns[10].DefaultCellStyle.Format = "C";
            dgvCurrentTrades.Columns[11].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";

            dgvBalances.Columns[3].DefaultCellStyle.Format = "N8";

            //lbCoins.SelectedIndex = lbCoins.FindStringExact("usdt_btc");

            if (_balances != null) //Si existe, alors dispose objet existant (pour sortir de la boucle)
                _balances.Dispose();

            CurrencyPair currencyPair = new CurrencyPair(lbCoins.SelectedItem.ToString());
            _balances = new Balances(currencyPair.BaseCurrency); //cré un nouvel objet pour balance
            _subsBalances = _balances.DataSource //S'abonne à l'observable
                //.Sample(TimeSpan.FromMilliseconds(300)) //1 donnée au 300 ms pour affichage
                .ObserveOn(WindowsFormsSynchronizationContext.Current) //Reviens sur le thread du UI
                .Subscribe(x => DisplayBalances(x));
        }

        private void FillCbbCoins()
        {
            lbCoins.DataSource = BIZ.GetMarket(tabsMarkets.SelectedTab.Text).ToList();
        }

        private void btnStartBot_Click(object sender, EventArgs e)
        {
            CurrencyPair currencyPair = new CurrencyPair(lbCoins.SelectedItem.ToString());
            _ticker = new Ticker(currencyPair, GetBotAmount(), 0);

            TickerModel bot = new TickerModel()
            {
                currencyPair = currencyPair
            };

            CreateBot(bot);
        }

        private void CreateBot(TickerModel bot)
        {
            if (!_blBots.Select(x => x.currencyPair).Contains(bot.currencyPair))
            {
                _blBots.Add(bot);

                _signal = new Signal(CurrencyPair);
                _subsSignal = _signal.DataSource
                    .ObserveOn(WindowsFormsSynchronizationContext.Current)
                    .Subscribe(x => DisplaySignal(x, bot));

                _bsBots = new BindingSource();
                _bsBots.DataSource = _blBots;
                dgvBots.DataSource = _bsBots;
            }
        }

        private void DisplaySignal(EnumStates lastState, TickerModel bot)
        {
            switch (lastState)
            {
                case EnumStates.BOUGHT:
                    ExecuteOrder.ExecuteBuySell(lastState, CurrencyPair);
                    _blTrades.Add(bot);
                    _bsTrades = new BindingSource();
                    _bsTrades.DataSource = _blTrades;

                    UpdateTrades(bot);

                    _subsTicker = _ticker.DataSource
                        //.Select(x => CreateBot(x))
                        .ObserveOn(WindowsFormsSynchronizationContext.Current)
                        .Subscribe(x => UpdateTrades(x));

                    break;
                case EnumStates.SOLD:
                    break;
                case EnumStates.WAITING:
                    break;
                default:

                    break;
            }
        }

        private void UpdateTrades(TickerModel ticker)
        {
            dgvCurrentTrades.DataSource = _bsTrades;

            foreach (DataGridViewRow row in dgvCurrentTrades.Rows)
            {
                if (row.Cells[0].Value == ticker.currencyPair)
                {
                    row.Cells[1].Value = ticker.amountToTrade;
                    row.Cells[2].Value = ticker.pricePaid;
                    row.Cells[3].Value = ticker.priceLast;
                    row.Cells[4].Value = ticker.highestPrice;
                    row.Cells[5].Value = ticker.profit;
                    row.Cells[6].Value = ticker.higuestProfit;
                    row.Cells[7].Value = ticker.highestProfitDiff;
                    row.Cells[8].Value = ticker.lossTolerance;
                    row.Cells[9].Value = ticker.baseCurrencyTotal;
                    row.Cells[10].Value = ticker.usdTotalValue;
                    row.Cells[11].Value = DateTime.Now;

                    if (ticker.profit >= 0)
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    else
                        row.DefaultCellStyle.BackColor = Color.LightPink;
                }
            }
        }

        private void DisplayBalances(IList<BalanceModel> balances)
        {
            dgvBalances.DataSource = balances
                .Where(x => x.Type == CurrencyPair.BaseCurrency || x.USDT_Value > 0)
                .OrderByDescending(x => x.Type == CurrencyPair.BaseCurrency)
                .ThenBy(x => x).ToList();

            UpdateBalances(balances);
            //UpdatePrice();
            //UpdateAmountUsdt();
        }

        private void UpdateBalances(IList<BalanceModel> balances)
        {
            BalancesBase = balances
                .Where(x => x.Type == CurrencyPair.BaseCurrency)
                .Select(x => x.QuoteAvailable)
                .FirstOrDefault().ToString();

            BalancesQuote = balances
                .Where(x => x.Type == CurrencyPair.QuoteCurrency)
                .Select(x => x.QuoteAvailable)
                .FirstOrDefault().ToString();
        }

        private void UpdatePrice()
        {
            IDictionary<CurrencyPair, IMarketData> markets = BIZ.GetSummary();
            BuyPrice = SellPrice = GetBuySellPrice(markets).ToString();
            BuyPriceUsdt = SellPriceUsdt = GetBuySellPriceUsdt(markets).ToString();
        }

        private void UpdateAmountUsdt()
        {
            BuyAmountUsdt = BalanceBuy;
        }

        private void lbCoins_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbTrade.Text = $"Trade {CurrencyPair.QuoteCurrency}";
            
            lblBalancesTitleBase.Text = $"{CurrencyPair.BaseCurrency}";
            lblBalancesTitleQuote.Text = $"{CurrencyPair.QuoteCurrency}";

            lblBalanceTitleBuy.Text = $"{CurrencyPair.BaseCurrency} Balance:";
            lblBalanceTitleSell.Text = $"{CurrencyPair.QuoteCurrency} Balance:";

            IList<BalanceModel> balances = BIZ.GetBalances();
            BalancesBase = BalanceBuy = BotAmount = GetBuyBalance(balances).ToString();
            BalancesQuote = BalanceSell = GetSellBalance(balances).ToString();

            IDictionary<CurrencyPair, IMarketData> markets = BIZ.GetSummary();
            BuyPrice = SellPrice = GetBuySellPrice(markets).ToString();
            BuyPriceUsdt = SellPriceUsdt = GetBuySellPriceUsdt(markets).ToString();

            BuyAmount = string.Empty;
            SellAmount = string.Empty;
            BuyTotal = string.Empty;
            SellTotal = string.Empty;
            BuyAmountUsdt = string.Empty;
            SellAmountUsdt = string.Empty;

        }

        #region Buttons percentages

        private void btnBuy25_Click(object sender, EventArgs e)
        {
            BuyAmountUsdt = Utilities.TruncateDouble(Utilities.TryParseDouble(BalanceBuy) * 0.25).ToString();
        }

        private void btnBuy50_Click(object sender, EventArgs e)
        {
            BuyAmountUsdt = Utilities.TruncateDouble(Utilities.TryParseDouble(BalanceBuy) * 0.5).ToString();
        }

        private void btnBuy75_Click(object sender, EventArgs e)
        {
            BuyAmountUsdt = Utilities.TruncateDouble(Utilities.TryParseDouble(BalanceBuy) * 0.75).ToString();
        }

        private void btnBuy100_Click(object sender, EventArgs e)
        {
            BuyAmountUsdt = (Utilities.TryParseDouble(BalanceBuy)).ToString();
        }

        private void btnSell25_Click(object sender, EventArgs e)
        {
            SellAmount = Utilities.TruncateDouble(Utilities.TryParseDouble(BalanceSell) * 0.25).ToString();
        }

        private void btnSell50_Click(object sender, EventArgs e)
        {
            SellAmount = Utilities.TruncateDouble(Utilities.TryParseDouble(BalanceSell) * 0.5).ToString();
        }

        private void btnSell75_Click(object sender, EventArgs e)
        {
            SellAmount = Utilities.TruncateDouble(Utilities.TryParseDouble(BalanceSell) * 0.75).ToString();
        }

        private void btnSell100_Click(object sender, EventArgs e)
        {
            SellAmount = (Utilities.TryParseDouble(BalanceSell)).ToString();
        }

        #endregion Buttons percentages

        private void lblBalanceBuy_Click(object sender, EventArgs e)
        {
            BuyAmountUsdt = BalanceBuy;
        }

        //private void lblBalanceBuy_TextChanged(object sender, EventArgs e)
        //{
        //    BuyAmountUsdt = BalanceBuy;
        //}

        private void lblBalanceSell_Click(object sender, EventArgs e)
        {
            SellAmount = lblBalanceSell.Text;
        }

        //private void lblBalanceSell_TextChanged(object sender, EventArgs e)
        //{
        //    SellAmountUsdt = lblBalanceSell.Text;
        //}

        #region TextChanged

        private void txtBuyPrice_TextChanged(object sender, EventArgs e)
        {
            BuyPriceUsdt = (Utilities.TryParseDouble(BuyPrice)).ToString();
        }

        private void txtBuyAmount_TextChanged(object sender, EventArgs e)
        {
            BuyTotal = Utilities.TruncateDouble(Utilities.TryParseDouble(BuyPrice) * Utilities.TryParseDouble(BuyAmount)).ToString();
        }

        private void txtBuyAmountUsdt_TextChanged(object sender, EventArgs e)
        {
            BuyAmount = Utilities.TruncateDouble(Utilities.TryParseDouble(BuyAmountUsdt) / Utilities.TryParseDouble(BuyPrice)).ToString();
        }

        private void txtBuyTotal_TextChanged(object sender, EventArgs e)
        {
            BuyTotalUsdt = (Utilities.TryParseDouble(BuyTotal)).ToString();
        }

        private void txtSellPrice_TextChanged(object sender, EventArgs e)
        {
            SellPriceUsdt = (Utilities.TryParseDouble(SellPrice)).ToString();
        }

        private void txtSellAmount_TextChanged(object sender, EventArgs e)
        {
            SellAmountUsdt = (Utilities.TryParseDouble(GetSellAmountUsdt().ToString())).ToString();

            SellTotal = Utilities.TruncateDouble(Utilities.TryParseDouble(SellPrice) * Utilities.TryParseDouble(SellAmount)).ToString();
        }
        
        private void txtSellTotal_TextChanged(object sender, EventArgs e)
        {
            SellTotalUsdt = (Utilities.TryParseDouble(SellTotal)).ToString();
        }

        #endregion TextChanged
    }
}
