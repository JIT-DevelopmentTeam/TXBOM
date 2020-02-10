using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using JIT_TXBOM.Configuration;
using JIT_TXBOM.Web;

namespace JIT_TXBOM.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class JIT_TXBOMDbContextFactory : IDesignTimeDbContextFactory<JIT_TXBOMDbContext>
    {
        public JIT_TXBOMDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<JIT_TXBOMDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            JIT_TXBOMDbContextConfigurer.ConfigureMySQL(builder, configuration.GetConnectionString(JIT_TXBOMConsts.ConnectionStringName));

            return new JIT_TXBOMDbContext(builder.Options);
        }
    }
}
