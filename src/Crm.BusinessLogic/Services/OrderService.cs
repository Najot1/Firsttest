using Crm.DataAccess;

namespace Crm.BusinessLogic;

public sealed class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public ValueTask<bool> CreateOrderAsync(OrderInfo orderInfo, CancellationToken token = default)
    {
        return _orderRepository.CreateOrderAsync(orderInfo.ToOrder(), token);
    }

    public ValueTask<bool> FindOrderAsync(string description, CancellationToken token = default)
    {
        return _orderRepository.FindOrderAsync(description, token);
    }

    public ValueTask<bool> EditOrderAsync(long orderId, string newDescrition, CancellationToken token = default)
    {
        return _orderRepository.EditOrderAsync(orderId, newDescrition, token);
    }

    public ValueTask<bool> RemoveOrderAsync(long orderId, CancellationToken token = default)
    {
        return _orderRepository.RemoveOrderAsync(orderId, token);
    }

    public ValueTask<bool> UpdateOrderStateAsync(OrderState orderState, long orderId, CancellationToken token = default)
    {
        return _orderRepository.UpdateOrderStateAsync(orderState, orderId, token);
    }
}