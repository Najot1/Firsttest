using Microsoft.EntityFrameworkCore;

namespace Crm.DataAccess;
public sealed class EfCoreOrderRepository : IOrderRepository 
{ 
    private readonly CrmDbContext _db;

    public EfCoreOrderRepository(CrmDbContext crmDbContext)
    {
        _db = crmDbContext;
    }

    public async ValueTask<bool> CreateOrderAsync(Order order, CancellationToken token = default)
    {

        await _db.Orders.AddAsync(order, token);
        return await _db.SaveChangesAsync(token) > 0;
    }

    public async ValueTask<bool> FindOrderAsync(string description, CancellationToken token = default)
    {
        Order order = await _db.Orders.SingleAsync(o => o.Description == description, token);
        return await _db.SaveChangesAsync(token) > 0;
    }

    public async ValueTask<bool> EditOrderAsync(long orderId, string newDescrition, CancellationToken token = default)
    {
        Order order = await _db.Orders.SingleAsync(c => c.Id == orderId);
        order.Description = newDescrition;
        return await _db.SaveChangesAsync(token) > 0;
    }

    public async ValueTask<bool> RemoveOrderAsync(long orderId, CancellationToken token = default)
    {
        Order orderIndex = await _db.Orders.SingleAsync(c => c.Id == orderId);
        _db.Orders.Remove(orderIndex);
        return await _db.SaveChangesAsync(token) > 0;
    }

    public async ValueTask<bool> UpdateOrderStateAsync(OrderState orderState, long orderId, CancellationToken token = default)
    {
        Order order = await _db.Orders.SingleAsync(o => o.Id == orderId, token);
        order.State = orderState;
        return await _db.SaveChangesAsync(token) > 0;
    }

    public ValueTask<int> GetOrderCountAsync(CancellationToken token = default)
    {
        return new(_db.Orders.CountAsync(token));
    }

    public ValueTask<int> GetOrderCountAsync(OrderState orderState, CancellationToken token = default)
    {
        return new(_db.Orders.CountAsync(o => o.State == orderState, token));
    }
}