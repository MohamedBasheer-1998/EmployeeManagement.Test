using System.ComponentModel.DataAnnotations;
using Xunit.Sdk;

public class Employee
{
    public int Id { get; set; } // Unique identifier for the employee

    [Required(ErrorMessage = "Name is required.")]
    [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
    public string Name { get; set; } // Name of the employee

    [Required(ErrorMessage = "Date of Birth is required.")]
    [DataType(DataType.Date, ErrorMessage = "Invalid date format.")]
    public DateTime DateOfBirth { get; set; } // Date of birth of the employee

    [Required(ErrorMessage = "Position is required.")]
    [StringLength(50, ErrorMessage = "Position cannot exceed 50 characters.")]
    public string Position { get; set; } // Position of the employee within the company

    [StringLength(250, ErrorMessage = "Address cannot exceed 250 characters.")]
    public string Address { get; set; } // Address of the employee
}