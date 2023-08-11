using Crm.Entities;

namespace Crm;

public struct OrderInfo
{
    public int ID {get; set;}
    public string Description { get; set; }
    public short Price { get; set; }
    public string Date { get; set; }
    public string Address { get; set; }
    public TypeOfDelivery Delivery { get; set; }
}