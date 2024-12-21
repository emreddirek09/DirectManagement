using DirectManagement.APP.Repositories.Contens;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;
using DirectManagement.DOMAIN; 

namespace DirectManagement.DAL.Repositories.Contents
{
    public class ContentReadRepository : ReadRepository<Content>, IContentReadRepository
    {
        public ContentReadRepository(DirectDbContext context) : base(context)
        {
        }
    }
}
