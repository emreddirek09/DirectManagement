using DirectManagement.APP.Repositories.Logos;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;
using DirectManagement.DOMAIN.Entities.Concretes;

namespace DirectManagement.DAL.Repositories.Logos
{
    public class LogoWriteRepository : WriteRepository<Logo>, ILogoWriteRepository
    {
        public LogoWriteRepository(DirectDbContext context) : base(context)
        {
        }
    }
}
