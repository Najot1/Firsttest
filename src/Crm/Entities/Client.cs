
namespace Crm.Entities;


public sealed class Client  
{
  public int ID {get; set;}
  private string? _firstName;
  public required string FirstName
  { 
    get => _firstName ?? string.Empty;
    set => _firstName = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
  }

    private string? _lastName;
    public required string LastName 
    { 
        get => _lastName ?? string.Empty;
        set => _lastName = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
  
    private string? _middleName;
    public required string MiddleName
     { 
        get => _middleName ?? string.Empty;
        set => _middleName = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }

      private short _age;
      public required short Age
      {
        get => _age;
        set => _age = value >= 18 ? value : throw new ArgumentOutOfRangeException(nameof(value));
      }

    private string? _passportNumber;
    public required string PassportNumber
    {
        get => _passportNumber ?? string.Empty;
        set => _passportNumber = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
   
    
    public required Gender Gender {get ; set ;}
  

    private string? _phone;
    public required string Phone
    {
      get => _phone ?? string.Empty;
      set => _phone = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }

    private string? _email;
    public required string Email
    {
      get => _email ?? string.Empty;
      set => _email = value is { Length: > 0} ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }

    private string? _password;
    public required string Password
    {
      get => _password ?? string.Empty;
      set => _password = value is { Length: > 0} ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }

}
