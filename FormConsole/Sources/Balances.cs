using Jojatekok.PoloniexAPI;
using System;
using System.Collections.Generic;
using System.Reactive.Subjects;
using System.Threading.Tasks;
using System.Linq;
using System.Threading;
using System.Reactive.Linq;

namespace FormConsole.Sources
{
    public class Balances : IDisposable
    {
        ISubject<IList<BalanceModel>> _balancesSubject = new Subject<IList<BalanceModel>>();
        Task _balancesLoop;
        CancellationTokenSource _cts = new CancellationTokenSource();

        public Balances(string baseCurrency)
        {
            _balancesLoop = GetBalances(baseCurrency);
        }

        public IObservable<IList<BalanceModel>> DataSource
        {
            get
            {
                //Ici chaque personne qui va s'abonner à cette observable va bénéficier des filtres Linq 
                //que tu vas avoir mis. Tu pourrais par exemple mettre des where data != null etc.

                return _balancesSubject
                         .DistinctUntilChanged() //Lève des évènements seulement si la donnée a changée
                         .ObserveOn(System.Reactive.Concurrency.Scheduler.Default); //Chaque abonnement (subscribe) se fait sur un Task différente ce qui donne un indépendance total entre chaque souscription
            }
        }

        public void Dispose()
        {
            _cts.Cancel();
        }

        private Task GetBalances(string baseCurrency)
        {
            Business BIZ = new Business();
            return Task.Run(async () =>
            {
                while (!_cts.IsCancellationRequested)
                {
                    try
                    {
                        IList<BalanceModel> balances = (from x in BIZ.GetBalances() select x).ToList();
                        _balancesSubject.OnNext(balances);
                        await Task.Delay(5000);
                    }
                    catch (Exception ex)
                    {
                        _balancesSubject.OnError(ex);
                    }
                }

                _balancesSubject.OnCompleted();
            });
        }
    }
}