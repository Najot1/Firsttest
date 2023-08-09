using Crm.Entities;

namespace Crm.Services;

public interface IOrderService
{
    public Order CreateOrder(OrderInfo orderInfo);
    public Order FindOrder(string id, string description);
    public Order ChangeOrder(string newDescrition, int orderId);
    public Order RemoveOrder(string removeOrder, int orderId);

}
