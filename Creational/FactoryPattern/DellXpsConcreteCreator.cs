using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    public class DellXpsConcreteCreator:ILaptopCreator
    {
        public ILaptop GetLaptop(string modelName)
        {
            if (modelName == "")
                return new DellXps();
            else
                return new DellXps15();
        }

    }
}
