namespace Crm.DataAccess;

public sealed class Order
{
    public int ID {get; set;}
    private string? _description;
    public string Description
    {
        get => _description ?? string.Empty;
        set => _description = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    private short _price;
    public  short Price
    {
        get => _price;
        set => _price = value >= 0 ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    
    private string? _date;
    public string Date 
    {
        get => _date ?? string.Empty;
        set => _date = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    
    private string? _address;
    public string Address 
    {
         get => _address ?? string.Empty;
        set => _address = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    
    public TypeOfDelivery Delivery {get; set;}
    public OrderState State {get; set;}

}