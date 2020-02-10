using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using JIT_TXBOM.Configuration;
using JIT_TXBOM.EntityFrameworkCore;
using JIT_TXBOM.Migrator.DependencyInjection;

namespace JIT_TXBOM.Migrator
{
    [DependsOn(typeof(JIT_TXBOMEntityFrameworkModule))]
    public class JIT_TXBOMMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public JIT_TXBOMMigratorModule(JIT_TXBOMEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(JIT_TXBOMMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                JIT_TXBOMConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(JIT_TXBOMMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
