using Crm.DataAccess;

namespace Crm.BusinessLogic;

public static  class ClientInfoExtension
{
    public static Client ToClient(this ClientInfo clientInfo)
    {
        return new(
            clientInfo.Id,
            clientInfo.FirstName,
            clientInfo.LastName,
            clientInfo.MiddleName!,
            clientInfo.Phone,
            clientInfo.PassportNumber!,
            clientInfo.Age,
            clientInfo.Gender.ToGenderEnum()
            );
    }
}