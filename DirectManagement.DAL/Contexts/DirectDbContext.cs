using DirectManagement.DOMAIN;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.DAL.Contexts
{
    public class DirectDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public DirectDbContext(DbContextOptions<DirectDbContext> options)
          : base(options)
        {
        }
    }
}
