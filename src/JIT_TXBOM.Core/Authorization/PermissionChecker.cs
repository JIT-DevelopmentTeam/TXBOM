using Abp.Authorization;
using JIT_TXBOM.Authorization.Roles;
using JIT_TXBOM.Authorization.Users;

namespace JIT_TXBOM.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
