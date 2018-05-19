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

            lbCoins.SelectedIndex = lbCoins.FindStringExact("usdt_btc");

            BotLosstolerance = "-1";
            BotMultiplicator = "0.2";

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
            TradeModel bot = new TradeModel()
            {
                CurrencyPair = CurrencyPair,
                Status = EnumStatus.WAITING,
                Amount = GetBotAmount(),
                LossTolerance = double.Parse(Utilities.TryParseDouble(BotLosstolerance).ToString()),
                LossToleranceMultiplicator = double.Parse(Utilities.TryParseDouble(BotMultiplicator).ToString())               
            };

            AddBot(bot);
        }

        private void AddBot(TradeModel bot)
        {
            if (!_blTrades.Select(x => x.CurrencyPair).Contains(bot.CurrencyPair))
            {
                FlatTradeModel flatBot = new FlatTradeModel()
                {
                    CurrencyPair = bot.CurrencyPair,
                    Status = bot.Status,
                    Amount = bot.Amount.ToString(),
                    LossTolerance = bot.LossTolerance.ToString(),
                    LossToleranceMultiplicator = bot.LossToleranceMultiplicator.ToString()
                };

                _blTrades.Add(flatBot);
                _bsTrades = new BindingSource(_blTrades, null);
                dgvCurrentTrades.DataSource = _bsTrades;

                //UpdateTrades(bot);

                _signal = new Signal(bot.CurrencyPair);
                _subsSignals.Add(bot.CurrencyPair, _signal.DataSource
                    .ObserveOn(WindowsFormsSynchronizationContext.Current)
                    .Subscribe(x => AnalyseSignal(bot, x)));
            }
            else
                txtLogs.AppendText($"Bot {bot.CurrencyPair} => Already running{Environment.NewLine}");
        }

        private void AnalyseSignal(TradeModel bot, SignalModel signal)
        {
            if (signal.OrderType == OrderType.Buy)
            {
                if (bot.Status == EnumStatus.WAITING)
                    PerformBuy(bot);
                else if (bot.Status == EnumStatus.BOUGHT)
                    txtLogs.AppendText($"{DateTime.Now} - {signal.CurrencyPair} => BUY - Already bought{Environment.NewLine}");
            }
            else if (signal.OrderType == OrderType.Sell)
            {
                if (bot.Status == EnumStatus.BOUGHT)
                    PerformSell(bot, true);
                else if (bot.Status == EnumStatus.WAITING)
                    txtLogs.AppendText($"{DateTime.Now} - {signal.CurrencyPair} => SELL - Already sold{Environment.NewLine}");
            }
        }

        private void PerformBuy(TradeModel bot)
        {
            OrderModel order = null;
            var stopwatch = new Stopwatch();
            long elapsedTime = 0;

            txtLogs.AppendText($"{DateTime.Now} - {bot.CurrencyPair} => BUY ...{Environment.NewLine}");
            bot.Status = EnumStatus.BUYING;
            //UpdateTrades(bot);

            stopwatch.Start();
            order = ExecuteOrder.ExecuteBuySell(OrderType.Buy, bot.CurrencyPair, bot.Amount);
            stopwatch.Stop();
            elapsedTime = stopwatch.ElapsedMilliseconds;

            txtLogs.AppendText($"{DateTime.Now} - {bot.CurrencyPair} => OK BOUGHT ({elapsedTime / 1000} secs){Environment.NewLine}");
            bot.Status = EnumStatus.BOUGHT;
            //UpdateTrades(bot);

            bot.PricePaid = order.PricePerCoin;
            bot.ToleranceProfitHighDiff = bot.LossTolerance;

            _ticker = new Ticker(bot.CurrencyPair, bot.Amount, bot.PricePaid, 0);
            _subsTickers.Add(bot.CurrencyPair, (_ticker.DataSource
                .ObserveOn(WindowsFormsSynchronizationContext.Current)
                .Subscribe(x => UpdateTrades(bot, x))));
        }

        private void PerformSell(TradeModel bot, bool fromSignal)
        {
            OrderModel order = null;
            var stopwatch = new Stopwatch();
            long elapsedTime = 0;

            txtLogs.AppendText($"{DateTime.Now} - {bot.CurrencyPair} => SELL {(fromSignal ? "(signal)" : "(tol)")} ...{Environment.NewLine}");
            bot.Status = EnumStatus.SELLING;
            //UpdateTrades(bot);

            stopwatch.Start();
            order = ExecuteOrder.ExecuteBuySell(OrderType.Sell, bot.CurrencyPair, bot.Amount);
            stopwatch.Stop();
            elapsedTime = stopwatch.ElapsedMilliseconds;

            txtLogs.AppendText($"{DateTime.Now} - {bot.CurrencyPair} => OK SOLD ({elapsedTime / 1000} secs){Environment.NewLine}");
            bot.Status = EnumStatus.SOLD;

            DisposeSubscribeTicker(bot);

            AddClosedTrade(bot);

            bot.Status = EnumStatus.WAITING;
            UpdateTrades(bot);
        }


        private void UpdateTrades(TradeModel bot, TickerModel ticker = null)
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
                        DataGridHelper.SetCell(row.Cells, "PricePaid", string.Format("{0:0.00000000}", bot.PricePaid));
                        //DataGridHelper.SetCell(row.Cells, "LossTolerance", bot.LossTolerance);
                        DataGridHelper.SetCell(row.Cells, "UsdtValue", string.Format("{0:0.00}", bot.Ticker.UsdtValue));
                        DataGridHelper.SetCell(row.Cells, "PriceLast", string.Format("{0:0.00000000}", bot.Ticker.PriceLast));
                        DataGridHelper.SetCell(row.Cells, "Profit", string.Format("{0:0.0000}", bot.Ticker.Profit));
                        DataGridHelper.SetCell(row.Cells, "HighestProfit", string.Format("{0:0.0000}", bot.Ticker.HighestProfit));
                        DataGridHelper.SetCell(row.Cells, "HighestProfitDiff", bot.Ticker.HighestProfitDiff == 0 ? "NEW HIGH" : string.Format("{0:0.0000}", bot.Ticker.HighestProfitDiff));
                        DataGridHelper.SetCell(row.Cells, "ToleranceProfitHighDiff", string.Format("{0:0.00}", bot.ToleranceProfitHighDiff));                        
                        DataGridHelper.SetCell(row.Cells, "LastTicker", $"{DateTime.Now:dd/MM HH:mm:ss}");
                    }
                    else
                    {
                        DataGridHelper.SetCell(row.Cells, "PricePaid", string.Empty);
                        DataGridHelper.SetCell(row.Cells, "UsdtValue", string.Empty);
                        DataGridHelper.SetCell(row.Cells, "PriceLast", string.Empty);
                        DataGridHelper.SetCell(row.Cells, "Profit", string.Empty);
                        DataGridHelper.SetCell(row.Cells, "HighestProfit", string.Empty);
                        DataGridHelper.SetCell(row.Cells, "HighestProfitDiff", string.Empty);
                        DataGridHelper.SetCell(row.Cells, "ToleranceProfitHighDiff", string.Empty);                        
                        DataGridHelper.SetCell(row.Cells, "LastTicker", string.Empty);
                    }

                    SetColor(bot, row);
                }
            }

            if (CheckTolerance(bot, ticker))
            {
                PerformSell(bot, false);
            }

            CalculTotalGain();
        }

        private void CalculTotalGain()
        {
            double total = 0;

            foreach (DataGridViewRow row in dgvCurrentTrades.Rows)
            {
                if (!string.IsNullOrEmpty(DataGridHelper.GetCell(row.Cells, "Profit").ToString()))
                    total = total + double.Parse(DataGridHelper.GetCell(row.Cells, "Profit").ToString());
            }

            foreach (DataGridViewRow row in dgvClosedTrades.Rows)
            {
                if (!string.IsNullOrEmpty(DataGridHelper.GetCell(row.Cells, "Profit").ToString()))
                    total = total + double.Parse(DataGridHelper.GetCell(row.Cells, "Profit").ToString());
            }

            Total.Text = total.ToString();
        }

        private void AddClosedTrade(TradeModel bot)
        {
            FlatTradeModel botClosed = new FlatTradeModel()
            {
                CurrencyPair = bot.CurrencyPair,
                Status = bot.Status,
                Amount = bot.Amount.ToString(),
                LossTolerance = bot.LossTolerance.ToString(),
                LossToleranceMultiplicator = bot.LossToleranceMultiplicator.ToString(),
                PricePaid = string.Format("{0:0.00000000}", bot.PricePaid),
                UsdtValue = string.Format("{0:0.00}", bot.Ticker.UsdtValue),
                PriceLast = string.Format("{0:0.00000000}", bot.Ticker.PriceLast),
                Profit = string.Format("{0:0.0000}", bot.Ticker.Profit),
                HighestProfit = string.Format("{0:0.0000}", bot.Ticker.HighestProfit),
                HighestProfitDiff = string.Format("{0:0.0000}", bot.Ticker.HighestProfitDiff == 0 ? "NEW HIGH" : string.Format("{0:0.0000}", bot.Ticker.HighestProfitDiff)),
                ToleranceProfitHighDiff = string.Format("{0:0.00}", bot.ToleranceProfitHighDiff),
                LastTicker = $"{bot.Ticker.LastTicker:dd/MM HH:mm:ss}"
            };

            _blClosedTrades.Add(botClosed);
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

        private void SetColor(TradeModel bot, DataGridViewRow row)
        {
            if (bot.Ticker != null)
            {
                if (bot.Ticker.Profit >= 5)
                    row.DefaultCellStyle.BackColor = Color.MediumPurple;
                else if (bot.Ticker.Profit >= 1)
                    row.DefaultCellStyle.BackColor = Color.Lime;
                else if (bot.Ticker.Profit >= 0)
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                else
                    row.DefaultCellStyle.BackColor = Color.LightPink;
            }
            else
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }
        }

        private bool CheckTolerance(TradeModel bot, TickerModel ticker)
        {
            if (ticker == null)
                return false;

            bot.ToleranceProfitHighDiff = bot.LossTolerance + (ticker.HighestProfit * bot.LossToleranceMultiplicator);

            bot.ToleranceProfitHighDiff = bot.ToleranceProfitHighDiff > 0 ? 0 : bot.ToleranceProfitHighDiff;

            if (//ticker.HighestProfitDiff < -0.3 &&
                ticker.HighestProfitDiff < bot.ToleranceProfitHighDiff)
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
            gbTrade.Text = $"Trade {CurrencyPair.QuoteCurrency}";
            
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

        private void DisposeSubscribeTicker(TradeModel bot)
        {
            if (_subsTickers.TryGetValue(bot.CurrencyPair, out IDisposable subscribe))
            {
                _subsTickers.Remove(bot.CurrencyPair);
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
    }
}
