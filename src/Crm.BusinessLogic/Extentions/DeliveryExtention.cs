using Crm.DataAccess;

namespace Crm.BusinessLogic;

public static class DeliveryExtension
{
    public static DeliveryType ToDeliveryEnum(this string deliveryStr)
        => Enum.Parse<DeliveryType>(deliveryStr);
}