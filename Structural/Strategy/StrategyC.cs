using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class StrategyC : IStrategy
    {
        public void ExecuteStrategy()
        {
            Console.WriteLine("Executing Strategy C");
        }
    }
}
