using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern
{
   public static class CommonEnums
    {
       public enum ChairTypes
       {
           Folding=1,
           Wing=2,
           Club= 3,
           Rocking = 4
       }

       public enum SofaTypes
       {
           Tuxedo = 1,
           Knole = 2
       }
    }
}
