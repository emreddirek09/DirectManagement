
using DirectManagement.APP.Repositories.Mains;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;
using DirectManagement.DOMAIN; 

namespace DirectManagement.DAL.Repositories.Mains
{
    public class MainReadRepository : ReadRepository<Main>, IMainReadRepository
    {
        public MainReadRepository(DirectDbContext context) : base(context)
        {
        }
    }
}
