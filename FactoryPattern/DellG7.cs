using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    public class DellG7:ILaptop
    {
        public string GetName()
        {
            return "Dell G7 Series";
        }

        public string GetPrice()
        {
            return "$1600";
        }
    }
}
