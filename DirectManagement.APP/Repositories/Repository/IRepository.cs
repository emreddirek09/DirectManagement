using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.APP.Repositories.Repository
{
    public interface IRepository<T> where T : class
    {
        DbSet<T> table { get; }
    }
}
