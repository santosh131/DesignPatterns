using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class StrategyB : IStrategy
    {
        public void ExecuteStrategy()
        {
            Console.WriteLine("Executing Strategy B");
        }
    }
}
