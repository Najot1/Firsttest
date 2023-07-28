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
}
