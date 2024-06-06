namespace Singleton;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("----------------Singleton----------------");
        Console.WriteLine("---Approach 1: With static constructor----");
        var instance1 = Singleton.Instance;
        var instance2 = Singleton.Instance;
        if (instance1.Equals(instance2))
        {
            Console.WriteLine("First instance is same as Second instance");
        }
        else{
            Console.WriteLine("First & Second instances are different");
        }

        Console.WriteLine("---Approach 2: Without static constructor----");
        var approach2Instance1 =Singleton2.Instance;
        var approach2Instance2 =Singleton2.Instance;
        if(approach2Instance1.Equals(approach2Instance2))
        {
            Console.WriteLine("First instance is same as Second instance");
        }
        else{
            Console.WriteLine("First & Second instances are different");
        }
    }
}
