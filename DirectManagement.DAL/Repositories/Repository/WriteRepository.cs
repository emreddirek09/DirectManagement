using DirectManagement.APP.Repositories.Repository;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using DirectManagement.DAL.Contexts;
using AlpataBLL.BaseResult.Abstracts;
using AlpataBLL.BaseResult.Concretes;
using AutoMapper;

namespace DirectManagement.DAL.Repositories.Repository
{
    public class WriteRepository<T> : IWriteRepository<T> where T : class
    {
        private readonly DirectDbContext _context; 

        public WriteRepository(DirectDbContext context )
        {
            _context = context;
         }

        public DbSet<T> table => _context.Set<T>();

        public async Task<bool> AddAsync(T values)
        {
            EntityEntry<T> entityEntry = await table.AddAsync(values);
            return entityEntry.State == EntityState.Added;
        }
        public async Task<bool> AddRangeAsync(List<T> values)
        {
            await table.AddRangeAsync(values);
            return true;
        }

        public bool Delete(T values)
        {
            EntityEntry entityEntry = table.Remove(values);
            return entityEntry.State == EntityState.Deleted;
        }


        public bool DeleteRange(List<T> values)
        {
            table.RemoveRange(values);
            return true;
        }

        public bool Update(T values)
        {
            EntityEntry entry = table.Update(values);
            return entry.State == EntityState.Modified;
        }
         
        public async Task<int> SaveAsync() => await _context.SaveChangesAsync();
         
    }
}
