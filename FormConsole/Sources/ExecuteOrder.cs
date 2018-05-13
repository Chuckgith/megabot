using Jojatekok.PoloniexAPI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FormConsole.Sources
{
    public class SourceExecuteOrder : IDisposable
    {
        ISubject<OrderModel> _executeOrderSubject = new Subject<OrderModel>();
        Task _executeOrderLoop;
        CancellationTokenSource _cts = new CancellationTokenSource();

        EnumStates lastState = EnumStates.WAITING;

        public SourceExecuteOrder()
        {
            //_executeOrderLoop = ExecuteOrder();
        }

        private OrderModel ExecuteOrder()
        {
            return null;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}