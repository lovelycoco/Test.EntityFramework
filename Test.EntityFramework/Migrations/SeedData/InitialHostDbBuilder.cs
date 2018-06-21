

namespace Test.EntityFramework.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly TestDbContext _context;

        public InitialHostDbBuilder(TestDbContext context)
        {
            _context = context;
        }

        public void Create()
        {

            new DefaultPickupTypeCreator(_context).Create();
        }
    }
}
