using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern
{
    public class IKEAShop : IShop
    {
        public IChair GetChair(CommonEnums.ChairTypes c)
        {
            if (c == CommonEnums.ChairTypes.Folding)
                return new FoldingChairs();
            else if (c == CommonEnums.ChairTypes.Wing)
                return new WingChairs();
             else
                return null;
        }

        public ISofa GetSofa(CommonEnums.SofaTypes s)
        {
            if (s == CommonEnums.SofaTypes.Tuxedo)
                return new TuxedoSofas();
            else
                return new KnoleSofas();
        }
    }
}
