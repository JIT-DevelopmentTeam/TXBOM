using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Runtime.Caching;

namespace JIT_TXBOM.ImportBusiness.K3ApiUrl
{
    /// <summary>
    /// 连接管理接口
    /// </summary>
    public class K3ApiUrlAppServices:CrudAppService<K3APIUrl.K3ApiUrl,K3ApiUrlDTO>
    {
        private IK3ApiUrlCache cache;
        private ICacheManager cacheManager;

        public K3ApiUrlAppServices(IRepository<K3APIUrl.K3ApiUrl, int> repository,IK3ApiUrlCache cache,ICacheManager cacheManager) : base(repository)
        {
            this.cache = cache;
            this.cacheManager = cacheManager;
        }

        
        

    }
}
