using System.Threading.Tasks;
using JIT_TXBOM.Configuration.Dto;

namespace JIT_TXBOM.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
