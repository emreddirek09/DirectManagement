using DirectManagement.APP.Repositories.InvoiceFiles;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;
using DirectManagement.DOMAIN.Entities.Concretes;

namespace DirectManagement.DAL.Repositories.InvoiceFiles;

public class InvoiceFileReadRepository : ReadRepository<InvoiceFile>, IInvoiceFileReadRepository
{
    public InvoiceFileReadRepository(DirectDbContext context) : base(context)
    {
    }
}

