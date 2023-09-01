namespace Crm.DataAccess;

public readonly record struct OrderInfo(
    long Id,
    string Description,
    decimal Price,
    string Date,
    string Address,
    string Delivery,
    string State);