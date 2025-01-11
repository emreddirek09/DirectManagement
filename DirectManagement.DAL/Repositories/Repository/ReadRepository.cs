using DirectManagement.APP.Repositories.Repository;
using DirectManagement.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
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

        public async Task<T?> GetAsync(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? includes = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, Func<IQueryable<T>, IQueryable<T>>? selector = null, int skip = 0, bool ignoreQueryFilters = false, bool tracking = true)
        {
            IQueryable<T> query = _context.Set<T>();
            query = query.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            if (ignoreQueryFilters) query = query.IgnoreQueryFilters();
            if (includes != null) query = includes(query);
            if (filter != null) query = query.Where(filter);
            if (selector != null) query = selector(query);
            if (orderBy != null) query = orderBy(query);
            if (skip > 0) query = query.Skip(skip);
            return await query.FirstOrDefaultAsync();
        }
        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? includes = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, Func<IQueryable<T>, IQueryable<T>>? selector = null, int skip = 0, int take = 0, bool ignoreQueryFilters = false, bool tracking = true)
        {
            IQueryable<T> query = _context.Set<T>();
            query = query.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            if (ignoreQueryFilters) query = query.IgnoreQueryFilters();
            if (includes != null) query = includes(query);
            if (filter != null) query = query.Where(filter);
            if (selector != null) query = selector(query);
            if (orderBy != null) query = orderBy(query);
            if (skip > 0) query = query.Skip(skip);
            if (take > 0) query = query.Take(take);

            return await query.ToListAsync();
        }
        public Task<List<T>> GetAll(bool tracking = true)
        {
            var query = table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return (Task<List<T>>)query;
        }

        public Task<List<T>> GetWhere(Expression<Func<T, bool>> expression, bool tracking = true)
        {
            var query = table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return (Task<List<T>>)query;
        }

        async Task<T> IReadRepository<T>.GetSingleAsync(Expression<Func<T, bool>> expression, bool tracking)
        {
            var query = table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(expression);
        }

    }
}
