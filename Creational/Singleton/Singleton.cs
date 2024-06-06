namespace Singleton;
//Approach - 1:  with static constructor 
public sealed class Singleton
{
    private static readonly Singleton singleton;

    //private constructor is used to prevent the creation of instances withe new keyword
    private Singleton()
    {
        Console.WriteLine("private constructor is called");
    }

    //static constructor is used to initialize any static data
    static Singleton()
    {
        Console.WriteLine("static constructor is called");
        singleton = new Singleton();
    }

    //global access point
    public static Singleton Instance
    {
        get { return singleton; }
    }
}