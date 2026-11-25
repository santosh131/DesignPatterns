Definition:
Define an interface for creating an object, but let subclasses decide which class to instantiate.

Steps:
1. Create the interface ILaptop which is kind of a interface for subclass
2. Create the class for different models of laptop which inherit the interface ILaptop
3. Create the interface ILaptopCreator 
4. Create Creator class's , Inherit from ILaptopCreator and implement the methods in the interface
5. In the Client (Program.cs) -create the instance of ILaptopCreator and using this instance
   create the ILaptop instance using the GetLaptop method
 