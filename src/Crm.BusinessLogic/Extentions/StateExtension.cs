using Crm.DataAccess;

namespace Crm.BusinessLogic;

public static class StateExtension
{
    public static OrderState ToStateEnum(this string state)
        => Enum.Parse<OrderState>(state);
}