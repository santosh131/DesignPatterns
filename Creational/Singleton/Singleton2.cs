namespace Singleton;
//Approach - 2:  without static constructor 
public sealed class Singleton2{
    private static readonly Singleton2 singleton =new Singleton2();

    private Singleton2(){
        Console.WriteLine("private constructor");
    }

    //public global access point
    public static Singleton2 Instance{
        get{
            return singleton;
        }
    }
}