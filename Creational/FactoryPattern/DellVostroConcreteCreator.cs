using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    public class DellVostroConcreteCreator:ILaptopCreator
    {
        public ILaptop GetLaptop(string modelName)
        {
            return new DellVostro();
        }
    }
}
