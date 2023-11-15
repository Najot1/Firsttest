namespace Crm.BusinessLogic;

public readonly record struct OrderInfo(
    long Id,
    string Description,
    decimal Price,
    string DeliveryId,
    string State);