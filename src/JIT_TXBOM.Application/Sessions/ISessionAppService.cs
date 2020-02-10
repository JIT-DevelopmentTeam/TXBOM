using System.Threading.Tasks;
using Abp.Application.Services;
using JIT_TXBOM.Sessions.Dto;

namespace JIT_TXBOM.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
