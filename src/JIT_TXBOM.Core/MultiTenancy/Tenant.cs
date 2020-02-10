using Abp.MultiTenancy;
using JIT_TXBOM.Authorization.Users;

namespace JIT_TXBOM.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
