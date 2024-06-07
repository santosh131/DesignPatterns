using Prototype.Models;

namespace Prototype;
public class DeepCopy
{
    public void Run()
    {
        Console.WriteLine("----------------Deep Copy----------------");
        ManagerModel managerModelOriginal = new ManagerModel
        {
            Id = 1,
            Name = "Sam Tim",
            ManagerAddress = new ManagerAddressModel()
            {
                AddressLine1 = "123 St",
                AddressLine2 = "2nd Fl",
                City = "Ny",
                State = "Ny",
                Zip = "12345",
            }
        };
        ManagerModel managerModelCopy = (ManagerModel)managerModelOriginal.Clone();
        //Changed values of copied object
        managerModelCopy.ManagerAddress.City = "Allen";
        //Since its a deep copy the changing the ManagerAddress will not change the Original object
         if(managerModelOriginal.ManagerAddress.City == "Allen"){
            Console.WriteLine("Original object (ManagerModel) changed");
         }
         else{
            Console.WriteLine("Original object (ManagerModel) is not changed");
         }
    }
}