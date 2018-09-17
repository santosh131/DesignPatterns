using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    public interface ILaptopCreator
    {
       ILaptop GetLaptop(string modelName);
    }
}
