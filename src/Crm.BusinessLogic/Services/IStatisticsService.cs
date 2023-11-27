using Crm.DataAccess;

namespace Crm.BusinessLogic;

public interface IStatisticsService
{
    public ValueTask<int> GetClientCountAsync( CancellationToken token = default);
    public ValueTask<int> GetOrderCountAsync( CancellationToken token = default);
    public ValueTask<int> GetOrderCountAsync(OrderState orderState, CancellationToken token = default);  
}
