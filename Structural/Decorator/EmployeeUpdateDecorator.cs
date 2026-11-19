using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class EmployeeUpdateDecorator : CustomDecorator
    {
        public EmployeeUpdateDecorator(IEmployeeService employeeService) : base(employeeService)
        {
        }

        public override EmployeeModel GetEmployeeDetails(int id)
        {
            return base.GetEmployeeDetails(id);
        }

        public override void PostOperation(EmployeeModel employee)
        {
            EmployeeModel eModel = EmployeeData.Employees.FirstOrDefault(e => e.Id == employee.Id);
            if (eModel != null)
            {
                eModel.Name = employee.Name;
            }
            Console.WriteLine($"Update employee with ID: {employee.Id} and Name: {employee.Name}");
        }
    }
}
