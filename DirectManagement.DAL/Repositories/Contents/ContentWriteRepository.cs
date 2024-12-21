using DirectManagement.APP.Repositories.Contents;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;
using DirectManagement.DOMAIN; 

namespace DirectManagement.DAL.Repositories.Contents
{
    public class ContentWriteRepository : WriteRepository<Content>, IContentWriteRepository
    {
        public ContentWriteRepository(DirectDbContext context) : base(context)
        {
        }
    }
}
