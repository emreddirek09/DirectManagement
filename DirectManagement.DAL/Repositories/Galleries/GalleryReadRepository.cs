using DirectManagement.APP.Repositories.Galleries;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;
using DirectManagement.DOMAIN.Entities.Concretes;

namespace DirectManagement.DAL.Repositories.Galleries
{
    public class GalleryReadRepository : ReadRepository<Gallery>, IGalleryReadRepository
    {
        public GalleryReadRepository(DirectDbContext context) : base(context)
        {
        }
    }
}
