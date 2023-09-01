using Crm.DataAccess;

namespace Crm.BusinessLogic;


public sealed class ClientService : IClientService
{
    private readonly IClientRepository _clientRepository;

    public ClientService(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public bool CreateClient(Client client)
    {
        return _clientRepository.CreateClient(client);
    }
    public bool FindClient(string firstName, string lastName)
    {
        return _clientRepository.FindClient(firstName, lastName);
    }

    public bool EditClient(string newFirstName, string newLastName, long clientId)
    {
        return _clientRepository.EditClient(newFirstName, newLastName, clientId);
    }

   public bool RemoveClient(string firstName, string lastName)
    {
        return _clientRepository.RemoveClient(firstName, lastName);
    }
    
}