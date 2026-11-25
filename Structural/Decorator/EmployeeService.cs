using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class EmployeeService : IEmployeeService
    {
        public EmployeeService()
        {
        }

        public EmployeeModel GetEmployeeDetails(int id)
        {
            Console.WriteLine($"EmployeeService - Fetching details for employee with ID: {id}");
            return EmployeeData.Employees.Find(e => e.Id == id) ?? new EmployeeModel();
        }
    }
}
