using EntityFramework.Core.Models.RequestModel;
using EntityFramework.Infrastructure.Services;

namespace Entity.UI;

public class ManageDepartment
{
    private DepartmentService _departmentService = new DepartmentService();

    private void AddDepartment()
    {
        DepartmentRequestModel departmentRequestModel = new DepartmentRequestModel();
        Console.WriteLine("Enter department name:");
        departmentRequestModel.DepartmentName = Console.ReadLine();
        Console.WriteLine("enter department location: ");
        departmentRequestModel.Location = Console.ReadLine();
        Console.WriteLine("enter department door password: ");
        departmentRequestModel.DoorPwd = Console.ReadLine();
        Console.WriteLine(_departmentService.AddDepartment(departmentRequestModel));
    }
    
    private void PrintAllDepartment()
    {
        var departments = _departmentService.GetAllDepartments();
        foreach (var department in departments)
        {
            Console.WriteLine(department.DepartmentName + '\t' + department.Location);
        }
    }

    private void GetDepartmentById()
    {
        Console.WriteLine("Please enter department id:");
        int id = Convert.ToInt32(Console.ReadLine());
        var department = _departmentService.GetById(id);
        Console.WriteLine(department.DepartmentName + '\t' + department.Location);
    }

    private void UpdateDepartment()
    {
        DepartmentRequestModel departmentRequestModel = new DepartmentRequestModel();
        Console.WriteLine("Please enter department id");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter department name:");
        departmentRequestModel.DepartmentName = Console.ReadLine();
        Console.WriteLine("enter department location: ");
        departmentRequestModel.Location = Console.ReadLine();
        Console.WriteLine("enter department door password: ");
        departmentRequestModel.DoorPwd = Console.ReadLine();
        Console.WriteLine(_departmentService.UpdateDepartment(id, departmentRequestModel));

    }
    
    private void DeleteDepartment()
    {
        Console.WriteLine("Please enter employee id:");
        int id = Convert.ToInt32(Console.ReadLine());
        var employee = _departmentService.DeleteDepartmentById(id);
    }

    public void Run()
    {
        // AddDepartment();
        // UpdateDepartment();
        // GetDepartmentById();
        // DeleteDepartment();
    }
}