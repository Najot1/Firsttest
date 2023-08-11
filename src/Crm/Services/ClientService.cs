using Crm.Entities;

namespace Crm.Services;


public sealed class ClientService : IClientService
{

    private readonly List<Client> clientList = new();

    public Client CreateClient(ClientInfo clientInfo)
    {
        Client client = new()
        {
            ID = clientInfo.ID,
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

    public Client FindClient(string firstName, string lastName)
    {
        if (firstName is not {Length: > 0}) throw new ArgumentNullException(nameof(firstName));
        if (lastName is not {Length: > 0}) throw new ArgumentNullException(nameof(lastName));
    
        foreach (Client client in clientList)
        {
            if (client.FirstName.Equals(firstName) && client.LastName.Equals(lastName))
            return client; 
        }

        throw new Exception("Client was not found!");
    }

    public Client? ChangeClient(string newFirstName, string newLastName, int clientId)
    {
        if (newFirstName is not {Length: > 0}) throw new ArgumentNullException(nameof(newFirstName));
        if (newLastName is not {Length: > 0}) throw new ArgumentNullException(nameof(newLastName));
        foreach (Client client in clientList)
        {
            if (client.ID == clientId)
            {
                client.FirstName = newFirstName;
                client.LastName = newLastName;
                return client;
            }
        }

        return null;
    }

    public Client? RemoveClient(string removeClient, int clientId)
    {
        if (removeClient is not {Length: > 0}) throw new ArgumentNullException(nameof(removeClient));
        Client? clientToDelete = null;

        foreach (Client client in clientList)
        {
            if (client.ID == clientId ) 
            {
                clientToDelete = client;
                break;
            }
        }
        if (clientToDelete != null)
        {
            clientList.Remove(clientToDelete);
            Console.WriteLine("Client was removed");
        }
        
        return null;
    }
}