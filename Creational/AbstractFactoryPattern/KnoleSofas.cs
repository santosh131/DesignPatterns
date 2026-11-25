using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern
{
   public class KnoleSofas:ISofa
    {
        public string GetModelDetails()
        {
            return "New IKEA Tuxedo sofa";
        }
    }
}
