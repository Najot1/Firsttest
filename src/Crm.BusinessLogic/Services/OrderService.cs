using Crm.DataAccess;

namespace Crm.BusinessLogic;

public sealed class OrderService : IOrderService
{
    private readonly List<Order> orderList = new();
    public Order CreateOrder(OrderInfo orderInfo)
    {
        Order order = new()
        {
            ID = orderInfo.ID,
            Description = orderInfo.Description,
            Price = orderInfo.Price,
            Date = orderInfo.Date,
            Address = orderInfo.Address,
            Delivery = orderInfo.Delivery,
            State = orderInfo.State
        };
    
        orderList.Add(order);
        
        return order;
       
    }
    public Order? FindOrder(int orderId, string description)
    {
        if (orderId is <= 0) throw new ArgumentNullException(nameof(orderId));
        if (description is not {Length: > 0}) throw new ArgumentNullException(nameof(description));
    
        foreach (Order order in orderList)
        {
            if (order.ID.Equals(orderId) && order.Description.Equals(description))
            return order; 
        }

        return null;
    }

    public Order? ChangeOrder(string newDescrition, int orderId)
    {
        if (orderId is <= 0) throw new ArgumentNullException(nameof(orderId));
        if (newDescrition is not {Length: > 0}) throw new ArgumentNullException(nameof(newDescrition));
        foreach (Order order in orderList)
        {
            if (order.ID == orderId)
            {
                order.Description = newDescrition;
                return order;
            }
        }

        return null;
    }

    public Order? RemoveOrder(string removeOrder, int orderId)
    {
        if (orderId is <= 0) throw new ArgumentNullException(nameof(orderId));
        if (removeOrder is not {Length: > 0}) throw new ArgumentNullException(nameof(removeOrder));
        Order? orderToDelete = null;

        foreach (Order order in orderList)
        {
            if (order.ID == orderId)
            {
                orderToDelete = order;
                break;
            }
        }
        if (orderToDelete != null)
        {
            orderList.Remove(orderToDelete);
        }

        return null;
    }

    public Order? SetState(OrderState newOrderState, int orderId)
    {
        if (orderId is <= 0) throw new ArgumentNullException(nameof(orderId));
        foreach (Order order in orderList)
        {
            if (order.ID == orderId)
            {
                order.State = newOrderState;
                return order;
            }
        }
        return null;
    }

    public int ShowOrderCount()
    {
        int counter2 = 0;
        foreach (Order order in orderList)
        {
            if (order.ID >= 1 ) 
                counter2++;
        }
        return counter2;
    
    }
    public int ShowOrderPending()
    {
        int counter3 = 0;
        foreach (Order order in orderList)
        {
            if (order.State == OrderState.Pending)
                counter3++;
        }
        return counter3;
    }
    public int ShowOrderApproved()
    {
        int counter4 = 0;
        foreach (Order order in orderList)
        {
            if (order.State == OrderState.Approved)
                counter4++;
        }
        return counter4;
    }
    public int ShowOrderCancelled()
    {
        int counter5 = 0;
        foreach (Order order in orderList)
        {
            if (order.State == OrderState.Cancelled)
                counter5++;
        }
        return counter5;
    }

}