using Crm.DataAccess;

namespace Crm.BusinessLogic;

public interface IOrderService
{
    public bool CreateOrder(Order order);
    public bool FindOrder(string description);
    public bool EditOrder(long orderId, string newDescrition);
    public bool RemoveOrder(long orderId);
    public bool UpdateOrderState(OrderState orderState, long orderId);

}
