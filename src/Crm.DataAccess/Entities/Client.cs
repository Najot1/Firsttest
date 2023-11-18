namespace Crm.DataAccess;

public sealed class Client
{
    public Client(long id, string firstName, string lastName, string middleName, string phone, string passportNumber, short age, Gender gender)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
        Phone = phone;
        PassportNumber = passportNumber;
        Age = age;
    }

    public long Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? MiddleName { get; set; }
    public string Phone { get; set; } = string.Empty;
    public string? PassportNumber { get; set; }
    public short Age { get; set; }
    public Gender Gender { get; set; }

    public ICollection<Order>? Orders { get; set; }
    
}
