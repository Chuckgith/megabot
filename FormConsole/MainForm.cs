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
using System.Diagnostics;
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

        BindingList<BotModel> _blTrades = new BindingList<BotModel>();
        BindingSource _bsTrades = null;

        BindingList<FlatBotModel> _blClosedTrades = new BindingList<FlatBotModel>();
        BindingSource _bsClosedTrades = null;

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

        private string BotLosstolerance
        {
            get
            {
                return txtBotLossTolerance.Text;
            }
            set
            {
                txtBotLossTolerance.Text = value;
            }
        }

        private string BotMultiplicator
        {
            get
            {
                return txtBotMultiplicator.Text;
            }
            set
            {
                txtBotMultiplicator.Text = value;
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
            double? amount = Utilities.TryParseDoublePolo(BotAmount);

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

                return Utilities.TryParseDoublePolo(BuyPrice);
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
                return Utilities.TryParseDoublePolo(BuyAmount);
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
                var baseCurrencyUnitPrice = Utilities.TryParseDoublePolo(SellAmount) / market.PriceLast;
                var baseCurrencyTotal = Utilities.TryParseDoublePolo(SellPrice) * baseCurrencyUnitPrice;
                return baseCurrencyTotal * Utilities.TryParseDoublePolo(SellPrice);
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

            dgvBalances.Columns[3].DefaultCellStyle.Format = "N8";

            dgvCurrentTrades.Columns[2].DefaultCellStyle.Format = "N8";
            dgvCurrentTrades.Columns[3].DefaultCellStyle.Format = "N4";
            dgvCurrentTrades.Columns[4].DefaultCellStyle.Format = "N8";
            dgvCurrentTrades.Columns[5].DefaultCellStyle.Format = "N8";
            dgvCurrentTrades.Columns[6].DefaultCellStyle.Format = "N8";
            dgvCurrentTrades.Columns[7].DefaultCellStyle.Format = "N4";
            dgvCurrentTrades.Columns[8].DefaultCellStyle.Format = "N4";
            dgvCurrentTrades.Columns[9].DefaultCellStyle.Format = "N8";
            dgvCurrentTrades.Columns[10].DefaultCellStyle.Format = "N8";
            dgvCurrentTrades.Columns[11].DefaultCellStyle.Format = "N8";
            dgvCurrentTrades.Columns[12].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";

            lbCoins.SelectedIndex = lbCoins.FindStringExact("usdt_btc");

            BotLosstolerance = "-0.1";
            BotMultiplicator = "0.002";

            if (_balances != null) //Si existe, alors dispose objet existant (pour sortir de la boucle)
                _balances.Dispose();

            CurrencyPair currencyPair = new CurrencyPair(lbCoins.SelectedItem.ToString());
            _balances = new Balances(currencyPair.BaseCurrency);
            _subsBalances = _balances.DataSource
                .ObserveOn(WindowsFormsSynchronizationContext.Current)
                .Subscribe(x => DisplayBalances(x));
        }

        private void FillCbbCoins()
        {
            lbCoins.DataSource = BIZ.GetMarket(tabsMarkets.SelectedTab.Text).ToList();
        }

        private void btnStartBot_Click(object sender, EventArgs e)
        {
            CurrencyPair currencyPair = new CurrencyPair(lbCoins.SelectedItem.ToString());

            BotModel bot = new BotModel()
            {
                CurrencyPair = currencyPair,
                Status = EnumStatus.WAITING,
                Amount = GetBotAmount(),
                LossTolerance = double.Parse(Utilities.TryParseDouble(BotLosstolerance).ToString()),
                ToleranceProfitHighDiff = double.Parse(Utilities.TryParseDouble(BotLosstolerance).ToString()),
                LossToleranceMultiplicator = double.Parse(Utilities.TryParseDouble(BotLosstolerance).ToString())
            };

            CreateBot(bot);
        }

        private void CreateBot(BotModel bot)
        {
            if (!_blTrades.Select(x => x.CurrencyPair).Contains(bot.CurrencyPair))
            {
                _blTrades.Add(bot);
                _bsTrades = new BindingSource(_blTrades, null);
                dgvCurrentTrades.DataSource = _bsTrades;

                _signal = new Signal(CurrencyPair);
                _subsSignal = _signal.DataSource
                    .ObserveOn(WindowsFormsSynchronizationContext.Current)
                    .Subscribe(x => PerformSignal(bot, x));
            }
        }

        private void PerformSignal(BotModel bot, SignalModel signal)
        {
            if (signal.OrderType == OrderType.Buy)
            {
                if (bot.Status == EnumStatus.WAITING)
                    PerformBuy(bot);
                else if (bot.Status == EnumStatus.BOUGHT)
                    txtLogs.AppendText($"{DateTime.Now} - {signal.CurrencyPair} - BUY - Already bought{Environment.NewLine}");
            }
            else if (signal.OrderType == OrderType.Sell)
            {
                if (bot.Status == EnumStatus.BOUGHT)
                    PerformSell(bot);
                else if (bot.Status == EnumStatus.WAITING)
                    txtLogs.AppendText($"{DateTime.Now} - {signal.CurrencyPair} - SELL - Already sold{Environment.NewLine}");
            }
        }

        private void PerformBuy(BotModel bot)
        {
            OrderModel order = null;
            var stopwatch = new Stopwatch();
            long elapsedTime = 0;

            txtLogs.AppendText($"{DateTime.Now} - {bot.CurrencyPair} - BUY");
            bot.Status = EnumStatus.BUYING;
            //UpdateTrades(bot);

            stopwatch.Start();
            order = ExecuteOrder.ExecuteBuySell(OrderType.Buy, CurrencyPair);
            stopwatch.Stop();
            elapsedTime = stopwatch.ElapsedMilliseconds;

            txtLogs.AppendText($" => OK BOUGHT (elapsed time: {elapsedTime / 1000} secs){Environment.NewLine}");
            bot.Status = EnumStatus.BOUGHT;
            //UpdateTrades(bot);

            bot.PricePaid = order.PricePerCoin;

            _ticker = new Ticker(bot.CurrencyPair, bot.Amount, bot.PricePaid, bot.LossTolerance, 0);
            _subsTicker = _ticker.DataSource
                .ObserveOn(WindowsFormsSynchronizationContext.Current)
                .Subscribe(x => UpdateTrades(bot, x));
        }

        private void PerformSell(BotModel bot)
        {
            OrderModel order = null;
            var stopwatch = new Stopwatch();
            long elapsedTime = 0;

            txtLogs.AppendText($"{DateTime.Now} - {bot.CurrencyPair} - SELL");
            bot.Status = EnumStatus.SELLING;
            //UpdateTrades(bot);

            stopwatch.Start();
            order = ExecuteOrder.ExecuteBuySell(OrderType.Sell, CurrencyPair);
            stopwatch.Stop();
            elapsedTime = stopwatch.ElapsedMilliseconds;

            txtLogs.AppendText($" => OK SOLD (elapsed time: {elapsedTime / 1000} secs){Environment.NewLine}");
            bot.Status = EnumStatus.SOLD;

            _subsTicker.Dispose();

            FlatBotModel botClosed = new FlatBotModel()
            {
                CurrencyPair = bot.CurrencyPair,
                Status = bot.Status,
                Amount = bot.Amount,
                LossTolerance = bot.LossTolerance,
                PricePaid = bot.PricePaid,
                PriceLast = bot.Ticker.PriceLast,
                HighestPrice = bot.Ticker.HighestPrice,
                Profit = bot.Ticker.Profit,
                HiguestProfit = bot.Ticker.HiguestProfit,
                HighestProfitDiff = bot.Ticker.HighestProfitDiff,
                BaseCurrencyTotal = bot.Ticker.BaseCurrencyTotal,
                UsdTotalValue = bot.Ticker.UsdTotalValue,
                Time = bot.Ticker.Time
            };

            _blClosedTrades.Add(botClosed);
            _bsClosedTrades = new BindingSource(_blClosedTrades, null);
            dgvClosedTrades.DataSource = _bsClosedTrades;

            bot.Status = EnumStatus.WAITING;
            UpdateTrades(bot);
        }

        private void UpdateTrades(BotModel bot, TickerModel ticker = null)
        {
            bot.Ticker = ticker;

            foreach (DataGridViewRow row in dgvCurrentTrades.Rows)
            {
                if (object.Equals(DataGridHelper.GetCell(row.Cells, "CurrencyPair"), bot.CurrencyPair))
                {
                    DataGridHelper.SetCell(row.Cells, "Status", bot.Status);
                    //DataGridHelper.SetCell(row.Cells, "Amount", bot.Amount);

                    if (bot.Ticker != null)
                    {                        
                        DataGridHelper.SetCell(row.Cells, "PricePaid", bot.PricePaid);
                        DataGridHelper.SetCell(row.Cells, "LossTolerance", bot.LossTolerance);
                        DataGridHelper.SetCell(row.Cells, "PriceLast", bot.Ticker.PriceLast);
                        DataGridHelper.SetCell(row.Cells, "HighestPrice", bot.Ticker.HighestPrice);
                        DataGridHelper.SetCell(row.Cells, "Profit", bot.Ticker.Profit);
                        DataGridHelper.SetCell(row.Cells, "HiguestProfit", bot.Ticker.HiguestProfit);
                        DataGridHelper.SetCell(row.Cells, "HighestProfitDiff", bot.Ticker.HighestProfitDiff);                        
                        DataGridHelper.SetCell(row.Cells, "BaseCurrencyTotal", bot.Ticker.BaseCurrencyTotal);
                        DataGridHelper.SetCell(row.Cells, "UsdTotalValue", bot.Ticker.UsdTotalValue);
                        DataGridHelper.SetCell(row.Cells, "Time", DateTime.Now);

                        if (bot.Ticker.Profit >= 0)
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                        else
                            row.DefaultCellStyle.BackColor = Color.LightPink;
                    }
                    else
                    {
                        DataGridHelper.SetCell(row.Cells, "PricePaid", 0);
                        DataGridHelper.SetCell(row.Cells, "PriceLast", string.Empty);
                        DataGridHelper.SetCell(row.Cells, "HighestPrice", string.Empty);
                        DataGridHelper.SetCell(row.Cells, "Profit", string.Empty);
                        DataGridHelper.SetCell(row.Cells, "HiguestProfit", string.Empty);
                        DataGridHelper.SetCell(row.Cells, "HighestProfitDiff", string.Empty);
                        DataGridHelper.SetCell(row.Cells, "BaseCurrencyTotal", string.Empty);
                        DataGridHelper.SetCell(row.Cells, "UsdTotalValue", string.Empty);
                        DataGridHelper.SetCell(row.Cells, "Time", string.Empty);

                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }

            if (CheckTolerance(bot, ticker))
            {
                PerformSell(bot);
            }
        }

        private bool CheckTolerance(BotModel bot, TickerModel ticker)
        {
            if (ticker == null)
                return false;

            if (//ticker.HighestProfitDiff < -0.3 &&
                ticker.HighestProfitDiff < bot.ToleranceProfitHighDiff)
            {
                System.Media.SystemSounds.Exclamation.Play();

                Debug.WriteLine(string.Format(
                    "{0} (limit: {1}% - High_diff: {2}%)",
                        "tolerance reach",
                        bot.ToleranceProfitHighDiff,
                        string.Format("{0:0.0000}", ticker.HighestProfitDiff)));

                return true;
            }
            return false;
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
            BuyAmountUsdt = Utilities.TruncateDouble(Utilities.TryParseDoublePolo(BalanceBuy) * 0.25).ToString();
        }

        private void btnBuy50_Click(object sender, EventArgs e)
        {
            BuyAmountUsdt = Utilities.TruncateDouble(Utilities.TryParseDoublePolo(BalanceBuy) * 0.5).ToString();
        }

        private void btnBuy75_Click(object sender, EventArgs e)
        {
            BuyAmountUsdt = Utilities.TruncateDouble(Utilities.TryParseDoublePolo(BalanceBuy) * 0.75).ToString();
        }

        private void btnBuy100_Click(object sender, EventArgs e)
        {
            BuyAmountUsdt = (Utilities.TryParseDoublePolo(BalanceBuy)).ToString();
        }

        private void btnSell25_Click(object sender, EventArgs e)
        {
            SellAmount = Utilities.TruncateDouble(Utilities.TryParseDoublePolo(BalanceSell) * 0.25).ToString();
        }

        private void btnSell50_Click(object sender, EventArgs e)
        {
            SellAmount = Utilities.TruncateDouble(Utilities.TryParseDoublePolo(BalanceSell) * 0.5).ToString();
        }

        private void btnSell75_Click(object sender, EventArgs e)
        {
            SellAmount = Utilities.TruncateDouble(Utilities.TryParseDoublePolo(BalanceSell) * 0.75).ToString();
        }

        private void btnSell100_Click(object sender, EventArgs e)
        {
            SellAmount = (Utilities.TryParseDoublePolo(BalanceSell)).ToString();
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
            BuyPriceUsdt = (Utilities.TryParseDoublePolo(BuyPrice)).ToString();
        }

        private void txtBuyAmount_TextChanged(object sender, EventArgs e)
        {
            BuyTotal = Utilities.TruncateDouble(Utilities.TryParseDoublePolo(BuyPrice) * Utilities.TryParseDoublePolo(BuyAmount)).ToString();
        }

        private void txtBuyAmountUsdt_TextChanged(object sender, EventArgs e)
        {
            BuyAmount = Utilities.TruncateDouble(Utilities.TryParseDoublePolo(BuyAmountUsdt) / Utilities.TryParseDoublePolo(BuyPrice)).ToString();
        }

        private void txtBuyTotal_TextChanged(object sender, EventArgs e)
        {
            BuyTotalUsdt = (Utilities.TryParseDoublePolo(BuyTotal)).ToString();
        }

        private void txtSellPrice_TextChanged(object sender, EventArgs e)
        {
            SellPriceUsdt = (Utilities.TryParseDoublePolo(SellPrice)).ToString();
        }

        private void txtSellAmount_TextChanged(object sender, EventArgs e)
        {
            SellAmountUsdt = (Utilities.TryParseDoublePolo(GetSellAmountUsdt().ToString())).ToString();

            SellTotal = Utilities.TruncateDouble(Utilities.TryParseDoublePolo(SellPrice) * Utilities.TryParseDoublePolo(SellAmount)).ToString();
        }
        
        private void txtSellTotal_TextChanged(object sender, EventArgs e)
        {
            SellTotalUsdt = (Utilities.TryParseDoublePolo(SellTotal)).ToString();
        }

        #endregion TextChanged
    }
}
