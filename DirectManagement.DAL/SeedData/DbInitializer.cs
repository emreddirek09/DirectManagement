using DirectManagement.DAL.Contexts; 

namespace DirectManagement.DAL.SeedData
{
    public class DbInitializer
    {
        private readonly DirectDbContext _context;

        public DbInitializer(DirectDbContext context)
        {
            _context = context;
        }

        public void Run()
        {
            var existCheck =_context.Database.CanConnect();
            if (!existCheck) {
                _context.Database.EnsureDeleted();
                _context.Database.EnsureCreated();
                _context.Seed();
            } 
            
        }
    }
}
