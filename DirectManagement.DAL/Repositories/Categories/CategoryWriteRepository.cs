using DirectManagement.APP.Repositories.Categories;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;
using DirectManagement.DOMAIN; 

namespace DirectManagement.DAL.Repositories.Categories
{
    public class CategoryWriteRepository : WriteRepository<Category>, ICategoryWriteRepository
    {
        public CategoryWriteRepository(DirectDbContext context) : base(context)
        {
        }
    }
}
