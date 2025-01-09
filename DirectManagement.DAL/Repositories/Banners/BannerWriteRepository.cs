using DirectManagement.APP.Repositories.Banners;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;
using DirectManagement.DOMAIN.Entities.Concretes;

namespace DirectManagement.DAL.Repositories.Banners
{
    public class BannerWriteRepository : WriteRepository<Banner>, IBannerWriteRepository
    {
        public BannerWriteRepository(DirectDbContext context) : base(context)
        {
        }
    }
}
