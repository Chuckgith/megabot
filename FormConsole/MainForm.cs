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
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormConsole
{
    public partial class MainForm : Form
    {
        const string CURRENCY_USDT = "USDT";
        const double TOLERANCE_PROFIT_PRICEPAID = -0.5;  // ex: -0.5 = -0.5%
        const double TOLERANCE_PROFIT_HIGHDIFF = -1;   // -1 => 5%, -1.5 => 7.5%, -2 => 10%
        const double LOSS_TOLERANCE_MULTIPLICATOR = 0.2;

        Business BIZ = new Business();
        EnumStates lastState = EnumStates.WAITING;
        ulong idOrder = 0;

        ISubject<OrderModel> source = new Subject<OrderModel>();
        IDisposable subscription;
        ISubject<TickerModel> source2 = new Subject<TickerModel>();
        IDisposable subscription2;

        Task checkSignal;
        Task getTicker;

        private CurrencyPair CurrencyPair
        {
            get
            {
                //return new CurrencyPair(tabsMarkets.SelectedTab.Text, cbbCoins.SelectedText);
                return new CurrencyPair(cbbCoins.SelectedItem.ToString());
            }
        }

        public MainForm()
        {
            InitializeComponent();
            FillCbbCoins();

            cbbCoins.SelectedIndex = cbbCoins.FindStringExact("usdt_btc");

            CurrencyPair currencyPair = new CurrencyPair(cbbCoins.SelectedItem.ToString());
            GetBalance(currencyPair, true);

            CheckSignal(currencyPair);

            subscription = source
                .ObserveOn(WindowsFormsSynchronizationContext.Current)
                .Subscribe(x => txtBot.AppendText(x.IdOrder + Environment.NewLine));
        }

        private void FillCbbCoins()
        {
            cbbCoins.Items.AddRange(BIZ.GetMarket(tabsMarkets.SelectedTab.Text).ToArray());
        }

        private void CheckSignal(CurrencyPair currencyPair)
        {
            UniqueId uid;

            checkSignal = Task.Run(async () =>
            {
                do
                {
                    try
                    {
                        using (var client = new ImapClient())
                        {
                            client.Connect("outlook.office365.com", 993, true);
                            client.Authenticate(ConfigurationManager.AppSettings["username"], ConfigurationManager.AppSettings["password"]);

                            var folder = client.GetFolder($"_tradingview/{currencyPair.QuoteCurrency}usdt");
                            folder.Open(FolderAccess.ReadWrite);

                            DeleteOldMessages(folder);
                            MarkAllMessagesAsSeen(folder);

                            while (true)
                            {
                                uid = folder.Search(SearchQuery.NotSeen).LastOrDefault();

                                if (uid.IsValid)
                                {
                                    GetBalance(new CurrencyPair($"USDT_{currencyPair.QuoteCurrency}"), false);
                                    System.Media.SystemSounds.Exclamation.Play();
                                    MimeMessage message = folder.GetMessage(uid);
                                    source.OnNext(Signal.ExecuteBuySell(message, lastState));
                                    //source.OnError(new Exception());
                                    DeleteOldMessages(folder);
                                    MarkAllMessagesAsSeen(folder);
                                }

                                client.NoOp();
                                await Task.Delay(5000);
                            }
                        }
                    }
                    catch (ImapCommandException ex)
                    {
                        txtBot.AppendText(ex.Message + Environment.NewLine);
                    }
                    catch (IOException ex)
                    {
                        txtBot.AppendText(ex.Message + Environment.NewLine);
                    }
                    catch (Exception ex)
                    {
                        txtBot.AppendText(ex.Message + Environment.NewLine);
                    }

                    await Task.Delay(5000);

                } while (true);
            });
        }

        private void GetTicker(string baseCurrency, string quoteCurrency, double amountToTrade, double pricePaid, ulong idOrder = 0)
        {
            IDictionary<CurrencyPair, IMarketData> markets;
            IMarketData marketToTrade = null;
            IMarketData usdtMarket = null;

            lastState = EnumStates.BOUGHT;

            double previousProfit = -1;
            double profit = 0;
            double highestProfit = 0;
            double highestProfitDiff = 0;
            double highestPrice = 0;
            double baseCurrencyTotal = 0;
            double usdTotalValue = 0;
            double lossTolerance = 0;

            var currencyPair = new CurrencyPair(baseCurrency, quoteCurrency);
            var currencyPairUsdt = new CurrencyPair(CURRENCY_USDT, baseCurrency);

            double baseCurrencyUnitPrice = 0;

            // Aller chercher le marché une 1ère fois en dehors du while pour figer dans le temps les données de départ
            markets = BIZ.GetSummary();
            marketToTrade = BIZ.GetCurrency(markets, currencyPair);

            if (idOrder != 0)
            {
                // Aller chercher les vraies chiffres
                amountToTrade = (from x in BIZ.GetBalances() where x.Type == currencyPair.QuoteCurrency select x.USDT_Value).SingleOrDefault();

                pricePaid = BIZ.GetTrades(currencyPair).Where(x => x.IdOrder == idOrder).FirstOrDefault().PricePerCoin;
            }
            else
            {
                // Si le prix payé n'a pas été défini par l'utilisateur, prendre le prix courant
                if (pricePaid == 0)
                    pricePaid = marketToTrade.PriceLast;
            }

            // Enlève un pourcentage du montant à transiger si le prix payé était plus haut que le prix courant
            amountToTrade = amountToTrade + (marketToTrade.PriceLast / pricePaid) * 100 - 100;

            // Identifier l'unité de base de la monnaie à marchander
            if (baseCurrency == CURRENCY_USDT)
            {
                baseCurrencyUnitPrice = amountToTrade / marketToTrade.PriceLast;
            }
            else
            {
                usdtMarket = BIZ.GetCurrency(markets, currencyPairUsdt);
                baseCurrencyUnitPrice = (amountToTrade / usdtMarket.PriceLast) / marketToTrade.PriceLast;
            }

            TickerModel ticker;

            getTicker = Task.Run(async () =>
            {
                try
                {
                    while (lastState == EnumStates.BOUGHT)
                    {
                        marketToTrade = BIZ.GetCurrency(currencyPair);

                        profit = (marketToTrade.PriceLast / pricePaid) * 100 - 100;
                        highestProfit = profit > highestProfit ? profit : highestProfit;
                        lossTolerance = TOLERANCE_PROFIT_HIGHDIFF + (highestProfit * LOSS_TOLERANCE_MULTIPLICATOR);

                        // Évite d'afficher les données si rien n'a changé
                        if (Math.Round(previousProfit, 4) != Math.Round(profit, 4))
                        {
                            previousProfit = profit;
                            highestPrice = marketToTrade.PriceLast > highestPrice ? marketToTrade.PriceLast : highestPrice;
                            highestProfitDiff = (marketToTrade.PriceLast / highestPrice) * 100 - 100;
                            baseCurrencyTotal = marketToTrade.PriceLast * baseCurrencyUnitPrice;
                            usdTotalValue = baseCurrencyTotal * (baseCurrency == CURRENCY_USDT ? 1 : usdtMarket.PriceLast);

                            ticker = new TickerModel()
                            {
                                currencyPair = currencyPair,
                                amountToTrade = amountToTrade,
                                pricePaid = pricePaid,
                                priceLast = marketToTrade.PriceLast,
                                highestPrice = highestPrice,
                                profit = profit,
                                higuestProfit = highestProfit,
                                highestProfitDiff = highestProfitDiff,
                                lossTolerance = lossTolerance,
                                baseCurrencyTotal = baseCurrencyTotal,
                                usdTotalValue = usdTotalValue,
                                time = DateTime.Now
                            };

                            //source2.OnNext(Ticker.Display(ticker));
                            source2.OnNext(ticker);
                            //CheckTolerance(profit, highestProfit, highestProfitDiff, lossTolerance, marketToTrade, pricePaid, currencyPair, idOrder);
                        }

                        await Task.Delay(5000);
                    }
                }
                catch (Exception ex)
                {
                    txtTicker.AppendText(ex.Message + Environment.NewLine);
                }
            });          
        }

        private void btnStartBot_Click(object sender, EventArgs e)
        {
            CurrencyPair currencyPair = new CurrencyPair(cbbCoins.SelectedItem.ToString());
            GetTicker(currencyPair.BaseCurrency, currencyPair.QuoteCurrency, 20, 0);

            subscription2 = source2
                .ObserveOn(WindowsFormsSynchronizationContext.Current)
                //.Subscribe(x => txtTicker.AppendText(x + Environment.NewLine));
                .Subscribe(x => AddTrades(x));

            dgTrades.Columns[5].DefaultCellStyle.Format = "N4";
            dgTrades.Columns[6].DefaultCellStyle.Format = "N4";
            dgTrades.Columns[7].DefaultCellStyle.Format = "N4";
            dgTrades.Columns[8].DefaultCellStyle.Format = "N4";
            dgTrades.Columns[9].DefaultCellStyle.Format = "C";
            dgTrades.Columns[10].DefaultCellStyle.Format = "C";
        }

        List<TickerModel> trades = new List<TickerModel>();

        private void AddTrades(TickerModel ticker)
        {
            trades.Add(ticker);

            dgTrades.DataSource = new List<TickerModel> { ticker };

            foreach (DataGridViewRow row in dgTrades.Rows)
            {
                if (ticker.profit >= 0)                
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                else
                    row.DefaultCellStyle.BackColor = Color.LightPink;
            }
        }

        private void GetBalance(CurrencyPair currencyPair, bool showBalance)
        {
            IList<BalanceModel> balances = null;

            for (int attempts = 0; attempts < 5; attempts++)
            {
                try
                {
                    balances = (from x in BIZ.GetBalances() select x).ToList();
                    break;
                }
                catch (Exception ex)
                {
                    txtBot.AppendText($"{DateTime.Now} - {ex.Message}\n");
                }
                Thread.Sleep(1000);
            }

            var balanceBase = (from x in balances where x.Type == currencyPair.BaseCurrency select x.QuoteAvailable).SingleOrDefault();
            var balanceQuote = (from x in balances where x.Type == currencyPair.QuoteCurrency select x.USDT_Value).SingleOrDefault();

            if (showBalance)
            {
                txtBot.AppendText($"Balance USDT    : {balanceBase} USDT\n");
                txtBot.AppendText($"Balance {currencyPair}: {balanceQuote} USDT\n");
            }

            if (balanceQuote < 1)
                lastState = EnumStates.SOLD;
            else
                lastState = EnumStates.BOUGHT;

            //Console.WriteLine($"lastState: {lastState}\n");
        }

        private void DeleteOldMessages(IMailFolder folder)
        {
            var uids = (from p in folder.Search(SearchQuery.All) orderby p.Id descending select p).Skip(50).ToList();

            if (uids.Any())
                folder.AddFlags(uids, MessageFlags.Deleted, true);
        }

        private static void MarkAllMessagesAsSeen(IMailFolder folder)
        {
            var uids = folder.Search(SearchQuery.NotSeen);

            if (uids.Any())
                folder.AddFlags(uids, MessageFlags.Seen, true);
        }
    }
}
