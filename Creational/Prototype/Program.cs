namespace Prototype;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("----------------Prototype----------------");
        ShallowCopy shallowCopy = new ShallowCopy();
        DeepCopy deepCopy = new DeepCopy();
        
        shallowCopy.Run();
        deepCopy.Run();
    }
}
