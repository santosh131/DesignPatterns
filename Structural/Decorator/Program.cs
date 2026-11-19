using Decorator;

Console.WriteLine("Decorator Pattern");
IEmployeeService employeeService = new EmployeeService();

//-------------------------Base Service Get Employee-------------------------
EmployeeModel employee = employeeService.GetEmployeeDetails(1);
Console.WriteLine($"Employee ID: {employee.Id}, Employee Name: {employee.Name}");


//-------------------------Add Decorator-------------------------
CustomDecorator addDecorator = new EmployeeAddDecorator(employeeService);
addDecorator.PostOperation(new EmployeeModel { Id = 4, Name = "Samuel Jackson" });

EmployeeModel employeeAddOpertaion = addDecorator.GetEmployeeDetails(4);
Console.WriteLine($"Employee ID: {employeeAddOpertaion.Id}, Employee Name: {employeeAddOpertaion.Name}");

//-------------------------Update Decorator-------------------------
employeeAddOpertaion.Name = "Samuel Jackson Update";
CustomDecorator updateDecorator = new EmployeeUpdateDecorator(employeeService);
updateDecorator.PostOperation(employeeAddOpertaion);

EmployeeModel employeeUpdateOperation = updateDecorator.GetEmployeeDetails(4);

Console.WriteLine($"Employee ID: {employeeUpdateOperation.Id}, Employee Name: {employeeUpdateOperation.Name}");




