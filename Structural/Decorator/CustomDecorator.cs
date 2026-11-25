using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class CustomDecorator : ICustomDecorator
    {
        private readonly IEmployeeService _employeeService;
        
        public CustomDecorator(IEmployeeService employeeService)
        {
            _employeeService = employeeService;            
        }

        public virtual EmployeeModel GetEmployeeDetails(int id)
        {
            var employee = _employeeService.GetEmployeeDetails(id);
            Console.WriteLine($"Fetching details for employee with ID: {id}");
            return employee;
        }

        public virtual void PostOperation(EmployeeModel employee)
        {
            Console.WriteLine($"Post operation for employee with ID: {employee.Id}");
        }
    }
}
