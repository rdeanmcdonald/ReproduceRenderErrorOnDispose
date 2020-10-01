using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReproduceRenderErrorOnDispose.Store.Counter
{
    public class CounterState
    {
        public int ClickCount { get; }

        public CounterState(int clickCount)
        {
            ClickCount = clickCount;
        }
    }
}
