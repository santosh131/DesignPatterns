using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern
{
    public class ClubChairs : IChair
    {
        public string GetModelDetails()
        {
            return "New Walmart Club Chair";
        }
    }
}
