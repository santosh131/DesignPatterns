using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern
{
    public class WalmartShop:IShop
    {
        public IChair GetChair(CommonEnums.ChairTypes c)
        {
            if (c == CommonEnums.ChairTypes.Club)
                return new ClubChairs();
            else if (c == CommonEnums.ChairTypes.Rocking)
                return new RockingChairs();
            else
                return null;
        }

        public ISofa GetSofa(CommonEnums.SofaTypes s)
        {
            return null;
        }
    }
}
