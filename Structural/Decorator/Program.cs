using Decorator;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Decorator Pattern");
Console.WriteLine("Method1 : To have additional methods & also update existing methods");
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


//-------------------------Example Email Service-------------------------

Console.WriteLine("Method2 : To update existing methods only");
var service = new ServiceCollection()
    .AddTransient<EmailService>()
    .AddTransient<IEmailService>(x=> new EmailLogDecorator(x.GetRequiredService<EmailService>()));

var serviceProvider = service.BuildServiceProvider();

var emailService = serviceProvider.GetService<IEmailService>();
emailService.SendEmail("test@example.com", "Test Subject", "Test Body");




