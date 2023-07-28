using Crm.Entities;

namespace Crm;

public readonly struct OrderInfo
{
    public readonly string Id { get; init; }
    public readonly string Description { get; init; }
    public readonly short Price { get; init; }
    public readonly string Date { get; init; }
    public readonly string Address { get; init; }
    public readonly TypeOfDelivery Delivery { get; init; }
}