using System.ComponentModel.DataAnnotations;
using EntityFramework.Core.Entities.Interfaces;

namespace EntityFramework.Core.Entities;

public class Department: IEntity
{
    public int Id { get; set; }
    [MaxLength(50)]
    public string? DepartmentName { get; set; }
    public string Location { get; set; }
    public string DoorPwd { get; set; }
    // navigation property
    public List<Employee> Employees { get; set; }
}