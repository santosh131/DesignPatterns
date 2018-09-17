using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FactoryPattern;
using AbstractFactoryPattern;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryPatternSample();
            Console.WriteLine("------------------------");
            AbstractFactoryPatternSample();
            Console.ReadLine();
        }

        private static void AbstractFactoryPatternSample()
        {
            Console.WriteLine("--Sample Abstract Factory Pattern--");

            Console.WriteLine("--Chairs and Sofas from IKEA--");
            IShop s = new IKEAShop();
            ShopClient sc = new ShopClient(s, CommonEnums.ChairTypes.Folding, CommonEnums.SofaTypes.Tuxedo);

            Console.WriteLine(sc.GetChairDetails());
            Console.WriteLine(sc.GetSofaDetails());

            Console.WriteLine("--Chairs and Sofas from Walmart--");
            s = new WalmartShop();
            sc = new ShopClient(s, CommonEnums.ChairTypes.Folding, CommonEnums.SofaTypes.Tuxedo);

            Console.WriteLine(sc.GetChairDetails());
            Console.WriteLine(sc.GetSofaDetails());

        }

        private static void FactoryPatternSample()
        {
            Console.WriteLine("--Sample Factory Pattern--");
            ILaptopCreator lc = new DellXpsConcreteCreator();
            ILaptop l = lc.GetLaptop("");
            Console.WriteLine("Selected laptop is " + l.GetName() + " with a  price of " + l.GetPrice());

            l = lc.GetLaptop("15");
            Console.WriteLine("Selected laptop is " + l.GetName() + " with a  price of " + l.GetPrice());

            lc = new DellGSeriesConcreteCreator();
            l = lc.GetLaptop("");
            Console.WriteLine("Selected laptop is " + l.GetName() + " with a  price of " + l.GetPrice());

            l = lc.GetLaptop("5");
            Console.WriteLine("Selected laptop is " + l.GetName() + " with a  price of " + l.GetPrice());

            lc = new DellVostroConcreteCreator();
            l = lc.GetLaptop("");
            Console.WriteLine("Selected laptop is " + l.GetName() + " with a  price of " + l.GetPrice());

           
        }
    }
}
