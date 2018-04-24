using Jojatekok.PoloniexAPI.LiveTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jojatekok.PoloniexAPI
{
    /// <summary>
    /// Push API
    //The best way to get public data updates on markets is via the push API, which pushes live ticker, order book, trade, and Trollbox updates over WebSockets using the WAMP protocol.In order to use the push API, connect to wss://api.poloniex.com and subscribe to the desired feed.
    /// </summary>
    public class BusinessLive
    {
        public Live live = new Live();

        public async void Subcribe()
        {
            try
            {
                await live.SubscribeToTickerAsync();
            }
            catch (Exception)
            {

                live.Stop();
            }
        }

        public BusinessLive()
        {
            live.Start();
            Subcribe();
        }
    }
}
