
namespace Crm.DataAccess;

public sealed class EfCoreClientRepository : IClientRepository
{
    private readonly CrmDbContext _db;

    public EfCoreClientRepository(CrmDbContext crmDbContext)
    {
        _db = crmDbContext;
    }

    public EfCoreClientRepository()
    {
        _db = new();
    }
    public async ValueTask<bool> CreateClientAsync(Client client, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> EditClientAsync(string newFirstName, string newLastName, long clientId, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> FindClientAsync(string firstName, string lastName, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<int> GetClientCountAsync(CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> RemoveClientAsync(string firstName, string lastName, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }
}