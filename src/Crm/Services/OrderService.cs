using Crm.Entities;

namespace Crm.Services;

public sealed class OrderService
{
    public Order CreateOrder(OrderInfo orderInfo)
    {

        return new()
        {
            Id = orderInfo.Id,
            Description = orderInfo.Description,
            Price = orderInfo.Price,
            Date = orderInfo.Date,
            Address = orderInfo.Address,
            Delivery = orderInfo.Delivery
        };
    }
}