using Crm.Entities;

namespace Crm.Services;

public interface IClientService
{
    public Client CreateClient(ClientInfo clientInfo);
    public Client FindClient(string firstName, string lastName);
    public Client ChangeClient(string newFirstName, string newLastName, int clientId);
    public Client RemoveClient(string removeClient, int clientId);

}
