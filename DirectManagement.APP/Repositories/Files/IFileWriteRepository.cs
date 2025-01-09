using DirectManagement.APP.Repositories.Repository;
using D = DirectManagement.DOMAIN;

namespace DirectManagement.APP.Repositories.Files;

public interface IFileWriteRepository : IWriteRepository<D.Entities.Concretes.Files>
{
}

