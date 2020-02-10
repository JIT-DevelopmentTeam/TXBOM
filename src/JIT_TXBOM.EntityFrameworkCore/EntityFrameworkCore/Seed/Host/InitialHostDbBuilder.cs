namespace JIT_TXBOM.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly JIT_TXBOMDbContext _context;

        public InitialHostDbBuilder(JIT_TXBOMDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
