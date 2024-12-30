using DirectManagement.APP.Repositories.Files;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;

namespace DirectManagement.DAL.Repositories.Files;

public class FileReadRepository : ReadRepository<DOMAIN.Files>, IFileReadRepository
{
    public FileReadRepository(DirectDbContext context) : base(context)
    {
    }
}

