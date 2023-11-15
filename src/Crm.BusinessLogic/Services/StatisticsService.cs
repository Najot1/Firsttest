using Crm.DataAccess;

namespace Crm.BusinessLogic;

public sealed class StatisticsService : IStatisticsService
{
    private readonly IOrderRepository _orderRepository;
    private readonly IClientRepository _clientRepository;

    public StatisticsService(IOrderRepository orderRepository, IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
        _orderRepository = orderRepository;
    }

    public ValueTask<int> GetClientCountAsync(CancellationToken token = default)
    {
       return _clientRepository.GetClientCountAsync(token);
    }

    public ValueTask<int> GetOrderCountAsync(CancellationToken token = default)
    {
        return _orderRepository.GetOrderCountAsync(token);
    }

    public ValueTask<int> GetOrderCountAsync(OrderState orderState, CancellationToken token = default)
    {
        return _orderRepository.GetOrderCountAsync(orderState, token);
    }
}