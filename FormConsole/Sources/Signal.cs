using Jojatekok.PoloniexAPI;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using System;
using System.Configuration;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;
using System.Threading.Tasks;

namespace FormConsole.Sources
{
    public class Signal : IDisposable
    {
        ISubject<EnumStates> _signalSubject = new Subject<EnumStates>();
        Task _signalLoop;
        CancellationTokenSource _cts = new CancellationTokenSource();

        EnumStates lastState = EnumStates.WAITING;

        public Signal(CurrencyPair currencyPair)
        {
            _signalLoop = CheckSignal(currencyPair);
        }

        public IObservable<EnumStates> DataSource
        {
            get
            {
                return _signalSubject
                    .DistinctUntilChanged()
                    .ObserveOn(System.Reactive.Concurrency.Scheduler.Default);
            }
        }

        public void Dispose()
        {
            _cts.Cancel();
        }

        private Task CheckSignal(CurrencyPair currencyPair)
        {
            UniqueId uid;

            return Task.Run(async () =>
            {
                while (!_cts.IsCancellationRequested)
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
                                //GetBalance(CurrencyPair);
                                System.Media.SystemSounds.Exclamation.Play();
                                MimeMessage message = folder.GetMessage(uid);
                                _signalSubject.OnNext(ExecuteBuySell(message, lastState));
                                //source.OnError(new Exception());
                                DeleteOldMessages(folder);
                                MarkAllMessagesAsSeen(folder);
                            }

                            client.NoOp();
                            await Task.Delay(5000);
                        }
                    }
                }

                _signalSubject.OnCompleted();
            });
        }

        public EnumStates ExecuteBuySell(MimeMessage message, EnumStates lastState)
        {
            CurrencyPair currencyPair = null;
            OrderModel order = new OrderModel();

            // Enlève ceci: "TradingView Alert: "
            var valueSplit = message.Subject.Remove(0, 19).Split(',');
            currencyPair = new CurrencyPair(valueSplit[0].Trim().ToUpper());

            if (lastState == EnumStates.WAITING && message.Subject.Contains("sell"))
                return lastState;
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

            return lastState;
        }

        private OrderModel Buy(CurrencyPair currencyPair)
        {
            OrderModel order = new OrderModel();

            Console.WriteLine($"{DateTime.Now} - ACHETER!!");
            //order = BIZ.PostBestBuyOrder(currencyPair);
            Console.WriteLine($"{DateTime.Now} - OK DONE!! (idOrder: {order.IdOrder})\n");

            //try
            //{
            //    Process.Start($"D:\\code\\Polov3\\CoinBot_Cv2\\bin\\Debug\\CoinBot_Cv2.exe", $" {currencyPair.BaseCurrency} {currencyPair.QuoteCurrency} {0} {0} {idOrder}");
            //}
            //catch (Exception)
            //{
            //    Process.Start($"C:\\bot\\CoinBot\\Application Files\\CoinBot_Cv2_1_0_0_0\\CoinBot_Cv2.exe", $" {currencyPair.BaseCurrency} {currencyPair.QuoteCurrency} {0} {0} {idOrder}");
            //}

            return order;
        }

        private OrderModel Sell(CurrencyPair currencyPair)
        {
            OrderModel order = new OrderModel();

            Console.WriteLine($"{DateTime.Now} - VENDRE!!");
            //order = BIZ.PostBestSellOrder(currencyPair, idOrder);
            Console.WriteLine($"{DateTime.Now} - OK DONE!!\n");

            return order;
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