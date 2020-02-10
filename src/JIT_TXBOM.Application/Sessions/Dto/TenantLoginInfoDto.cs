using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using JIT_TXBOM.MultiTenancy;

namespace JIT_TXBOM.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
