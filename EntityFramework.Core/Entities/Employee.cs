using System.ComponentModel.DataAnnotations;
using EntityFramework.Core.Entities.Interfaces;

namespace EntityFramework.Core.Entities;

public class Employee: IEntity
{
    public int Id { get; set; }
    
    [MaxLength(50)]
    public string EmployeeName { get; set; }
    [Required(ErrorMessage = "The age is required"), Range(18,60)]
    public int Age { get; set; }
    public int DepartmentId { get; set; }
    // navigation property, because of the Department is user defined and we had DepartmentId;
    public string SsnNumber { get; set; }
    public Department Department { get; set; }
}

// Data annotations: provide extra configuration information, validate the input from the users

//Fluent Api: will always take precedence over data annotations