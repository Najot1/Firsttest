using Crm.DataAccess;

namespace Crm.BusinessLogic;

public static class ClientExtension
{
    public static ClientInfo ToClientInfo(this Client client)
    {
        return new(
            client.Id,
            client.FirstName,
            client.LastName,
            client.MiddleName,
            client.PassportNumber,
            client.Age,
            client.Gender.ToString(),
            client.Phone,
            client.Email,
            client.Password);
    }
}