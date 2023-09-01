using Crm.DataAccess;

namespace Crm.BusinessLogic;

public interface IClientService
{
    public bool CreateClient(Client client);
    public bool FindClient(string firstName, string lastName);
    public bool EditClient(string newFirstName, string newLastName, long clientId);
    public bool RemoveClient(string firstName, string lastName);
}
