using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Core.Models.RequestModel;

public class DepartmentRequestModel
{
    public string DepartmentName { get; set; }
    public string Location { get; set; }
    public string DoorPwd { get; set; }
}