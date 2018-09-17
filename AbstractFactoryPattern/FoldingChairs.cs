using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern
{
    public class FoldingChairs:IChair
    {
        public string GetModelDetails()
        {
            return "New IKEA Folding Chair";
        }
    }
}
