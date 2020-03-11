using Abp.Dependency;
using Abp.Domain.Entities.Caching;
using Abp.Domain.Repositories;
using Abp.Runtime.Caching;

namespace JIT_TXBOM.ImportBusiness.K3ApiUrl
{
    public interface IK3ApiUrlCache:IEntityCache<K3ApiUrlDTO>
    {
        
    }

    public class K3ApiUrlCache:EntityCache<K3APIUrl.K3ApiUrl,K3ApiUrlDTO>,IK3ApiUrlCache,ISingletonDependency
    {
        public K3ApiUrlCache(ICacheManager cacheManager, IRepository<K3APIUrl.K3ApiUrl, int> repository, string cacheName = null) : base(cacheManager, repository, cacheName)
        {
        }
    }
}