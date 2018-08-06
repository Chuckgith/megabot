using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoloniexApiSynchronisationProxy
{
    internal class PriorityJob
    {
        public PriorityJob(int priority)
        {
            Priority = priority;
            ExecutionAwaiterTask = new TaskCompletionSource<bool>();
        }

        public int Priority { get; set; }
        public TaskCompletionSource<bool> ExecutionAwaiterTask { get; set; }
    }
}
