using DirectManagement.APP.Repositories.Contacts;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;
using DirectManagement.DOMAIN; 

namespace DirectManagement.DAL.Repositories.Contacts
{
    public class ContactWriteRepository : WriteRepository<Contact>, IContactWriteRepository
    {
        public ContactWriteRepository(DirectDbContext context) : base(context)
        {
        }
    }
}
