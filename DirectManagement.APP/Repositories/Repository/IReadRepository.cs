using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.APP.Repositories.Repository
{
    public interface IReadRepository<T> : IRepository<T> where T : class
    {
        Task<T?> GetAsync(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? includes = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, Func<IQueryable<T>, IQueryable<T>>? selector = null, int skip = 0, bool ignoreQueryFilters = false, bool tracking = true);

        Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? includes = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, Func<IQueryable<T>, IQueryable<T>>? selector = null, int skip = 0, int take = 0, bool ignoreQueryFilters = false, bool tracking = true);
        Task<List<T>> GetWhere(Expression<Func<T, bool>> expression, bool tracking = true);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> expression, bool tracking = true);
    }
}
