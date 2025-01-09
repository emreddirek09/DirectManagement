using DirectManagement.APP.Repositories.Galleries;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;
using DirectManagement.DOMAIN.Entities.Concretes;

namespace DirectManagement.DAL.Repositories.Galleries
{
    public class GalleryWriteRepository : WriteRepository<Gallery>, IGalleryWriteRepository
    {
        public GalleryWriteRepository(DirectDbContext context) : base(context)
        {
        }
    }
}
