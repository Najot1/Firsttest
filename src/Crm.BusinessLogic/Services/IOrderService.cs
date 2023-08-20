using Crm.DataAccess;

namespace Crm.BusinessLogic;

public interface IOrderService
{
    public Order CreateOrder(OrderInfo orderInfo);
    public Order? FindOrder(string description);
    public Order? ChangeOrder(int orderId, string newDescrition);
    public Order? RemoveOrder(int orderId);
    public Order? SetState(OrderState orderState, int orderId);
    public int ShowOrderCount();
    public int ShowOrderPending();
    public int ShowOrderApproved();
    public int ShowOrderCancelled();

}
