using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using JIT_TXBOM.Authorization.Roles;
using JIT_TXBOM.Authorization.Users;
using JIT_TXBOM.K3APIUrl;
using JIT_TXBOM.Material;
using JIT_TXBOM.MultiTenancy;

namespace JIT_TXBOM.EntityFrameworkCore
{
    public class JIT_TXBOMDbContext : AbpZeroDbContext<Tenant, Role, User, JIT_TXBOMDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public JIT_TXBOMDbContext(DbContextOptions<JIT_TXBOMDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MaterialTemplateModel> MaterialTemplate { get; set; }
        public virtual DbSet<K3ApiUrl> K3Api { get; set; }
        public virtual DbSet<LocalMaterialMapCustomMaterial.LocalMaterialMapCustomMaterial> LocalMaterialMapCustomMaterial
        {
            get;
            set;
        }
    }
}
