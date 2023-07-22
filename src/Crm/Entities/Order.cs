using System.ComponentModel.DataAnnotations;
namespace Crm.Entities;

public sealed class Order
{
    [Required]
    public string? Id { get; set; }
    [Required]
    public string? Description { get; set; }
    [Range(1,maximum:100000)]
    public short Price { get; set; }
    [Required]
    public string? Date { get; set; }
    [Required]
    public string? Address { get; set; }
    [Range(0,2)]
    public TypeOfDelivery Delivery { get; set; }
    






}