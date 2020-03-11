using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Runtime.Caching.Redis;
using AutoMapper;
using AutoMapper.Configuration;
using JIT_TXBOM.CommonClass;
using JIT_TXBOM.Configuration;

namespace JIT_TXBOM.Web.Host.Startup
{
    [DependsOn(
       typeof(JIT_TXBOMWebCoreModule),typeof(AbpRedisCacheModule))]
    public class JIT_TXBOMWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public JIT_TXBOMWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {

            //Configuration.Caching.UseRedis(option =>
            //{
            //    option.ConnectionString = _appConfiguration["Redis:ConnectionString"];
            //    option.DatabaseId = _appConfiguration["Redis:DatabaseID"].ToInt();
            //});

            Configuration.Caching.ConfigureAll(cache =>
            {
                cache.DefaultSlidingExpireTime = TimeSpan.FromMinutes(1);
            });

            

            base.PreInitialize();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(JIT_TXBOMWebHostModule).GetAssembly());
        }
    }
}
