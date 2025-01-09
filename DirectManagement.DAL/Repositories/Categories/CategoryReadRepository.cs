using DirectManagement.APP.Repositories.Categories;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;
using DirectManagement.DOMAIN.Entities.Concretes;

namespace DirectManagement.DAL.Repositories.Categories
{
    public class CategoryReadRepository : ReadRepository<Category>, ICategoryReadRepository
    {
        public CategoryReadRepository(DirectDbContext context) : base(context)
        {
        }
    }
}
