using Jojatekok.PoloniexAPI;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Configuration;

namespace GetMails
{
    class Program
    {
        static Business BIZ = new Business();
        static EnumStates lastState = EnumStates.WAITING;
        static int nbMessage = 0;
        static ulong idOrder = 0;

        static void Main(string[] args)
        {
            Console.SetWindowSize(70, 25);

            IList<UniqueId> uids = new List<UniqueId>();
            UniqueId uid;

            Console.Write("Quote currency: ");
            string quoteCurrency = Console.ReadLine();
            quoteCurrency = !string.IsNullOrEmpty(quoteCurrency) ? quoteCurrency.ToUpper() : "BTC";

            GetBalance(new CurrencyPair($"USDT_{quoteCurrency}"), true);

            /*if (lastState == EnumLastState.BOUGHT)
            {
                Process.Start("D:\\code\\Polov3\\CoinBot_Cv2\\bin\\Debug\\CoinBot_Cv2.exe",
                    string.Format(" {0} {1} {2} {3} {4}", currencyPair.BaseCurrency, currencyPair.QuoteCurrency, 0, 0, idOrder));
            }*/

            //lastState = EnumLastState.BOUGHT;
            //lastState = EnumLastState.SOLD;

            do
            {
                try
                {
                    using (var client = new ImapClient())
                    {
                        client.Connect("outlook.office365.com", 993, true);
                        client.Authenticate(ConfigurationManager.AppSettings["username"], ConfigurationManager.AppSettings["password"]);

                        var folder = client.GetFolder($"_tradingview/{quoteCurrency}usdt");
                        folder.Open(FolderAccess.ReadWrite);

                        DeleteOldMessages(folder);
                        MarkAllMessagesAsSeen(folder);

                        while (true)
                        {
                            uid = folder.Search(SearchQuery.NotSeen).LastOrDefault();

                            if (uid.IsValid)
                            {
                                GetBalance(new CurrencyPair($"USDT_{quoteCurrency}"), false);
                                System.Media.SystemSounds.Exclamation.Play();
                                nbMessage++;
                                MimeMessage message = folder.GetMessage(uid);
                                //ExecuteUpDown(message);
                                ExecuteBuySell(message);
                                DeleteOldMessages(folder);
                                MarkAllMessagesAsSeen(folder);
                            }

                            client.NoOp();
                            Thread.Sleep(5000);
                        }
                    }
                }
                catch (ImapCommandException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                Thread.Sleep(5000);

            } while (true);
        }            

        private static void DeleteOldMessages(IMailFolder folder)
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

        private static void ExecuteUpDown(MimeMessage message)
        {
            CurrencyPair currencyPair = null;

            // Enlève ceci: "TradingView Alert: "
            var valueSplit = message.Subject.Remove(0, 19).Split(',');
            currencyPair = new CurrencyPair(valueSplit[0].Trim().ToUpper());

            if (lastState == EnumStates.SOLD && message.Subject.Contains("up"))
            {
                nbMessage = 0;
                Console.WriteLine();
                Console.WriteLine("down => up");
            }
            else if (lastState == EnumStates.BOUGHT && message.Subject.Contains("down"))
            {
                nbMessage = 0;
                Console.WriteLine();
                Console.WriteLine("up => down");
            }
            else
            {
                Console.Write($"\r{nbMessage} x {DateTime.Now} - {message.Date.LocalDateTime} - {message.Subject.Remove(0, 19)}");
            }

            if (lastState == EnumStates.WAITING && message.Subject.Contains("down"))
                return;
            else if (lastState == EnumStates.WAITING && message.Subject.Contains("up"))
                lastState = EnumStates.SOLD;

            if (lastState == EnumStates.SOLD && message.Subject.Contains("up"))
            {
                lastState = EnumStates.BOUGHT;
                Buy(currencyPair);                
            }
            else if (lastState == EnumStates.BOUGHT && message.Subject.Contains("down"))
            {
                lastState = EnumStates.SOLD;
                Sell(currencyPair);                
            }
        }

        private static void ExecuteBuySell(MimeMessage message)
        {
            CurrencyPair currencyPair = null;

            // Enlève ceci: "TradingView Alert: "
            var valueSplit = message.Subject.Remove(0, 19).Split(',');
            currencyPair = new CurrencyPair(valueSplit[0].Trim().ToUpper());

            if (lastState == EnumStates.WAITING && message.Subject.Contains("sell"))
                return;
            else if (lastState == EnumStates.WAITING && message.Subject.Contains("buy"))
                lastState = EnumStates.SOLD;

            if (lastState == EnumStates.SOLD && message.Subject.Contains("buy"))
            {
                Console.WriteLine($"{DateTime.Now} - {message.Date.LocalDateTime} - {message.Subject.Remove(0, 19)}");
                lastState = EnumStates.BOUGHT;
                Buy(currencyPair);
            }
            else if (lastState == EnumStates.BOUGHT && message.Subject.Contains("sell"))
            {
                Console.WriteLine($"{DateTime.Now} - {message.Date.LocalDateTime} - {message.Subject.Remove(0, 19)}");
                lastState = EnumStates.SOLD;
                Sell(currencyPair);
            }
        }

        private static void Buy(CurrencyPair currencyPair)
        {
            Console.WriteLine($"\n{DateTime.Now} - ACHETER!!");
            idOrder = BIZ.PostBestBuyOrder(currencyPair, false).IdOrder;
            Console.WriteLine($"{DateTime.Now} - OK DONE!! (idOrder: {idOrder})\n");

            try
            {
                Process.Start($"D:\\code\\Polov3\\CoinBot_Cv2\\bin\\Debug\\CoinBot_Cv2.exe", $" {currencyPair.BaseCurrency} {currencyPair.QuoteCurrency} {0} {0} {idOrder}");
            }
            catch (Exception)
            {
                Process.Start($"C:\\bot\\CoinBot\\Application Files\\CoinBot_Cv2_1_0_0_0\\CoinBot_Cv2.exe", $" {currencyPair.BaseCurrency} {currencyPair.QuoteCurrency} {0} {0} {idOrder}");
            }
        }

        private static void Sell(CurrencyPair currencyPair)
        {
            Console.WriteLine($"\n{DateTime.Now} - VENDRE!!");
            BIZ.PostBestSellOrder(currencyPair, false, idOrder);
            Console.WriteLine($"{DateTime.Now} - OK DONE!!\n");
        }

        private static void GetBalance(CurrencyPair currencyPair, bool showBalance)
        {
            IList<BalanceModel> balances = (from x in BIZ.GetBalances() select x).ToList();

            var balanceBase = (from x in balances where x.Type == currencyPair.BaseCurrency select x.QuoteAvailable).SingleOrDefault();
            var balanceQuote = (from x in balances where x.Type == currencyPair.QuoteCurrency select x.USDT_Value).SingleOrDefault();

            if (showBalance)
            {
                Console.WriteLine($"Balance USDT    : {balanceBase} USDT");
                Console.WriteLine($"Balance {currencyPair}: {balanceQuote} USDT");
            }

            if (balanceQuote < 1)
                lastState = EnumStates.SOLD;
            else
                lastState = EnumStates.BOUGHT;

            //Console.WriteLine($"lastState: {lastState}\n");
        }
    }
}

