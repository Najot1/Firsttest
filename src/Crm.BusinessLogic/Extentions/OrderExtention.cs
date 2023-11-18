using Crm.DataAccess;

namespace Crm.BusinessLogic;

public static class OrderExtension
{
    public static Order ToOrder(this OrderInfo orderInfo)
    {
        return new(
            orderInfo.Id,
            orderInfo.Description,
            orderInfo.Price,
            orderInfo.Address,
            orderInfo.Delivery.ToDeliveryEnum(),
            orderInfo.State.ToStateEnum());
    }
}