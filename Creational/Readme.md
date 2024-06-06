# Singleton
Ensure a class has only one instance, and provide a global point of access to it.

- This pattern says that a class should have only one instance. You can create an instance if it is not available otherwise use the same instance.  
- Class is marked with **sealed** keyword to prevent further derviation of class  
- **public static** ensures the global access point.  
- **readonly** ensures assignment takes place in static constructor only  
- if **static constructor** is not used then the private **variable** can be directly instantiated  
```
private static Singleton2 singleton =new Singleton2();
``` 

