using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    internal class DellGSeries : ILaptop
    {
        public string GetName()
        {
            return "Dell G3 Series";
        }

        public string GetPrice()
        {
            return "$1000";
        }
    }
}
