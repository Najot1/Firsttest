using Crm.DataAccess;

namespace Crm.BusinessLogic;

public interface IClientService
{
    ValueTask<bool> CreateClientAsync(ClientInfo clientInfo, CancellationToken token = default);
    ValueTask<bool> FindClientAsync(string firstName, string lastName, CancellationToken token = default);
    ValueTask<bool> EditClientAsync(string newFirstName, string newLastName, long clientId, CancellationToken token = default);
    ValueTask<bool> RemoveClientAsync(long clientId, CancellationToken token = default);
}
