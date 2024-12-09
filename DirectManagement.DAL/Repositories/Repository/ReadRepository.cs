using DirectManagement.APP.Repositories.Repository;
using DirectManagement.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.DAL.Repositories.Repository
{
    public class ReadRepository<T> : IReadRepository<T> where T : class
    {
        private readonly DirectDbContext _context;

        public ReadRepository(DirectDbContext context)
        {
            _context = context;
        }

        public DbSet<T> table => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query = table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }


        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> expression, bool tracking = true)
        {
            var query = table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(expression);

        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool tracking = true)
        {
            var query = table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }
    }
}
