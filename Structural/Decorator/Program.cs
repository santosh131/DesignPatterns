using Decorator;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Decorator Pattern");

//-------------------------Example Email Service-------------------------

var service = new ServiceCollection()
    .AddTransient<EmailService>()
    .AddTransient<IEmailService>(x => //Add behavior to existing methods only
        new EmailLogDecorator(x.GetRequiredService<EmailService>())
    );

service.AddTransient<EmployeeService>()
    .AddTransient<IEmployeeService>(x => //Add multiple behaviors to existing methods only
        new EmployeeUpdateDecorator(
            new EmployeeAddDecorator(x.GetRequiredService<EmployeeService>())
        )
    )
    .AddTransient<ICustomDecorator>(x => //Add multiple behavior to existing methods and also add new methods
        new EmployeeUpdateDecorator(
            new EmployeeAddDecorator(x.GetRequiredService<EmployeeService>())
        )
    );

var serviceProvider = service.BuildServiceProvider();

Console.WriteLine("----------------------Email Service - Add behavior to existing methods only----------------------------");
var emailService = serviceProvider.GetService<IEmailService>();
emailService?.SendEmail("test@example.com", "Test Subject", "Test Body");

Console.WriteLine("----------------------Employee Service - Add multiple behaviors to existing methods only----------------------------");
var empSvc = serviceProvider.GetService<IEmployeeService>();
Console.WriteLine("Updates Get behavior of Employee service");
empSvc?.GetEmployeeDetails(1);

Console.WriteLine("----------------------Employee Service, ICustomDecorator - Add multiple behaviors to existing methods and also add new methods----------------------------");
Console.WriteLine("Updates Get behavior and also adds Update & Add behavior to Employee service");
var empSvcAddOrUpdate = serviceProvider.GetService<ICustomDecorator>();
empSvcAddOrUpdate?.GetEmployeeDetails(1);
empSvcAddOrUpdate?.PostOperation(new EmployeeModel { Id = 1, Name = "John Doe" });


//--------------------------------------------------

Console.WriteLine("For explanation purpose only : Add multiple behaviors to existing methods and also add new methods");

IEmployeeService employeeService = new EmployeeService();

//-------------------------Base Service Get Employee-------------------------
EmployeeModel employee = employeeService.GetEmployeeDetails(1);
Console.WriteLine($"Employee ID: {employee.Id}, Employee Name: {employee.Name}");


//-------------------------Add Decorator-------------------------
Console.WriteLine("-------------------------Add Decorator-------------------------");
ICustomDecorator addDecorator = new EmployeeAddDecorator(employeeService);
addDecorator.PostOperation(new EmployeeModel { Id = 4, Name = "Samuel Jackson" });

EmployeeModel employeeAddOpertaion = addDecorator.GetEmployeeDetails(4);
Console.WriteLine($"Employee ID: {employeeAddOpertaion.Id}, Employee Name: {employeeAddOpertaion.Name}");

//-------------------------Update Decorator-------------------------
Console.WriteLine("-------------------------Update Decorator-------------------------");
employeeAddOpertaion.Name = "Samuel Jackson Update";
ICustomDecorator updateDecorator = new EmployeeUpdateDecorator(addDecorator);
updateDecorator.PostOperation(employeeAddOpertaion);

EmployeeModel employeeUpdateOperation = updateDecorator.GetEmployeeDetails(4);

Console.WriteLine($"Employee ID: {employeeUpdateOperation.Id}, Employee Name: {employeeUpdateOperation.Name}");
Console.ReadLine();




