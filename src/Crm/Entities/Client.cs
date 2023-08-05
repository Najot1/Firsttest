
namespace Crm.Entities;


public sealed class Client  
{
    private readonly string _firstName;
    public required string FirstName
     { 
        get => _firstName ?? string.Empty;
        init => _firstName = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }

    private readonly string _lastName;
    public required string LastName 
    { 
        get => _lastName ?? string.Empty;
        init => _lastName = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
  
    private readonly string _middleName;
    public required string MiddleName
     { 
        get => _middleName ?? string.Empty;
        init => _middleName = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }

      private readonly short _age;
      public required short Age
      {
        get => _age;
        init => _age = value >= 18 ? value : throw new ArgumentOutOfRangeException(nameof(value));
      }

    private readonly string _passportNumber;
    public required string PassportNumber
    {
        get => _passportNumber ?? string.Empty;
        init => _passportNumber = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
   
    
    public required Gender Gender {get ; set ;}
  

    private readonly string _phone;
    public required string Phone
    {
      get => _phone ?? string.Empty;
      init => _phone = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }

    private readonly string _email;
    public required string Email
    {
      get => _email ?? string.Empty;
      init => _email = value is { Length: > 0} ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }

    private readonly string _password;
    public required string Password
    {
      get => _password ?? string.Empty;
      init => _password = value is { Length: > 0} ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
}
