using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern
{
   public  class RockingChairs : IChair
    {
        public string GetModelDetails()
        {
            return "New Walmart Rocking Chair";
        }
    }
}
