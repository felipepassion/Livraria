namespace Niu.Nutri.Users.Enumerations
{
    public enum UserRole : uint
    {
        ADMIN = 0,
        USER = 1,
        SUPPORT = 2,
    }

    public static class UserRoleExtensions
    {
        public static string ToFriendlyString(this UserRole role)
        {
            switch (role)
            {
                case UserRole.ADMIN:
                    return "Admin";
                case UserRole.USER:
                    return "User";
                case UserRole.SUPPORT:
                    return "Support";
                default:
                    return "Unknown";
            }
        }
    }
}