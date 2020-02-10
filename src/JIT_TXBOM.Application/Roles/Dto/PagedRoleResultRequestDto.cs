using Abp.Application.Services.Dto;

namespace JIT_TXBOM.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

