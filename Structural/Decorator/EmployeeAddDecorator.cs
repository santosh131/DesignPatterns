using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class EmployeeAddDecorator : ICustomDecorator
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeAddDecorator(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public EmployeeModel GetEmployeeDetails(int id)
        {
            Console.WriteLine($"EmployeeAddDecorator - Get - Fetching details for employee with ID: {id}");
            return _employeeService.GetEmployeeDetails(id);
        }


        public void PostOperation(EmployeeModel employee)
        {
            EmployeeData.Employees.Add(employee);
            Console.WriteLine($"EmployeeAddDecorator - Post - Adding employee with ID: {employee.Id} and Name: {employee.Name}");
        }
    }
}
