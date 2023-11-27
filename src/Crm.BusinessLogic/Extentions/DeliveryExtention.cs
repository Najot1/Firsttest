using Crm.DataAccess;

namespace Crm.BusinessLogic;

public static class DeliveryExtension
{
    public static DeliveryType ToDeliveryEnum(this string delivery)
        => Enum.Parse<DeliveryType>(delivery);
}