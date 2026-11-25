using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern
{
   public class ShopClient
    {
       IChair chair;
       ISofa sofa;
       public ShopClient(IShop s ,CommonEnums.ChairTypes cTypes,CommonEnums.SofaTypes sTypes)
       {
           chair = s.GetChair(cTypes);
           sofa = s.GetSofa(sTypes);
       }

       public string GetChairDetails()
       {
           if (chair != null)
               return chair.GetModelDetails();
           else
               return "No Chairs available";
       }

       public string GetSofaDetails()
       {
           if (sofa != null)
               return sofa.GetModelDetails();
           else
               return "No Sofas available";
       }
    }
}
