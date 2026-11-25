using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    internal class DellVostro : ILaptop
    {
        public string GetName()
        {
            return "Dell Vostro";
        }

        public string GetPrice()
        {
            return "$800";
        }
    }
}
