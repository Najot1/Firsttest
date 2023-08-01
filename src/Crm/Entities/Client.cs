
namespace Crm.Entities;


public sealed class Client  
{
  
    public required string FirstName
     { 
        get => FirstName ?? string.Empty;
        init => FirstName = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
  
    public required string LastName 
    { 
        get => LastName ?? string.Empty;
        init => LastName = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
  
    public required string MiddleName
     { 
        get => MiddleName ?? string.Empty;
        init => MiddleName = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
      public required short Age
      {
        get => Age;
        set => Age = value >= 18 ? value : throw new ArgumentOutOfRangeException(nameof(value));
      }

    public required string PassportNumber
    {
        get => PassportNumber ?? string.Empty;
        init => PassportNumber = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
   
 
    public required Gender Gender { get; set; }
 public required string Phone
    {
      get => Phone ?? string.Empty;
      init => Phone = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public required string Email
    {
      get => Email ?? string.Empty;
      set => Email = value is { Length: > 0} ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public required string Password
    {
      get => Password ?? string.Empty;
      set => Password = value is { Length: > 0} ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
}
