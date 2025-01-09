using DirectManagement.APP.Repositories.Files;
using DirectManagement.APP.Repositories.Repository;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;

namespace DirectManagement.DAL.Repositories.Files;

public class FileWriteRepository : WriteRepository<DOMAIN.Entities.Concretes.Files>, IFileWriteRepository
{
    public FileWriteRepository(DirectDbContext context) : base(context)
    {
    }
}

