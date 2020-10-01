using Fluxor;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ReproduceRenderErrorOnDispose.Store.Counter
{
    public class Effects
    {
        public Effects(
            ILogger<Effects> logger,
            IState<CounterState> counterState
        )
        {
            _logger = logger;
            CounterState = counterState;
        }

        private readonly ILogger<Effects> _logger;
        private readonly IState<CounterState> CounterState;

        [EffectMethod]
        public async Task HandleIncrementCounterAction(IncrementCounterAction action, IDispatcher dispatcher)
        {
            // Just to show even though the render error is thrown, the IState gets updated on Dispose
            _logger.LogInformation("Handling IncrementCounterAction");
            _logger.LogInformation("State pre-delay -------------");
            _logger.LogInformation(JsonConvert.SerializeObject(CounterState.Value));
            _logger.LogInformation("-------------");
            await Task.Delay(5000);
            _logger.LogInformation("State post-delay -------------");
            _logger.LogInformation(JsonConvert.SerializeObject(CounterState.Value));
            _logger.LogInformation("-------------");
        }
    }
}
