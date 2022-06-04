using Abp.Authorization;
using sample.Authorization.Roles;
using sample.Authorization.Users;

namespace sample.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
