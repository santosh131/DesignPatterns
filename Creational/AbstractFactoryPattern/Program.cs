using AbstractFactoryPattern;

Console.WriteLine("----------------Abstract Factory Pattern----------------");

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