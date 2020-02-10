using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace JIT_TXBOM.Controllers
{
    public abstract class JIT_TXBOMControllerBase: AbpController
    {
        protected JIT_TXBOMControllerBase()
        {
            LocalizationSourceName = JIT_TXBOMConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
