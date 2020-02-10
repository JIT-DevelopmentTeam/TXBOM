using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using JIT_TXBOM.Authorization.Users;
using JIT_TXBOM.Editions;

namespace JIT_TXBOM.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
