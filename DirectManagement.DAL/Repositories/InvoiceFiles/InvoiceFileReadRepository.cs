using DirectManagement.APP.Repositories.InvoiceFiles;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;

namespace DirectManagement.DAL.Repositories.InvoiceFiles;

public class InvoiceFileReadRepository : ReadRepository<DOMAIN.InvoiceFile>, IInvoiceFileReadRepository
{
    public InvoiceFileReadRepository(DirectDbContext context) : base(context)
    {
    }
}

