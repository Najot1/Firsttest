using Crm.DataAccess;

namespace Crm.BusinessLogic;

public static class OrderExtension
{
    public static OrderInfo ToOrderInfo(this Order order)
    {
        return new(
            order.Id,
            order.Description,
            order.Price,
            order.Date,
            order.Address,
            order.Delivery.ToString(),
            order.State.ToString());
    }
}