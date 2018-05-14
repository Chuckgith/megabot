using Jojatekok.PoloniexAPI;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;
using System.Threading.Tasks;

namespace FormConsole.Sources
{
    public class Signal : IDisposable
    {
        ISubject<EnumStatus> _signalSubject = new Subject<EnumStatus>();
        Task _signalLoop;
        CancellationTokenSource _cts = new CancellationTokenSource();

        EnumStatus lastState = EnumStatus.WAITING;

        public Signal(CurrencyPair currencyPair)
        {
            _signalLoop = GetSignal(currencyPair);
        }

        public IObservable<EnumStatus> DataSource
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
                    }
                    catch (FolderNotFoundException ex)
                    {
                        _cts.Cancel();
                        Debug.WriteLine($"{DateTime.Now} - GetSignal() - {ex}");
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"{DateTime.Now} - GetSignal() - {ex}");
                    }
                }

                _signalSubject.OnCompleted();
            });
        }

        public EnumStatus GetLastState(MimeMessage message, EnumStatus status)
        {
            CurrencyPair currencyPair = null;
            OrderModel order = new OrderModel();

            // Enlève ceci: "TradingView Alert: "
            var valueSplit = message.Subject.Remove(0, 19).Split(',');
            currencyPair = new CurrencyPair(valueSplit[0].Trim().ToUpper());

            if (status == EnumStatus.WAITING && message.Subject.Contains("sell"))
                return status;
            else if (status == EnumStatus.WAITING && message.Subject.Contains("buy"))
                status = EnumStatus.SOLD;

            if (status == EnumStatus.SOLD && message.Subject.Contains("buy"))
            {
                Console.WriteLine($"{DateTime.Now} - {message.Date.LocalDateTime} - {message.Subject.Remove(0, 19)}");
                status = EnumStatus.BOUGHT;
            }
            else if (status == EnumStatus.BOUGHT && message.Subject.Contains("sell"))
            {
                Console.WriteLine($"{DateTime.Now} - {message.Date.LocalDateTime} - {message.Subject.Remove(0, 19)}");
                status = EnumStatus.SOLD;
            }

            return status;
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