using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using JIT_TXBOM.Configuration.Dto;

namespace JIT_TXBOM.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : JIT_TXBOMAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
