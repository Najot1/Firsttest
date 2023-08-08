using Crm.Entities;

namespace Crm.Services;

public sealed class OrderService : IOrderService
{
    private readonly List<Order> orderList = new();
    public Order CreateOrder(OrderInfo orderInfo)
    {
        Order order = new()
         {
            Id = orderInfo.Id,
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

    public Order ChangeOrder(string newDescrition)
    {
        if (newDescrition is not {Length: > 0}) throw new ArgumentNullException(nameof(newDescrition));
        foreach (Order order in orderList)
        {
            newDescrition =  order.Description;
          
            return order;
        }

        throw new Exception("Description was not changed!");
    }

    public Order RemoveOrder(string removeOrder)
    {
        if (removeOrder is not {Length: > 0}) throw new ArgumentNullException(nameof(removeOrder));
        foreach (Order order in orderList)
        if (removeOrder.Equals("Remove Order")) orderList.Remove(order);

        throw new Exception("Order was not removed!");
    }

}