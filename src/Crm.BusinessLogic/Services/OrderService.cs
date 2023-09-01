using Crm.DataAccess;

namespace Crm.BusinessLogic;

public sealed class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public bool CreateOrder(Order order)
    {
        return _orderRepository.CreateOrder(order);
    }

    public bool FindOrder(string description)
    {
        return _orderRepository.FindOrder(description);
    }

    public bool EditOrder(long orderId, string newDescrition)
    {
       return _orderRepository.EditOrder(orderId, newDescrition);
    }

    public bool RemoveOrder(long orderId)
    {
        return _orderRepository.RemoveOrder(orderId);
    }

    public bool UpdateOrderState(OrderState newOrderState, long orderId)
    {
        return _orderRepository.UpdateOrderState(newOrderState, orderId);
    }

}