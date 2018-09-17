using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
   public class DellXps15 :ILaptop  
    {
        public string GetName()
        {
            return "Dell XPS 15";
        }

        public string GetPrice()
        {
            return "$1800";
        }
    }
}
