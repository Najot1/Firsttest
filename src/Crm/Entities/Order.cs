
namespace Crm.Entities;

public sealed class Order
{
 
    public required string Id
    {
        get => Id ?? string.Empty;
        init => Id = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public required string Description
    {
        get => Description ?? string.Empty;
        init => Description = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public required  short Price 
    {
        get => Price;
        set => Price = value >= 18 ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
 
    public required string Date 
    {
        get => Date ?? string.Empty;
        init => Date = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
 
    public required string Address 
    {
         get => Address ?? string.Empty;
        init => Address = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
  
    public required TypeOfDelivery Delivery { get; set; }
    






}