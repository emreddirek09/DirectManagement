using DirectManagement.APP.Repositories.Contacts;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;
using DirectManagement.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.DAL.Repositories.Contacts
{
    public class ContactReadRepository : ReadRepository<Contact>, IContactReadRepository
    {
        public ContactReadRepository(DirectDbContext context) : base(context)
        {
        }
    }
}
