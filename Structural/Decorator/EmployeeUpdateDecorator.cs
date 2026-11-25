using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class EmployeeUpdateDecorator : ICustomDecorator
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeUpdateDecorator(IEmployeeService employeeService) 
        {
            _employeeService = employeeService;
        }

        public EmployeeModel GetEmployeeDetails(int id)
        {
            Console.WriteLine($"EmployeeUpdateDecorator - Get - Fetching details for employee with ID: {id}");
            return _employeeService.GetEmployeeDetails(id);
        }

        public void PostOperation(EmployeeModel employee)
        {
            var eModel = EmployeeData.Employees.FirstOrDefault(e => e.Id == employee.Id) ?? null;
            if (eModel != null)
            {
                eModel.Name = employee.Name;
            }
            Console.WriteLine($"EmployeeUpdateDecorator - Post -Update employee with ID: {employee.Id} and Name: {employee.Name}");
        }
    }
}
