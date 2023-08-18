using Crm.DataAccess;

namespace Crm.BusinessLogic;

public interface IOrderService
{
    public Order CreateOrder(OrderInfo orderInfo);
    public Order? FindOrder(int orderId, string description);
    public Order? ChangeOrder(string newDescrition, int orderId);
    public Order? RemoveOrder(string removeOrder, int orderId);
    public Order? SetState( OrderState orderState, int orderId);
    public int ShowOrderCount();
    public int ShowOrderPending();
    public int ShowOrderApproved();
    public int ShowOrderCancelled();

}
