using FormConsole.Sources;
using Jojatekok.PoloniexAPI;
using Jojatekok.PoloniexAPI.MarketTools;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using System;
using System.Collections;
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
using System.Reflection;
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
        IDictionary<CurrencyPair, IDisposable> _subsSignals = new Dictionary<CurrencyPair, IDisposable>();
        Ticker _ticker;
        IDictionary<CurrencyPair, IDisposable> _subsTickers = new Dictionary<CurrencyPair, IDisposable>();

        BindingList<FlatTradeModel> _blTrades = new BindingList<FlatTradeModel>();
        BindingSource _bsTrades = null;

        BindingList<FlatTradeModel> _blClosedTrades = new BindingList<FlatTradeModel>();
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
                return lblValueTolerance.Text;
            }
            set
            {
                lblValueTolerance.Text = value;
            }
        }

        private string BotMultiplicator
        {
            get
            {
                return lblValueMultiplicator.Text;
            }
            set
            {
                lblValueMultiplicator.Text = value;
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

            lbCoins.SelectedIndex = lbCoins.FindStringExact("usdt_btc");

            trbTolerance.Value = 4;
            trbMultiplicator.Value = 0;

            if (_balances != null) //Si existe, alors dispose objet existant (pour sortir de la boucle)
                _balances.Dispose();

            CurrencyPair currencyPair = new CurrencyPair(lbCoins.SelectedItem.ToString());
            _balances = new Balances(currencyPair.BaseCurrency);
            _subsBalances = _balances.DataSource
                .ObserveOn(WindowsFormsSynchronizationContext.Current)
                .Subscribe(x => DisplayBalances(x));

            //IList<Jojatekok.PoloniexAPI.TradingTools.ITrade> trades = BIZ.GetTrades(CurrencyPair);//, DateTime.Now.AddHours(3).AddMinutes(-10), DateTime.Now.AddHours(3));
            //IOrderBook orders = BIZ.GetOpenOrders(CurrencyPair, 20);

            Task.Factory.StartNew(() => GetOrderBook());
        }

        private void GetOrderBook()
        {
            while (true)
            {
                IList<ITrade> market = BIZ.MCGetTrades(new CurrencyPair("USDT_BTC"), DateTime.Now.AddHours(4).AddSeconds(-10), DateTime.Now.AddHours(4));
                double nbBuy = market.Where(x => x.Type == OrderType.Buy).Count();
                double nbSell = market.Where(x => x.Type == OrderType.Sell).Count();
                double aveNb = (nbBuy / nbSell) * 100 - 100;
                //double totBuy = market.Where(x => x.Type == OrderType.Buy).Sum(x => x.AmountBase);
                //double totSell = market.Where(x => x.Type == OrderType.Sell).Sum(x => x.AmountBase);
                if (market.Where(x => x.Type == OrderType.Buy).Select(x => x.PricePerCoin).Any() && market.Where(x => x.Type == OrderType.Sell).Select(x => x.PricePerCoin).Any())
                {
                    double aveBuy = market.Where(x => x.Type == OrderType.Buy).Select(x => x.PricePerCoin).Average();
                    double aveSell = market.Where(x => x.Type == OrderType.Sell).Select(x => x.PricePerCoin).Average();
                    double spread = (aveBuy - aveSell) / aveBuy * 100;
                    if (textBox1.InvokeRequired)
                    {
                        textBox1.BeginInvoke((Action)(() => textBox1.Text = spread.ToString()));
                    }
                }                
                Thread.Sleep(1000);
            }
        }

        private void FillCbbCoins()
        {
            lbCoins.DataSource = BIZ.GetMarket(tabsMarkets.SelectedTab.Text).ToList();
        }

        private void btnStartBot_Click(object sender, EventArgs e)
        {
            TradeModel trade = new TradeModel()
            {
                CurrencyPair = CurrencyPair,
                Status = EnumStatus.WAITING,
                Amount = GetBotAmount(),
                Tolerance = double.Parse(Utilities.TryParseDouble(BotLosstolerance).ToString()),
                Multiplicator = double.Parse(Utilities.TryParseDouble(BotMultiplicator).ToString())
            };

            AddTrade(trade);
        }

        private void AddTrade(TradeModel trade)
        {
            if (!_blTrades.Select(x => x.CurrencyPair).Contains(trade.CurrencyPair))
            {
                FlatTradeModel flatTrade = new FlatTradeModel(trade);

                _blTrades.Add(flatTrade);
                _bsTrades = new BindingSource(_blTrades, null);
                dgvCurrentTrades.DataSource = _bsTrades;

                UpdateTrades(trade);

                _signal = new Signal(trade.CurrencyPair);
                _subsSignals.Add(trade.CurrencyPair, _signal.DataSource
                    .ObserveOn(WindowsFormsSynchronizationContext.Current)
                    .Subscribe(x => AnalyseSignal(trade, x)));
            }
            else
                txtLogs.AppendText($"Bot {trade.CurrencyPair} => Already running{Environment.NewLine}");
        }

        private void AnalyseSignal(TradeModel trade, SignalModel signal)
        {
            if (signal.OrderType == OrderType.Buy)
            {
                if (trade.Status == EnumStatus.WAITING)
                    PerformBuy(trade);
                else if (trade.Status == EnumStatus.BOUGHT)
                    txtLogs.AppendText($"{DateTime.Now} - {signal.CurrencyPair} => BUY - Already bought{Environment.NewLine}");
            }
            else if (signal.OrderType == OrderType.Sell)
            {
                if (trade.Status == EnumStatus.BOUGHT)
                    PerformSell(trade, true);
                else if (trade.Status == EnumStatus.WAITING)
                    txtLogs.AppendText($"{DateTime.Now} - {signal.CurrencyPair} => SELL - Already sold{Environment.NewLine}");
            }
        }

        private void PerformBuy(TradeModel trade)
        {
            OrderModel order = null;
            var stopwatch = new Stopwatch();
            long elapsedTime = 0;

            txtLogs.AppendText($"{DateTime.Now} - {trade.CurrencyPair} => BUY ...{Environment.NewLine}");
            trade.Status = EnumStatus.BUYING;
            //UpdateTrades(bot);

            stopwatch.Start();
            order = ExecuteOrder.ExecuteBuySell(OrderType.Buy, trade.CurrencyPair, trade.Amount);
            stopwatch.Stop();
            elapsedTime = stopwatch.ElapsedMilliseconds;

            txtLogs.AppendText($"{DateTime.Now} - {trade.CurrencyPair} => OK BOUGHT ({elapsedTime / 1000} secs){Environment.NewLine}");
            trade.Status = EnumStatus.BOUGHT;
            //UpdateTrades(bot);

            trade.PricePaid = order.PricePerCoin;
            trade.ToleranceProfitHighDiff = trade.Tolerance;
            trade.TimeBuy = DateTime.Now;

            _ticker = new Ticker(trade.CurrencyPair, trade.Amount, trade.PricePaid, 0);

            if (!_subsTickers.TryGetValue(trade.CurrencyPair, out IDisposable subscribe))
            {
                _subsTickers.Add(trade.CurrencyPair, (_ticker.DataSource
                .ObserveOn(WindowsFormsSynchronizationContext.Current)
                .Subscribe(x => UpdateTrades(trade, x))));
            }
        }

        private void PerformSell(TradeModel trade, bool fromSignal)
        {
            OrderModel order = null;
            var stopwatch = new Stopwatch();
            long elapsedTime = 0;

            txtLogs.AppendText($"{DateTime.Now} - {trade.CurrencyPair} => SELL {(fromSignal ? "(signal)" : "(tol)")} ...{Environment.NewLine}");
            trade.Status = EnumStatus.SELLING;
            //UpdateTrades(bot);

            stopwatch.Start();
            order = ExecuteOrder.ExecuteBuySell(OrderType.Sell, trade.CurrencyPair, trade.Amount);
            stopwatch.Stop();
            elapsedTime = stopwatch.ElapsedMilliseconds;

            txtLogs.AppendText($"{DateTime.Now} - {trade.CurrencyPair} => OK SOLD ({elapsedTime / 1000} secs){Environment.NewLine}");
            trade.Status = EnumStatus.SOLD;

            DisposeSubscribeTicker(trade);

            AddClosedTrade(trade);

            trade.Status = EnumStatus.WAITING;
            UpdateTrades(trade);
        }

        private void UpdateTrades(TradeModel trade, TickerModel ticker = null)
        {
            trade.Ticker = ticker;
            FlatTradeModel flatTrade = new FlatTradeModel(trade);

            foreach (DataGridViewRow row in dgvCurrentTrades.Rows)
            {
                if (object.Equals(DataGridHelper.GetCell(row.Cells, "CurrencyPair"), trade.CurrencyPair))
                {
                    DataGridHelper.SetCell(row.Cells, "Status", flatTrade.Status);
                    DataGridHelper.SetCell(row.Cells, "PricePaid", flatTrade.PricePaid);
                    DataGridHelper.SetCell(row.Cells, "UsdtValue", flatTrade.UsdtValue);
                    DataGridHelper.SetCell(row.Cells, "PriceLast", flatTrade.PriceLast);
                    DataGridHelper.SetCell(row.Cells, "Profit", flatTrade.Profit);
                    DataGridHelper.SetCell(row.Cells, "HighestProfit", flatTrade.HighestProfit);
                    DataGridHelper.SetCell(row.Cells, "HighestProfitDiff", flatTrade.HighestProfitDiff);
                    DataGridHelper.SetCell(row.Cells, "ToleranceProfitHighDiff", flatTrade.ToleranceProfitHighDiff);
                    DataGridHelper.SetCell(row.Cells, "TimeBuy", flatTrade.TimeBuy);
                    DataGridHelper.SetCell(row.Cells, "LastTicker", flatTrade.LastTicker);
                    DataGridHelper.SetCell(row.Cells, "Action", flatTrade.Action);

                    SetColor(trade, row);
                }
            }

            if (CheckTolerance(trade, ticker))
            {
                PerformSell(trade, false);
            }

            CalculTotalGain();
        }

        private void CalculTotalGain()
        {
            double total = 0;

            foreach (DataGridViewRow row in dgvCurrentTrades.Rows)
            {
                if (DataGridHelper.GetCell(row.Cells, "Profit") != null && DataGridHelper.GetCell(row.Cells, "Profit").ToString() != string.Empty)
                    total = total + double.Parse(DataGridHelper.GetCell(row.Cells, "Profit").ToString());
            }

            foreach (DataGridViewRow row in dgvClosedTrades.Rows)
            {
                if (DataGridHelper.GetCell(row.Cells, "Profit") != null && DataGridHelper.GetCell(row.Cells, "Profit").ToString() != string.Empty)
                    total = total + double.Parse(DataGridHelper.GetCell(row.Cells, "Profit").ToString());
            }

            Total.Text = total.ToString();
        }

        private void AddClosedTrade(TradeModel trade)
        {
            FlatTradeModel tradeClosed = new FlatTradeModel(trade);

            _blClosedTrades.Add(tradeClosed);
            _bsClosedTrades = new BindingSource(_blClosedTrades, null);
            dgvClosedTrades.DataSource = _bsClosedTrades;

            foreach (DataGridViewRow row in dgvClosedTrades.Rows)
            {
                double profit = double.Parse(DataGridHelper.GetCell(row.Cells, "Profit").ToString());

                if (profit >= 5)
                    row.DefaultCellStyle.BackColor = Color.MediumPurple;
                else if (profit >= 1)
                    row.DefaultCellStyle.BackColor = Color.Lime;
                else if (profit >= 0)
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                else
                    row.DefaultCellStyle.BackColor = Color.LightPink;
            }
        }

        private void SetColor(TradeModel trade, DataGridViewRow row)
        {
            if (trade.Ticker != null)
            {
                if (trade.Ticker.Profit >= 5)
                    row.DefaultCellStyle.BackColor = Color.MediumPurple;
                else if (trade.Ticker.Profit >= 1)
                    row.DefaultCellStyle.BackColor = Color.Lime;
                else if (trade.Ticker.Profit >= 0)
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                else
                    row.DefaultCellStyle.BackColor = Color.LightPink;
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }
        }

        private bool CheckTolerance(TradeModel trade, TickerModel ticker)
        {
            if (ticker == null)
                return false;

            trade.ToleranceProfitHighDiff = trade.Tolerance + (ticker.HighestProfit * trade.Multiplicator);

            trade.ToleranceProfitHighDiff = trade.ToleranceProfitHighDiff > 0 ? 0 : trade.ToleranceProfitHighDiff;

            if (//ticker.HighestProfitDiff < -0.3 &&
                ticker.HighestProfitDiff < trade.ToleranceProfitHighDiff)
            {
                System.Media.SystemSounds.Exclamation.Play();
                return true;
            }
            return false;
        }

        private void DisplayBalances(IList<BalanceModel> balances)
        {
            dgvBalances.DataSource = balances
                .Where(x => x.Type == CurrencyPair.BaseCurrency || x.USDT_Value > 0).ToList();
            //.OrderByDescending(x => x.Type == CurrencyPair.BaseCurrency)
            //.ThenBy(x => x).ToList();

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
            grbCoinSelectedBalances.Text = $"{CurrencyPair} Balances";

            grbTrade.Text = $"Trade {CurrencyPair.QuoteCurrency}";

            lblBalancesTitleBase.Text = $"{CurrencyPair.BaseCurrency}";
            lblBalancesTitleQuote.Text = $"{CurrencyPair.QuoteCurrency}";

            lblBalanceTitleBuy.Text = $"{CurrencyPair.BaseCurrency} Balance:";
            lblBalanceTitleSell.Text = $"{CurrencyPair.QuoteCurrency} Balance:";

            IList<BalanceModel> balances = BIZ.GetBalances();
            BalancesBase = BalanceBuy = GetBuyBalance(balances).ToString();
            BotAmount = "20";
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

        private void DisposeSubscribeTicker(TradeModel trade)
        {
            if (_subsTickers.TryGetValue(trade.CurrencyPair, out IDisposable subscribe))
            {
                _subsTickers.Remove(trade.CurrencyPair);
                subscribe.Dispose();
            }
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

        private void lblBalancesBase_Click(object sender, EventArgs e)
        {
            BotAmount = (Utilities.TryParseDoublePolo(BalancesBase)).ToString();
        }

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

        #endregion TextChanged

        private void txtBotAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCurrentTrades_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                TradeModel trade = new TradeModel()
                {
                    CurrencyPair = (CurrencyPair)DataGridHelper.GetCell(dgvCurrentTrades.CurrentRow.Cells, "CurrencyPair"),
                    Status = (EnumStatus)DataGridHelper.GetCell(dgvCurrentTrades.CurrentRow.Cells, "Status"),
                    Tolerance = double.Parse(DataGridHelper.GetCell(dgvCurrentTrades.CurrentRow.Cells, "LossTolerance").ToString()),
                    Multiplicator = double.Parse(DataGridHelper.GetCell(dgvCurrentTrades.CurrentRow.Cells, "LossToleranceMultiplicator").ToString()),
                    Amount = double.Parse(DataGridHelper.GetCell(dgvCurrentTrades.CurrentRow.Cells, "Amount").ToString()),
                    Action = DataGridHelper.GetCell(dgvCurrentTrades.CurrentRow.Cells, "Action").ToString(),
                };

                OrderType orderType;
                if (trade.Action == "BUY")
                {
                    //trade.Status = EnumStatus.SOLD;
                    orderType = OrderType.Buy;
                }
                else //if(trade.Action == "SELL")
                {
                    //trade.Status = EnumStatus.BOUGHT;
                    trade.PricePaid = double.Parse(DataGridHelper.GetCell(dgvCurrentTrades.CurrentRow.Cells, "PricePaid").ToString());
                    trade.ToleranceProfitHighDiff = double.Parse(DataGridHelper.GetCell(dgvCurrentTrades.CurrentRow.Cells, "ToleranceProfitHighDiff").ToString());
                    //trade.TimeBuy = DateTime.Parse(DataGridHelper.GetCell(dgvCurrentTrades.CurrentRow.Cells, "TimeBuy").ToString());
                    trade.Ticker = new TickerModel()
                    {
                        UsdtValue = double.Parse(DataGridHelper.GetCell(dgvCurrentTrades.CurrentRow.Cells, "UsdtValue").ToString()),
                        PriceLast = double.Parse(DataGridHelper.GetCell(dgvCurrentTrades.CurrentRow.Cells, "PriceLast").ToString()),
                        Profit = double.Parse(DataGridHelper.GetCell(dgvCurrentTrades.CurrentRow.Cells, "Profit").ToString()),
                        HighestProfit = double.Parse(DataGridHelper.GetCell(dgvCurrentTrades.CurrentRow.Cells, "HighestProfit").ToString()),
                        //HighestProfitDiff = double.Parse(DataGridHelper.GetCell(dgvCurrentTrades.CurrentRow.Cells, "HighestProfitDiff").ToString()),
                        //LastTicker = DateTime.Parse(DataGridHelper.GetCell(dgvCurrentTrades.CurrentRow.Cells, "LastTicker").ToString())
                    };
                    orderType = OrderType.Sell;
                }

                SignalModel signal = new SignalModel()
                {
                    CurrencyPair = trade.CurrencyPair,
                    OrderType = orderType
                };

                AnalyseSignal(trade, signal);
            }
        }

        private void trbTolerance_ValueChanged(object sender, System.EventArgs e)
        {
            double tolerance = 0;
            tolerance = trbTolerance.Value * -0.25;

            lblValueTolerance.Text = tolerance.ToString();

            if (lblValueMultiplicator.Text == "0")
                label3.Text = string.Empty;
            else
                label3.Text = $"(auto sell at {Math.Abs(decimal.Parse(lblValueTolerance.Text.ToString()) / decimal.Parse(lblValueMultiplicator.Text.ToString())).ToString()}%)";
        }

        private void trbMultiplicator_ValueChanged(object sender, System.EventArgs e)
        {
            double multiplicator = 0;
            multiplicator = trbMultiplicator.Value * 0.05;

            lblValueMultiplicator.Text = multiplicator.ToString();

            if (lblValueMultiplicator.Text == "0")
                label3.Text = string.Empty;
            else
                label3.Text = $"(auto sell at {Math.Abs(decimal.Parse(lblValueTolerance.Text.ToString()) / decimal.Parse(lblValueMultiplicator.Text.ToString())).ToString()}%)";
        }
    }
}
