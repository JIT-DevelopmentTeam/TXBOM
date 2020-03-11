using System;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using JIT_TXBOM.Authorization;

namespace JIT_TXBOM
{
    [DependsOn(
        typeof(JIT_TXBOMCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class JIT_TXBOMApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<JIT_TXBOMAuthorizationProvider>();

            
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(JIT_TXBOMApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
