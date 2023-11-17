namespace Crm.DataAccess;

public sealed class Order
{
    public long Id { get; set; }
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Address { get; set; } = string.Empty;
    public OrderState State { get; set; }
    public DeliveryType Delivery { get; set; }
   

    public Client? Client { get; set; }
}