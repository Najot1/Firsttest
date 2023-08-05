using Crm.Entities;

namespace Crm.Services;

public sealed class OrderService
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
    public void FindOrder(List<Order> orderList)
    {
    
        foreach (Order order in orderList)
        {
            Console.WriteLine(order);
        }
    }

    internal void FindOrder()
    {
        throw new NotImplementedException();
    }
}

abstract class DoSthOrder
{
    public void DoSthWithOrder()
    {

    }
}