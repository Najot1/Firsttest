using Crm.Entities;

namespace Crm.Services;

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
            Delivery = orderInfo.Delivery
        };
         orderList.Add(order);
        
        return order; 
       
    }
    public Order FindOrder(int id, string description)
    {
        if (id is >= 0) throw new ArgumentNullException(nameof(id));
        if (description is not {Length: > 0}) throw new ArgumentNullException(nameof(description));
    
        foreach (Order order in orderList)
        {
            if (order.ID.Equals(id) && order.Description.Equals(description))
            return order; 
        }

        throw new Exception("Order was not found!");
    }

    public Order? ChangeOrder(string newDescrition, int orderId)
    {
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
            Console.WriteLine("Order Removed!");
        }

        return null;
    }

}