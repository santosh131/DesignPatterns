using FactoryPattern;

Console.WriteLine("----------------Factory Pattern----------------");

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