using Jojatekok.PoloniexAPI;
using Jojatekok.PoloniexAPI.MarketTools;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PoloniexApiSynchronisationProxy
{
    //https://poloniex.com/support/api/
    /*
     To use the trading API, you will need to create an API key.
Please note that there is a default limit of 6 calls per second. If you require more than this, please consider optimizing your application using the push API, the "moveOrder" command, or the "all" parameter where appropriate. If this is still insufficient, please contact support to discuss a limit raise.
    */
   
    public class PoloniexApiSynchronisationProxy
    {
        private const int NbMaxJobsPerSecond = 6;
        private int _nbJobsExecutedInCurrentSecond = 0;
        private readonly ConcurrentBag<PriorityJob> _priorityJobs = new ConcurrentBag<PriorityJob>();
        private readonly Timer _timer;
        private readonly Business BIZ = new Business();

        public PoloniexApiSynchronisationProxy()
        {
            //Vérifie périodiquement s'il y a des jobs a exécuter
            _timer = new Timer((_) => CheckForWaitingJobs(), null,TimeSpan.FromSeconds(0), TimeSpan.FromSeconds(1)); 
        }

        #region PoloniexApiImplementation

        public async Task<List<BalanceModel>> GetBalance()
        {
            await GetExecutionAwaiter(10); //Attendre le go pour lancer la commande a l'API

            var result = BIZ.GetBalances();

            CheckForWaitingJobs();

            return result;
        }

        public async Task<IDictionary<CurrencyPair,IMarketData>> GetSummary()
        {
            await GetExecutionAwaiter(10); 

            var result = BIZ.GetSummary();

            CheckForWaitingJobs();

            return result;
        }

        public async Task<IMarketData> GetSummary(IDictionary<CurrencyPair, IMarketData> markets, CurrencyPair currencyPair)
        {
            await GetExecutionAwaiter(10);

            var result = BIZ.GetCurrency(markets, currencyPair);

            CheckForWaitingJobs();

            return result;
        }

        public async Task<IList<Jojatekok.PoloniexAPI.TradingTools.ITrade>> GetTrades(CurrencyPair currencyPair)
        {
            await GetExecutionAwaiter(10);

            var result = BIZ.GetTrades(currencyPair);

            CheckForWaitingJobs();

            return result;
        }

        public async Task<IMarketData> GetCurrency(CurrencyPair currencyPair)
        {
            await GetExecutionAwaiter(10);

            var result = BIZ.GetCurrency(currencyPair);

            CheckForWaitingJobs();

            return result;
        }

        #endregion PoloniexApiImplementation

        /// <summary>
        /// Retourne une tâche pour attendre notre place dans la file de priorité
        /// </summary>
        /// <param name="priority"></param>
        /// <returns></returns>
        private Task GetExecutionAwaiter(int priority)
        {
            var currentJob = new PriorityJob(priority);
            _priorityJobs.Add(currentJob);

            CheckForWaitingJobs();

            return currentJob.ExecutionAwaiterTask.Task;
        }

        /// <summary>
        /// Vérifie si une tâche est en attente et la lance si le nombre de tâche dans la seconde n'est pas dépassé. 
        /// </summary>
        private void CheckForWaitingJobs()
        {
            Task.Run(() =>
            {
                if (Monitor.TryEnter(_priorityJobs)) //S'assure qu'on lance une seule job a la fois
                {
                    if (_nbJobsExecutedInCurrentSecond < NbMaxJobsPerSecond)
                        ExecuteNextJob();
                }
            });
        }

        /// <summary>
        /// Lance la prochaine tâche a exécuter selon les critaires de priorité ou autre.
        /// </summary>
        private void ExecuteNextJob()
        {
            //Ici on pourrait faire des groupeBy priority, des where, etc sur la liste _priorityJobs

            if (_priorityJobs.TryTake(out PriorityJob job))
            {
                Interlocked.Increment(ref _nbJobsExecutedInCurrentSecond);
                job.ExecutionAwaiterTask.SetResult(true); //Lance l'exécution de la tâche.
            }
        }
    }
}
