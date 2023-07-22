using System.ComponentModel.DataAnnotations;

namespace Crm.Entities;

public sealed class Client
{
    [Required]
    public string? FirstName { get; set; }
    [Required]
    public string? LastName { get; set; }
    [Required]
    public string? MiddleName { get; set; }
    [Range(1, 100)]
    public int Age { get; set; }
    [Required]
    public string? PassportNumber { get; set; }
    [Range(0,1)]
    public Gender Gender { get; set; }
}
