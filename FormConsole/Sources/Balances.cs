using Jojatekok.PoloniexAPI;
using System;
using System.Collections.Generic;
using System.Reactive.Subjects;
using System.Threading.Tasks;
using System.Linq;
using System.Threading;
using System.Reactive.Linq;
using System.Diagnostics;
using System.Net;

namespace FormConsole.Sources
{
    public class Balances : IDisposable
    {
        ISubject<IList<BalanceModel>> _balancesSubject = new Subject<IList<BalanceModel>>();
        Task _balancesLoop;
        CancellationTokenSource _cts = new CancellationTokenSource();

        Business BIZ = new Business();
        string _baseCurrency = string.Empty;

        public Balances(string baseCurrency)
        {
            _baseCurrency = baseCurrency;
            _balancesLoop = GetBalances(baseCurrency);
        }

        public IObservable<IList<BalanceModel>> DataSource
        {
            get
            {
                //Ici chaque personne qui va s'abonner à cette observable va bénéficier des filtres Linq 
                //que tu vas avoir mis. Tu pourrais par exemple mettre des where data != null etc.

                return _balancesSubject
                    //.Buffer(TimeSpan.FromSeconds(120), 1)
                    //.Select(x =>
                    //{
                    //    if (!x.Any())
                    //    {
                    //        GetBalances(_baseCurrency);
                    //        return null;
                    //    }
                    //    return x.First();
                    //})
                    //.Where(x => x != null)
                    .DistinctUntilChanged()
                    .ObserveOn(System.Reactive.Concurrency.Scheduler.Default); 
                //Chaque abonnement (subscribe) se fait sur un Task différente ce qui donne un indépendance total entre chaque souscription
            }
        }

        public void Dispose()
        {
            _cts.Cancel();
        }

        private Task GetBalances(string baseCurrency)
        {
            return Task.Run(async () =>
            {
                while (!_cts.IsCancellationRequested)
                {
                    try
                    {
                        IList<BalanceModel> balances = (from x in BIZ.GetBalances() select x).ToList();
                        _balancesSubject.OnNext(balances);
                        await Task.Delay(10000);
                    }
                    // erreurs connues: 502, 520
                    catch (WebException ex)
                    {
                        Debug.WriteLine($"{DateTime.Now} - GetBalances() - {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"{DateTime.Now} - GetBalances() - {ex.Message}");
                    }
                }

                _balancesSubject.OnCompleted();
            });
        }
    }
}