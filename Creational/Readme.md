# Creational  
These patterns are mainly focused on creation of objects.  
- Singleton
- Prototype
- Builder
- Factory Method
- Abstract Factory

## Singleton
### Ensure a class has only one instance, and provide a global point of access to it.

- This pattern says that a class should have only one instance. You can create an instance if it is not available otherwise use the same instance.  
- Class is marked with **sealed** keyword to prevent further derviation of class  
- **public static** ensures the global access point.  
- **readonly** ensures assignment takes place in static constructor only  
```
    static Singleton()
    {
        Console.WriteLine("static constructor is called");
        singleton = new Singleton();
    }
```
- if **static constructor** is not used then the private **variable** can be directly instantiated  
```
private static readonly Singleton2 singleton =new Singleton2();
``` 

## Prototype
### Create new objects by copying the original object  
Core idea of this pattern is to create an object that is based on another object. This existing object acts as template for new object. In short, you should not change the original object when you work on cloned copy of the object.  

- In general, an abstract class or interface acts as abstract prototype.  
- This abstract prototype contains clone method that has to be implemented by concrete class.  
- There are two ways of cloning:  
**Shallow Copy**  
**Deep Copy**  
- Shallow Copy: simple types are cloned and for reference types only references are copied. So the original and cloned objects point to the same object. 
- Deep Copy: this can be achieved by following approaches
1. MemberwiseClone()  
2. Serialization  
3. Copy constructor  
```
public Employee(Employee origEmployee){
    this.Id = origEmployee.Id;
}
```
