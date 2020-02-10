using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using JIT_TXBOM.EntityFrameworkCore.Seed;

namespace JIT_TXBOM.EntityFrameworkCore
{
    [DependsOn(
        typeof(JIT_TXBOMCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class JIT_TXBOMEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<JIT_TXBOMDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        JIT_TXBOMDbContextConfigurer.ConfigureMySQL(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        JIT_TXBOMDbContextConfigurer.ConfigureMySQL(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(JIT_TXBOMEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
