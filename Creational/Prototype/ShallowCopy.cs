using Prototype.Models;

namespace Prototype;
public class ShallowCopy
{
    public void Run()
    {
        Console.WriteLine("----------------Shallow Copy----------------");

        EmployeeModel employeeModelOriginal = new EmployeeModel
        {
            Id = 1,
            Name = "Sam Tim",
            EmployeeAddress = new EmployeeAddress()
            {
                AddressLine1 = "123 St",
                AddressLine2 = "2nd Fl",
                City = "Ny",
                State = "Ny",
                Zip = "12345",
            }
        };
        EmployeeModel employeeModelCopy = (EmployeeModel)employeeModelOriginal.Clone();
        //Changed values of copied object
        employeeModelCopy.EmployeeAddress.City = "Allen";
        //Since its a shallow copy the changing the EmployeeAddress will change the Original object
         if(employeeModelOriginal.EmployeeAddress.City == "Allen"){
            Console.WriteLine("Original object (EmployeeModel) changed");
         }
         else{
            Console.WriteLine("Original object (EmployeeModel) is not changed");
         }
    }
}