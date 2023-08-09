using Crm.Entities;

namespace Crm.Services;

public sealed class OrderService : IOrderService
{
    private readonly List<Order> orderList = new();
    public Order CreateOrder(OrderInfo orderInfo)
    {
        Order order = new()
         {
            Id = orderInfo.GetId(),
            Description = orderInfo.Description,
            Price = orderInfo.Price,
            Date = orderInfo.Date,
            Address = orderInfo.Address,
            Delivery = orderInfo.Delivery
        };
         orderList.Add(order);
        
        return order; 
       
    }
    public Order FindOrder(string id, string description)
    {
        if (id is not {Length: > 0}) throw new ArgumentNullException(nameof(id));
        if (description is not {Length: > 0}) throw new ArgumentNullException(nameof(description));
    
        foreach (Order order in orderList)
        {
            if (order.Id.Equals(id) && order.Description.Equals(description))
            return order; 
        }

        throw new Exception("Order was not found!");
    }

    public Order ChangeOrder(string newDescrition, int orderId)
    {
        if (newDescrition is not {Length: > 0}) throw new ArgumentNullException(nameof(newDescrition));
        foreach (Order order in orderList)
        {
            if (order.ID == orderId)
            {
                order.Description = newDescrition;
            }
        }

        throw new Exception("Description was not changed!");
    }

    public Order RemoveOrder(string removeOrder, int orderId)
    {
        if (removeOrder is not {Length: > 0}) throw new ArgumentNullException(nameof(removeOrder));
        Order order1;
        if (removeOrder.Equals("Remove Order"))
        {

            foreach (Order order in orderList)
            {
                if (order.ID == orderId)
                {
                    order1 = order;
                    orderList.Remove(order);
                }
            }
        }

        throw new Exception("Order was not removed!");
    }

}