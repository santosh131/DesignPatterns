using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public interface IEmployeeService
    {
        EmployeeModel GetEmployeeDetails(int id);
    }
}
