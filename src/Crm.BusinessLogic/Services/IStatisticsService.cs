using Crm.DataAccess;

namespace Crm.BusinessLogic;

public interface IStatisticsService
{
    public int GetClientCount();
    public int GetOrderCount();
    public int GetOrderCount(OrderState orderState);  
}
