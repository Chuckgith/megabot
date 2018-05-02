using Jojatekok.PoloniexAPI;
using System;
using System.Collections.Generic;
using System.Reactive.Subjects;
using System.Threading.Tasks;
using System.Linq;
using System.Threading;
using System.Reactive.Linq;
using Jojatekok.PoloniexAPI.MarketTools;

namespace FormConsole.Sources
{
    public class Ticker : IDisposable
    {
        ISubject<TickerModel> _tickerSubject = new Subject<TickerModel>();
        Task _tickerLoop;
        CancellationTokenSource _cts = new CancellationTokenSource();

        const string CURRENCY_USDT = "USDT";
        const double TOLERANCE_PROFIT_PRICEPAID = -0.5;  // ex: -0.5 = -0.5%
        const double TOLERANCE_PROFIT_HIGHDIFF = -1;   // -1 => 5%, -1.5 => 7.5%, -2 => 10%
        const double LOSS_TOLERANCE_MULTIPLICATOR = 0.2;

        Business BIZ = new Business();
        EnumStates lastState = EnumStates.WAITING;

        public Ticker(CurrencyPair currencyPair, double amountToTrade, double pricePaid, ulong idOrder = 0)
        {
            _tickerLoop = GetTicker(currencyPair, amountToTrade, pricePaid, idOrder);
        }

        public IObservable<TickerModel> DataSource
        {
            get
            {
                //Ici chaque personne qui va s'abonner à cette observable va bénéficier des filtres Linq 
                //que tu vas avoir mis. Tu pourrais par exemple mettre des where data != null etc.

                return _tickerSubject
                    .DistinctUntilChanged() //Lève des évènements seulement si la donnée a changée
                    .ObserveOn(System.Reactive.Concurrency.Scheduler.Default); //Chaque abonnement (subscribe) se fait sur un Task différente ce qui donne un indépendance total entre chaque souscription
            }
        }

        public void Dispose()
        {
            _cts.Cancel();
        }

        private Task GetTicker(CurrencyPair currencyPair, double amountToTrade, double pricePaid, ulong idOrder = 0)
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

            var currencyPairUsdt = new CurrencyPair(CURRENCY_USDT, currencyPair.BaseCurrency);

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
            if (currencyPair.BaseCurrency == CURRENCY_USDT)
            {
                baseCurrencyUnitPrice = amountToTrade / marketToTrade.PriceLast;
            }
            else
            {
                usdtMarket = BIZ.GetCurrency(markets, currencyPairUsdt);
                baseCurrencyUnitPrice = (amountToTrade / usdtMarket.PriceLast) / marketToTrade.PriceLast;
            }

            TickerModel ticker;

            return Task.Run(async () =>
            {
                while (!_cts.IsCancellationRequested)
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
                        usdTotalValue = baseCurrencyTotal * (currencyPair.BaseCurrency == CURRENCY_USDT ? 1 : usdtMarket.PriceLast);

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

                        _tickerSubject.OnNext(ticker);
                        //CheckTolerance(profit, highestProfit, highestProfitDiff, lossTolerance, marketToTrade, pricePaid, currencyPair, idOrder);
                    }

                    await Task.Delay(5000);
                }

                _tickerSubject.OnCompleted();
            });
        }
    }
}