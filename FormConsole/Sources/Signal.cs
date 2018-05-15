using Jojatekok.PoloniexAPI;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;
using System.Threading.Tasks;

namespace FormConsole.Sources
{
    public class Signal : IDisposable
    {
        ISubject<SignalModel> _signalSubject = new Subject<SignalModel>();
        Task _signalLoop;
        CancellationTokenSource _cts = new CancellationTokenSource();

        EnumStatus lastState = EnumStatus.WAITING;

        public Signal(CurrencyPair currencyPair)
        {
            _signalLoop = GetSignal(currencyPair);
        }

        public IObservable<SignalModel> DataSource
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

        private Task GetSignal(CurrencyPair currencyPair)
        {
            UniqueId uid;

            return Task.Run(async () =>
            {
                while (!_cts.IsCancellationRequested)
                {                    
                    using (var client = new ImapClient())
                    {
                        try
                        {
                            client.Connect("outlook.office365.com", 993, true);
                            client.Authenticate(ConfigurationManager.AppSettings["username"], ConfigurationManager.AppSettings["password"]);

                            var folder = client.GetFolder("_tradingview").GetSubfolder($"{currencyPair.QuoteCurrency}usdt");
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
                                    _signalSubject.OnNext(GetLastState(message, lastState));
                                    DeleteOldMessages(folder);
                                    MarkAllMessagesAsSeen(folder);
                                }

                                client.NoOp();
                                await Task.Delay(5000);
                            }
                        }
                        // erreurs connues: 
                        catch (IOException ex)
                        {
                            Debug.WriteLine($"{DateTime.Now} - GetSignal() - {ex.Message}");
                        }
                        catch (FolderNotFoundException ex)
                        {
                            _cts.Cancel();
                            Debug.WriteLine($"{DateTime.Now} - GetSignal() - {ex.Message}");
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"{DateTime.Now} - GetSignal() - {ex.Message}");
                        }
                        finally
                        {
                            client.Disconnect(true);
                            client.Dispose();
                        }
                    }                    
                }

                _signalSubject.OnCompleted();
            });
        }

        public SignalModel GetLastState(MimeMessage message, EnumStatus status)
        {
            CurrencyPair currencyPair = null;

            // Enlève ceci: "TradingView Alert: "
            var valueSplit = message.Subject.Remove(0, 19).Split(',');
            currencyPair = new CurrencyPair(valueSplit[0].Trim().ToUpper());

            OrderType orderType = new OrderType();

            if (message.Subject.Contains("buy"))
                orderType = OrderType.Buy;
            else if (message.Subject.Contains("sell"))
                orderType = OrderType.Sell;

            return new SignalModel()
            {
                CurrencyPair = currencyPair,
                OrderType = orderType
            };

            //if (status == EnumStatus.SOLD && message.Subject.Contains("buy"))
            //{
            //    Console.WriteLine($"{DateTime.Now} - {message.Date.LocalDateTime} - {message.Subject.Remove(0, 19)}");
            //    status = EnumStatus.BOUGHT;
            //}
            //else if (status == EnumStatus.BOUGHT && message.Subject.Contains("sell"))
            //{
            //    Console.WriteLine($"{DateTime.Now} - {message.Date.LocalDateTime} - {message.Subject.Remove(0, 19)}");
            //    status = EnumStatus.SOLD;
            //}
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