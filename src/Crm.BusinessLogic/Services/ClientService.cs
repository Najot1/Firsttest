using Crm.DataAccess;

namespace Crm.BusinessLogic;


public sealed class ClientService : IClientService
{
    private readonly IClientRepository _clientRepository;

    public ClientService(IClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public ValueTask<bool> CreateClientAsync(Client client, CancellationToken token = default)
    {
        return _clientRepository.CreateClientAsync(client.ToClientInfo(), token);
    }

    public ValueTask<bool> FindClientAsync(string firstName, string lastName, CancellationToken token = default)
    {
        return _clientRepository.FindClientAsync(firstName, lastName, token);
    }

    public ValueTask<bool> EditClientAsync(string newFirstName, string newLastName, long clientId, CancellationToken token = default)
    {
        return _clientRepository.EditClientAsync(newFirstName, newLastName, clientId, token);
    }

    public ValueTask<bool> RemoveClientAsync(long clientId, CancellationToken token = default)
    {
        return _clientRepository.RemoveClientAsync(clientId, token);
    }
}