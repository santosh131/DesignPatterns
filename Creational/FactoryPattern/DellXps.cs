using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
   internal class DellXps:ILaptop 
    {
        public string GetName()
        {
            return "Dell XPS";
        }

        public string GetPrice()
        {
            return "$1500";
        }
    }
}
