using DirectManagement.APP.Repositories.InvoiceFiles;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;

namespace DirectManagement.DAL.Repositories.InvoiceFiles;

public class InvoiceFileWriteRepository : WriteRepository<DOMAIN.InvoiceFile>, IInvoiceFileWriteRepository
{
    public InvoiceFileWriteRepository(DirectDbContext context) : base(context)
    {
    }
}

