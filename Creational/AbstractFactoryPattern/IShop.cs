using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern
{
    public interface IShop
    {
        IChair GetChair(CommonEnums.ChairTypes c);
        ISofa GetSofa(CommonEnums.SofaTypes s);
    }
}
