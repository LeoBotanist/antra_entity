using EntityFramework.Core.Models.RequestModel;
using EntityFramework.Infrastructure.Services;

namespace Entity.UI;

public class ManageEmployee
{
    private EmployeeService _employeeService = new EmployeeService();

    private void AddEmployee()
    {
        EmployeeRequestModel employeeRequestModel = new EmployeeRequestModel();
        Console.WriteLine("Enter employee name:");
        employeeRequestModel.EmployeeName = Console.ReadLine();
        Console.WriteLine("enter employee age: ");
        employeeRequestModel.Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter employee department id");
        employeeRequestModel.DepartmentId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter employee ssn number");
        employeeRequestModel.SSnNumber = Console.ReadLine();
        Console.WriteLine(_employeeService.AddEmployee(employeeRequestModel));
    }
    
    private void PrintAllEmployee()
    {
        var employees = _employeeService.GetAllEmployees();
        foreach (var employee in employees)
        {
            Console.WriteLine(employee.EmployeeName + '\t' + employee.Age + '\t' + employee.DepartmentId);
        }
    }

    private void GetEmployeeById()
    {
        Console.WriteLine("Please enter employee id:");
        int id = Convert.ToInt32(Console.ReadLine());
        var employee = _employeeService.GetById(id);
        Console.WriteLine(employee.EmployeeName + '\t' + employee.Age + employee.DepartmentId);
    }

    private void UpdateEmployee()
    {
        
        EmployeeRequestModel employeeRequestModel = new EmployeeRequestModel();
        Console.WriteLine("Please enter employee id");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter employee name:");
        employeeRequestModel.EmployeeName = Console.ReadLine();
        Console.WriteLine("enter employee age: ");
        employeeRequestModel.Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter employee department id");
        employeeRequestModel.DepartmentId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter employee ssn number");
        employeeRequestModel.SSnNumber = Console.ReadLine();
        Console.WriteLine(_employeeService.UpdateEmployee(id, employeeRequestModel));
    }

    private void DeleteEmployee()
    {
        Console.WriteLine("Please enter employee id:");
        int id = Convert.ToInt32(Console.ReadLine());
        var employee = _employeeService.DeleteEmployeeById(id);
    }

    public void Run()
    {
        // AddEmployee();
    }
}