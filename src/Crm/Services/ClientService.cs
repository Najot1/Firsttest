using Crm.Entities;

namespace Crm.Services;


public sealed class ClientService 
{

    private readonly List<Client> clientList = new();

    public Client CreateClient(ClientInfo clientInfo)
    {
        Client client = new()
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

        clientList.Add(client);
        
        return client; 
    }

    public void FindClient(List<Client> clientList)
    {
    
        foreach (Client client in clientList)
        {
            Console.WriteLine(client);
        }
    }

    internal void FindClient()
    {
        throw new NotImplementedException();
    }
}

abstract class DoSthClient
{
    public void DoSthWithClient()
    {

    }
}
