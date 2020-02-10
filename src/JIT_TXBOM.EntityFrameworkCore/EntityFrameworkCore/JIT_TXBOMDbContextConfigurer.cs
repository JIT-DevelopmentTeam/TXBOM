using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace JIT_TXBOM.EntityFrameworkCore
{
    public static class JIT_TXBOMDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<JIT_TXBOMDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<JIT_TXBOMDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }

        public static void ConfigureMySQL(DbContextOptionsBuilder builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void ConfigureMySQL(DbContextOptionsBuilder builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}
