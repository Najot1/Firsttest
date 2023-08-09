
namespace Crm.Entities;

public sealed class Order
{
    private string? _id;
    public required string Id
    {
        get => _id ?? string.Empty;
        set => _id = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
   
    private string? _description;
    public required string Description
    {
        get => _description ?? string.Empty;
        set => _description = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    private short _price;
    public required  short Price
    {
        get => _price;
        set => _price = value >= 1 ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    
    private string? _date;
    public required string Date 
    {
        get => _date ?? string.Empty;
        set => _date = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    
    private string? _address;
    public required string Address 
    {
         get => _address ?? string.Empty;
        set => _address = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    
    public required TypeOfDelivery Delivery {get ; set ;}

    
    






}