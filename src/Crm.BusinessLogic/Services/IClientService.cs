using Crm.DataAccess;

namespace Crm.BusinessLogic;

public interface IClientService
{
    public ValueTask<bool> CreateClientAsync(Client client, CancellationToken token = default);
    public ValueTask<bool> FindClientAsync(string firstName, string lastName, CancellationToken token = default);
    public ValueTask<bool> EditClientAsync(string newFirstName, string newLastName, long clientId, CancellationToken token = default);
    public ValueTask<bool> RemoveClientAsync(string firstName, string lastName, CancellationToken token = default);
    
}
