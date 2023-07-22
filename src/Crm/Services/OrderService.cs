using Crm.Entities;

namespace Crm.Services;

public sealed class OrderService
{
    public Order CreateOrder(
        string Id,
        string Description,
        short Price,
        string Date,
        string Address,
        TypeOfDelivery Delivery
    )
    {
        // TODO: Validate input parameters.
        return new()
        {
            Id = Id,
            Description = Description,
            Price = Price,
            Date = Date,
            Address = Address,
            Delivery = Delivery
        };
    }
}