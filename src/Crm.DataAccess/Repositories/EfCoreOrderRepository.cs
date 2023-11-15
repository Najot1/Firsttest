namespace Crm.DataAccess;
public sealed class EfCoreOrderRepository : IOrderRepository 
{ 
    private readonly CrmDbContext _db;

    public EfCoreOrderRepository(CrmDbContext crmDbContext)
    {
        _db = crmDbContext;
    }

    public EfCoreOrderRepository()
    {
        _db = new();
    }
    public async ValueTask<bool> CreateOrderAsync(Order order, CancellationToken token = default)
    {

        throw new NotImplementedException();
    }

    public async ValueTask<bool> FindOrderAsync(string description, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public async ValueTask<bool> EditOrderAsync(long orderId, string newDescrition, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public async ValueTask<bool> RemoveOrderAsync(long orderId, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public async ValueTask<bool> UpdateOrderStateAsync(OrderState orderState, long orderId, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public async ValueTask<int> GetOrderCountAsync(CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public async ValueTask<int> GetOrderCountAsync(OrderState orderState, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }
}