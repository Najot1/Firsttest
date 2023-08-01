
using Crm.Entities;

namespace Crm;

public readonly struct ClientInfo 
{
    public readonly string FirstName { get; init; }
    public readonly string LastName { get; init; }
    public readonly string MiddleName { get; init; }
    public readonly short Age { get; init; }
    public readonly string PassportNumber { get; init; }
    public readonly Gender Gender { get; init; }
    public readonly string Phone { get; init; }
    public readonly string Email { get; init; }
    public readonly string Password { get; init; }
}