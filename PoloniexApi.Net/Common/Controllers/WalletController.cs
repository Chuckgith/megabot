using Jojatekok.PoloniexAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jojatekok.PoloniexAPI
{
    public class WalletController
    {
        PoloniexClient client = new PoloniexClient(ApiKeys.PublicKey, ApiKeys.PrivateKey);

        public List<BalanceModel> GetBalances()
        {
            var balances = client.Wallet.GetCompleteBalances();

            var walletList = new List<BalanceModel>();

            // Le market est hardcodé car Poloniex ne fournie pas la valeur en USD/USDT, il fournie seulement la valeur en USDT_BTC
            MarketController MC = new MarketController();
            var usdt_btc = (MC.GetMarket(new CurrencyPair("USDT_BTC")).PriceLast);

            foreach (var balance in balances)
            {
                walletList.Add(new BalanceModel()
                {
                    Type = balance.Key,
                    QuoteAvailable = balance.Value.QuoteAvailable,
                    QuoteOnOrders = balance.Value.QuoteOnOrders,
                    USDT_Value = usdt_btc * balance.Value.BitcoinValue
                });
            }

            return (from x in walletList where x.QuoteAvailable > 0 || x.QuoteOnOrders > 0  select x).ToList();
        }
    }
}
