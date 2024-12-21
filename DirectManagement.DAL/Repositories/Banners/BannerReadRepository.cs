using DirectManagement.APP.Repositories.Banners;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;
using DirectManagement.DOMAIN; 

namespace DirectManagement.DAL.Repositories.Banners
{
    public class BannerReadRepository : ReadRepository<Banner>, IBannerReadRepository
    {
        public BannerReadRepository(DirectDbContext context) : base(context)
        {
        }
    }
}
