using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Core.Models.RequestModel;

public class EmployeeRequestModel
{
    [Required(ErrorMessage = "EmployeeName is required")]
    [StringLength(256)]
    public string? EmployeeName { get; set; }

    public int Age { get; set; }
    public int DepartmentId { get; set; }
    public string SSnNumber { get; set; }
}