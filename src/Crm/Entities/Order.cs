
namespace Crm.Entities;

public sealed class Order
{
    private readonly string _id;
    public required string Id
    {
        get => _id ?? string.Empty;
        init => _id = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
   
    private readonly string _description;
    public required string Description
    {
        get => _description ?? string.Empty;
        init => _description = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    private readonly short _price;
    public required  short Price
    {
        get => _price;
        init => _price = value >= 1 ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    
    private readonly string _date;
    public required string Date 
    {
        get => _date ?? string.Empty;
        init => _date = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    
    private readonly string _address;
    public required string Address 
    {
         get => _address ?? string.Empty;
        init => _address = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    
    public required TypeOfDelivery Delivery {get ; set ;}

    
    






}