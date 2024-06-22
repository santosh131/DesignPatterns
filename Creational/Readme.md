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

## Builder
### Separate the construction of complex object from its representation so that the same construction process can create different representation  

It is useful for creating complex objects having multiple parts.  
- Construction process does not depend on how parts are assembled.  
- Using this pattern same construction process can be applied to different products
- Notice in the Example2, IProductBuilder has set of methods that returns IProductBuilder, this helps in applying **method chaining**
- Players involved in builder pattern
1. Director - Creates the final product using the Builder. Decides the sequence of steps to build the product.  
QueryDirector (or) ProductDirector   
```
//Example 1
public class QueryDirector
{
    private IQueryBuilder? _queryBuilder;

    public void Construct(IQueryBuilder queryBuilder)
    {
        _queryBuilder = queryBuilder;
        _queryBuilder.Step1();
        _queryBuilder.Step2();
        ...
    }
}
//Example 2
public class ProductDirector
{
    private IProductBuilder? _productBuilder;
    public void Construct(IProductBuilder productBuilder){
        _productBuilder = productBuilder;

        _productBuilder
            .AddPart1()
            .AddPart2()
            .AddPart3();
    }
}
``` 
2. IBuilder or abstract class - contains methods that are to be implemented by concrete class   
```
public interface IQueryBuilder{
    void Step1();
    void Step2();
    void Step3();
    FinalQuery GetFinalQuery();
}
```
3. Builder(Concrete class of IBuilder) - implements the IBuilder interface  
```
public class Process1QueryBuilder : IQueryBuilder
{
    ...
}
public class Process2QueryBuilder : IQueryBuilder
{
    ...
}
```
4. Product  
```
public class FinalQuery
{
    ...
}
```




