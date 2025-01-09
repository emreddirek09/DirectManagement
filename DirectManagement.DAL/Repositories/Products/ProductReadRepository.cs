using DirectManagement.APP.Repositories.Products;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;
using DirectManagement.DOMAIN.Entities.Concretes;

namespace DirectManagement.DAL.Repositories.Products
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(DirectDbContext context) : base(context)
        {
        }
    }
}
