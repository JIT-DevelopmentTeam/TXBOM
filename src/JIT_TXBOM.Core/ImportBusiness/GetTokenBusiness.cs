using System.Net.Http;
using System.Reflection;
using Abp.Dependency;
using Abp.Domain.Services;
using Abp.Reflection.Extensions;
using JIT_TXBOM.Configuration;

namespace JIT_TXBOM.ImportBusiness
{
    public class GetTokenBusiness:DomainService
    {
        public void TestMethod()
        {
            HttpClient client=new HttpClient();

            var k3ConfigurationSection = AppConfigurations.Get(Assembly.GetExecutingAssembly().GetDirectoryPathOrNull())
                .GetSection("K3ApiConfig");

            //var baseurl = k3ConfigurationSection["BaseUrl"];
            //var authorityCode = k3ConfigurationSection["AuthorityCode"];

            var baseurl = "http://139.9.6.165:800/K3API";
            var authorityCode = "cc7c2a733c0a29ec7fe7894858e9350e3b4660019289b20d";

            var url = $"{baseurl}/Token/Create?authorityCode={authorityCode}";

            var response= client.GetAsync(url).GetAwaiter().GetResult();

            var result= response.Content.ReadAsStringAsync();

        }
    }
}