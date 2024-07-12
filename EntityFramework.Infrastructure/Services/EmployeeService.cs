using EntityFramework.Core.Entities;
using EntityFramework.Core.Interfaces.Services;
using EntityFramework.Core.Models.RequestModel;
using EntityFramework.Core.Models.ResponseModel;
using EntityFramework.Infrastructure.Repositories;
using Serilog;

namespace EntityFramework.Infrastructure.Services;

public class EmployeeService: IEmployeeService
{
    private EmployeeRepository _employeeRepository = new EmployeeRepository();
    public List<EmployeeResponseModel> GetAllEmployees()
    {
        var employees = _employeeRepository.GetAll();
        var employeeResponseModels = new List<EmployeeResponseModel>();
        foreach (var employee in employees)
        {
            employeeResponseModels.Add(new EmployeeResponseModel
            {
                EmployeeName = employee.EmployeeName,
                Age = employee.Age,
                DepartmentId = employee.DepartmentId
            });
        }
        Log.Information("GetAll employee method has been called");
        return employeeResponseModels;
    }

    public EmployeeResponseModel GetById(int id)
    {
        var employee = _employeeRepository.GetById(id);
        if (employee != null)
        {
            var employeeResponseModel = new EmployeeResponseModel
            {
                EmployeeName = employee.EmployeeName,
                Age = employee.Age,
                DepartmentId = employee.DepartmentId
            };
            
            return employeeResponseModel;
        }
        Log.Error($"Employee with id {id} is not found");
        return null;
    }

    public int AddEmployee(EmployeeRequestModel model)
    {
        var employeeEntity = new Employee
        {
            EmployeeName = model.EmployeeName,
            Age = model.Age,
            DepartmentId = 1,
            SsnNumber = model.SSnNumber
        };

        if (_employeeRepository.Insert(employeeEntity) > 0)
        {
            Log.Information("Employee has been added");
            return 1;
        }
        Log.Error("Adding employee failed!");
        return 0;
    }

    public int UpdateEmployee(int id, EmployeeRequestModel model)
    {
        var employeeEntity = new Employee
        {
            Id = id,
            EmployeeName = model.EmployeeName,
            Age = model.Age,
            DepartmentId = 1,
            SsnNumber = model.SSnNumber
        };
        if (_employeeRepository.Update(employeeEntity) > 0)
        {
            Log.Information("Employee has been updated");
            return 1;
        }
        Log.Error("Updating employee failed!");
        return 0;
    }

    public int DeleteEmployeeById(int id)
    {
        var employee = _employeeRepository.GetById(id);
        if (employee != null && _employeeRepository.DeleteById(id) > 0)
        {
            Log.Information($"Employee {id} has been deleted");
            return 1;
        }
        Log.Error($"Employee with id {id} is not found");
        return 0;
    }
}