using Microsoft.EntityFrameworkCore;
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
        await _db.Clients.AddAsync(client, token);
        return await _db.SaveChangesAsync(token) > 0;
    }

    public async ValueTask<bool> EditClientAsync(string newFirstName, string newLastName, long clientId, CancellationToken token = default)
    {
        Client client = await _db.Clients.SingleAsync(c => c.Id == clientId);
        client.FirstName = newFirstName;
        client.LastName = newLastName;
        return await _db.SaveChangesAsync(token) > 0;
    }

    public async ValueTask<bool> FindClientAsync(string firstName, string lastName, CancellationToken token = default)
    {
        Client client = await _db.Clients.SingleAsync(o => o.FirstName == firstName && o.LastName == lastName, token);
        return await _db.SaveChangesAsync(token) > 0;
    }

    public async ValueTask<bool> RemoveClientAsync(long clientId, CancellationToken token = default)
    {
        Client clientIndex = await _db.Clients.SingleAsync(c => c.Id == clientId);
        _db.Clients.Remove(clientIndex);
        return await _db.SaveChangesAsync(token) > 0;
    }

    public ValueTask<int> GetClientCountAsync(CancellationToken token = default)
    {
        return new(_db.Clients.CountAsync(token));
    }

    
}