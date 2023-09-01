namespace Crm.BusinessLogic;

public readonly record struct ClientInfo(
    long Id,
    string FirstName,
    string LastName,
    string MiddleName,
    string PassportNumber,
    short Age,
    string Gender,
    string Phone,
    string Email,
    string Password);