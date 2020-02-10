using Abp.Application.Services;
using Abp.Application.Services.Dto;
using JIT_TXBOM.MultiTenancy.Dto;

namespace JIT_TXBOM.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

