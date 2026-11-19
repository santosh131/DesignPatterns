using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public static class EmployeeData
    {
        public static List<EmployeeModel> Employees = new List<EmployeeModel>
        {
            new EmployeeModel { Id = 1, Name = "John Doe" },
            new EmployeeModel { Id = 2, Name = "Jane Smith" },
            new EmployeeModel { Id = 3, Name = "Alice Johnson" }
        };
    }
}
