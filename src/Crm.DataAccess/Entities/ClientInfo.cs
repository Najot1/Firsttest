

namespace Crm.DataAccess;

public struct ClientInfo 
{
    public int ID {get; set;}
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public short Age { get; set; }
    public string PassportNumber { get; set; }
    public Gender Gender { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}