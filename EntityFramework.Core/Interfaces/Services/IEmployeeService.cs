using EntityFramework.Core.Models.RequestModel;
using EntityFramework.Core.Models.ResponseModel;

namespace EntityFramework.Core.Interfaces.Services;

public interface IEmployeeService
{
    List<EmployeeResponseModel> GetAllEmployees();
    EmployeeResponseModel GetById(int id);
    int AddEmployee(EmployeeRequestModel model);
    int UpdateEmployee(int id, EmployeeRequestModel model);
    int DeleteEmployeeById(int id);
}