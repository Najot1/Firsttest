
namespace Crm.DataAccess;

public sealed class OrderRepository : IOrderRepository
{
    private readonly List<Order> _orders;
    private long _id = 0;

    public OrderRepository()
    {
        _orders = new List<Order>();   
    }

    public bool CreateOrder(Order order)
    {
        Order newOrder = new()
        {
            Id = _id++,
            Description = order.Description,
            Price = order.Price,
            Delivery = order.Delivery,
            State = order.State
        };
    
        _orders.Add(newOrder);
        
        return true;
    }

    public bool FindOrder(string description)
    {
        Order? order = _orders.Find(c => c.Description.Equals(description));
        return true;
    }

    public bool EditOrder(long orderId, string newDescrition)
    {
        Order? order = _orders.Find(c => c.Id == orderId);
        if (order is null) return false;

        order.Description = newDescrition;

        return true;
    }

    public bool RemoveOrder(long orderId)
    {
        Order? orderIndex = _orders.Find(c => c.Id == orderId);
        if (orderIndex is null) return false;

        _orders.Remove(orderIndex);
        
        return true;
    }

    public int GetOrderCount() => _orders.Count;

    public int GetOrderCount(OrderState orderState) => _orders.Count(o => o.State == orderState);

    public bool UpdateOrderState(OrderState orderState, long orderId)
    {
        Order? order = _orders.Find(o => o.Id == orderId);
        if (order is null) return false;
        
        order.State = orderState;

        return true;
    }

    public ValueTask<bool> CreateOrderAsync(Order order, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> FindOrderAsync(string description, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> EditOrderAsync(long orderId, string newDescrition, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> RemoveOrderAsync(long orderId, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> UpdateOrderStateAsync(OrderState orderState, long orderId, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<int> GetOrderCountAsync(CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<int> GetOrderCountAsync(OrderState orderState, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }
}