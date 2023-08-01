using Crm.Entities;

namespace Crm.Services;


public sealed class ClientService
{

    private List<Client> clientList = new List<Client>();
    
    
    public Client CreateClient(ClientInfo clientInfo)
    {
        
        return new()
        {
            FirstName = clientInfo.FirstName,
            LastName = clientInfo.LastName,
            MiddleName = clientInfo.MiddleName,
            Age = clientInfo.Age,
            PassportNumber = clientInfo.PassportNumber,
            Gender = clientInfo.Gender,
            Phone = clientInfo.Phone,
            Email = clientInfo.Email,
            Password = clientInfo.Password
        };
    }
}


