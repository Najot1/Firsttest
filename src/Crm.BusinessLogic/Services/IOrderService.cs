using Crm.DataAccess;

namespace Crm.BusinessLogic;

public interface IOrderService
{
    ValueTask<bool> CreateOrderAsync(Order order, CancellationToken token = default);
    ValueTask<bool> FindOrderAsync(string description, CancellationToken token = default);
    ValueTask<bool> EditOrderAsync(long orderId, string newDescrition, CancellationToken token = default);
    ValueTask<bool> RemoveOrderAsync(long orderId, CancellationToken token = default);
    ValueTask<bool> UpdateOrderStateAsync(OrderState orderState, long orderId, CancellationToken token = default);
}
