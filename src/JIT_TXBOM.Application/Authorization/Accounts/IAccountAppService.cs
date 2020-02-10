using System.Threading.Tasks;
using Abp.Application.Services;
using JIT_TXBOM.Authorization.Accounts.Dto;

namespace JIT_TXBOM.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
