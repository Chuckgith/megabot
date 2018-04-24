using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Jojatekok.PoloniexAPI.WalletTools
{
    public class Wallet : IWallet
    {
        private ApiWebClient ApiWebClient { get; set; }

        internal Wallet(ApiWebClient apiWebClient)
        {
            ApiWebClient = apiWebClient;
        }

        public Task<IDictionary<string, IBalance>> GetBalancesAsync()
        {
            var result = Task.Factory.StartNew(() => GetBalances());
       
            return result;
        }
        public IDictionary<string, IBalance> GetBalances()
        {
            //var postData = new Dictionary<string, object>();
            //var data = PostData<IDictionary<string, IBalance>>("returnCompleteBalances", postData);
            //return data;

            for (int attempts = 0; attempts < 5; attempts++)
            {
                try
                {
                    var postData = new Dictionary<string, object>();
                    var data = PostData<IDictionary<string, Balance>>("returnCompleteBalances", postData);
                    var returnData = new Dictionary<string, IBalance>();
                    foreach (string key in data.Keys)
                    {
                        returnData.Add(key, data[key]);
                    }

                    return returnData;
                }
                catch (WebException ex)
                {
                    Debug.WriteLine($"{DateTime.Now} {ex.Message}");
                }
                Thread.Sleep(5000);
            }
            throw new Exception("erreur 500");
        }

        public Task<IDictionary<string, string>> GetDepositAddressesAsync()
        {
            return Task.Factory.StartNew(() => GetDepositAddresses());
        }
        public IDictionary<string, string> GetDepositAddresses()
        {
            var postData = new Dictionary<string, object>();

            var data = PostData<IDictionary<string, string>>("returnDepositAddresses", postData);
            return data;
        }

        public Task<IDepositWithdrawalList> GetDepositsAndWithdrawalsAsync(DateTime startTime, DateTime endTime)
        {
            return Task.Factory.StartNew(() => GetDepositsAndWithdrawals(startTime, endTime));
        }
        public IDepositWithdrawalList GetDepositsAndWithdrawals(DateTime startTime, DateTime endTime)
        {
            var postData = new Dictionary<string, object> {
                { "start", Helper.DateTimeToUnixTimeStamp(startTime) },
                { "end", Helper.DateTimeToUnixTimeStamp(endTime) }
            };

            var data = PostData<DepositWithdrawalList>("returnDepositsWithdrawals", postData);
            return data;
        }

        public Task<IDepositWithdrawalList> GetDepositsAndWithdrawalsAsync()
        {
            return Task.Factory.StartNew(() => GetDepositsAndWithdrawals(Helper.DateTimeUnixEpochStart, DateTime.MaxValue));
        }

        public Task<IGeneratedDepositAddress> PostGenerateNewDepositAddressAsync(string currency)
        {
            return Task.Factory.StartNew(() => PostGenerateNewDepositAddress(currency));
        }
        public IGeneratedDepositAddress PostGenerateNewDepositAddress(string currency)
        {
            var postData = new Dictionary<string, object> {
                { "currency", currency }
            };

            var data = PostData<IGeneratedDepositAddress>("generateNewAddress", postData);
            return data;
        }

        public Task PostWithdrawalAsync(string currency, double amount, string address, string paymentId)
        {
            return Task.Factory.StartNew(() => PostWithdrawal(currency, amount, address, paymentId));
        }
        public void PostWithdrawal(string currency, double amount, string address, string paymentId)
        {
            var postData = new Dictionary<string, object> {
                { "currency", currency },
                { "amount", amount.ToStringNormalized() },
                { "address", address }
            };

            if (paymentId != null)
            {
                postData.Add("paymentId", paymentId);
            }

            PostData<IGeneratedDepositAddress>("withdraw", postData);
        }

        public Task PostWithdrawalAsync(string currency, double amount, string address)
        {
            return Task.Factory.StartNew(() => PostWithdrawal(currency, amount, address, null));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private T PostData<T>(string command, Dictionary<string, object> postData)
        {
            return ApiWebClient.PostData<T>(command, postData);
        }



        public IDepositWithdrawalList GetDepositsAndWithdrawals()
        {
            throw new NotImplementedException();
        }

        public void PostWithdrawal(string currency, double amount, string address)
        {
            throw new NotImplementedException();
        }
    }
}
