using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    public class DellGSeriesConcreteCreator:ILaptopCreator
    {
        public ILaptop GetLaptop(string modelName)
        {
            if (modelName == "")
                return new DellGSeries();
            else if (modelName == "5")
                return new DellG5();
            else if (modelName == "7")
                return new DellG7();
            else
                return null;
        }
    }
}
