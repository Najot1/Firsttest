namespace Crm.DataAccess;

public interface IOrderRepository
{
    bool CreateOrder(Order order);

    bool FindOrder(string description);
    bool EditOrder(long orderId, string newDescrition);
    bool RemoveOrder(long orderId);
    bool UpdateOrderState(OrderState orderState, long orderId);
    int GetOrderCount();
    int GetOrderCount(OrderState orderState);
}
