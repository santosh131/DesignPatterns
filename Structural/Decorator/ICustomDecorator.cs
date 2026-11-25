using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public interface ICustomDecorator : IEmployeeService
    {
        public void PostOperation(EmployeeModel employee);
    }
}
