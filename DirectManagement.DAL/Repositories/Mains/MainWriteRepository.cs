using DirectManagement.APP.Repositories.Mains;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;
using DirectManagement.DOMAIN.Entities.Concretes;

namespace DirectManagement.DAL.Repositories.Mains
{
    public class MainWriteRepository : WriteRepository<Main>, IMainWriteRepository
    {
        public MainWriteRepository(DirectDbContext context) : base(context)
        {
        }
    }
}
