namespace Crm.DataAccess;

public interface IClientRepository
{
    bool CreateClient(Client client);
    bool FindClient(string firstName, string lastName);
    bool EditClient(string newFirstName, string newLastName, long clientId);
    bool RemoveClient(string firstName, string lastName);
    int GetClientCount();
}

