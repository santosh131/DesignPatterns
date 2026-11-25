using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class StrategyContextOrService
    {
        private readonly Func<string, IStrategy> _strategyFactory;
        public StrategyContextOrService(Func<string, IStrategy> strategyFactory)
        {
            _strategyFactory = strategyFactory;
        }

        public void ExecuteStrategy(string strategyType)
        {
             var strategy = _strategyFactory(strategyType);
             strategy.ExecuteStrategy();
        }
    }
}
