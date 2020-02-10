using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using JIT_TXBOM.Configuration;

namespace JIT_TXBOM.Web.Host.Startup
{
    [DependsOn(
       typeof(JIT_TXBOMWebCoreModule))]
    public class JIT_TXBOMWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public JIT_TXBOMWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(JIT_TXBOMWebHostModule).GetAssembly());
        }
    }
}
