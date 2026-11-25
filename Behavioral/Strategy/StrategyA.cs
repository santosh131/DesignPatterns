using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class StrategyA : IStrategy
    {
        public void ExecuteStrategy()
        {
            Console.WriteLine("Executing Strategy A");
        }    
    }
}
