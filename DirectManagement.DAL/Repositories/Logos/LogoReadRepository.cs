using DirectManagement.APP.Repositories.Logos;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;
using DirectManagement.DOMAIN.Entities.Concretes;

namespace DirectManagement.DAL.Repositories.Logos
{
    public class LogoReadRepository : ReadRepository<Logo>, ILogoReadRepository
    {
        public LogoReadRepository(DirectDbContext context) : base(context)
        {
        }
    }
}
