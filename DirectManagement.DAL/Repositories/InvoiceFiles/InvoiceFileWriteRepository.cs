using DirectManagement.APP.Repositories.InvoiceFiles;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;
using DirectManagement.DOMAIN.Entities.Concretes;

namespace DirectManagement.DAL.Repositories.InvoiceFiles;

public class InvoiceFileWriteRepository : WriteRepository<InvoiceFile>, IInvoiceFileWriteRepository
{
    public InvoiceFileWriteRepository(DirectDbContext context) : base(context)
    {
    }
}

