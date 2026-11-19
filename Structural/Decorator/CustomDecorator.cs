using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class CustomDecorator : IEmployeeService
    {
        public List<EmployeeModel> Employees { get; set; }

        private readonly IEmployeeService _employeeService;
        public CustomDecorator(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
            if (Employees == null)
            {
                Employees = new List<EmployeeModel>
                {
                    new EmployeeModel { Id = 1, Name = "John Doe" },
                    new EmployeeModel { Id = 2, Name = "Jane Smith" },
                    new EmployeeModel { Id = 3, Name = "Bob Johnson" }
                };
            }
        }
        public virtual EmployeeModel GetEmployeeDetails(int id)
        {
            var employee = _employeeService.GetEmployeeDetails(id);
            Console.WriteLine($"Fetching details for employee with ID: {id}");
            return employee;
        }

        public abstract void PostOperation(EmployeeModel employee);
    }
}
