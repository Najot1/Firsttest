using Crm.DataAccess;

namespace Crm.BusinessLogic;

public static class GenderExtension
{
    public static Gender ToGenderEnum(this string gender)
        => Enum.Parse<Gender>(gender);
}