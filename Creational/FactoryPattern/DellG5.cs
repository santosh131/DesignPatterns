using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    public class DellG5:ILaptop
    {
        public string GetName()
        {
            return "Dell G5 Series";
        }

        public string GetPrice()
        {
            return "$1300";
        }
    }
}
