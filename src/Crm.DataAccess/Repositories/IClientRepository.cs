namespace Crm.DataAccess;

public interface IClientRepository
{
    ValueTask<bool> CreateClientAsync(Client client, CancellationToken token = default);
    ValueTask<bool> FindClientAsync(string firstName, string lastName, CancellationToken token = default);
    ValueTask<bool> EditClientAsync(string newFirstName, string newLastName, long clientId, CancellationToken token = default);
    ValueTask<bool> RemoveClientAsync(long clientId, CancellationToken token = default);
    ValueTask<int> GetClientCountAsync( CancellationToken token = default);
}

