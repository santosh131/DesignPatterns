using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class EmployeeAddDecorator : CustomDecorator
    {
        public EmployeeAddDecorator(IEmployeeService employeeService) : base(employeeService)
        {
        }

        public override EmployeeModel GetEmployeeDetails(int id)
        {
            return base.GetEmployeeDetails(id);
        }

        public override void PostOperation(EmployeeModel employee)
        {
            EmployeeData.Employees.Add(employee);
            Console.WriteLine($"Adding employee with ID: {employee.Id} and Name: {employee.Name}");
        }
    }
}
