
namespace Crm.DataAccess;

public sealed class ClientRepository : IClientRepository
{
    private readonly List<Client> _clients;
    private long _id = 0;

    public ClientRepository()
    {
        _clients = new List<Client>();
    }
    public bool CreateClient(Client client)
    {
        Client newClient = new()
        {
            Id = _id++,
            FirstName = client.FirstName,
            LastName = client.LastName,
            MiddleName = client.MiddleName,
            Age = client.Age,
            PassportNumber = client.PassportNumber,
            Gender = client.Gender
        };

        _clients.Add(newClient);

        return true;
    }

    public bool FindClient(string firstName, string lastName)
    {
        Client? client = _clients.Find(c => c.FirstName.Equals(firstName) && c.LastName.Equals(lastName));

        return true;
    }

    public bool EditClient(string newFirstName, string newLastName, long clientId)
    {
        Client? client = _clients.Find(c => c.Id == clientId);
        if (client is null) return false;

        client.FirstName = newFirstName;
        client.LastName = newLastName;

        return true;
    }


     public bool RemoveClient(string firstName, string lastName)
    {
        int clientIndex = _clients.FindIndex(c => c.FirstName.Equals(firstName) && c.LastName.Equals(lastName));
        if (clientIndex < 0)
            return false;

        _clients.RemoveAt(clientIndex);
        
        return true;
    }
    public int GetClientCount() => _clients.Count;

    public ValueTask<bool> CreateClientAsync(Client client, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> FindClientAsync(string firstName, string lastName, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> EditClientAsync(string newFirstName, string newLastName, long clientId, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<bool> RemoveClientAsync(string firstName, string lastName, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<int> GetClientCountAsync(CancellationToken token = default)
    {
        throw new NotImplementedException();
    }
}

