using DirectManagement.APP.Repositories.ProductImageFiles;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;
using DirectManagement.DOMAIN.Entities.Concretes;
using D = DirectManagement.DOMAIN;

namespace DirectManagement.DAL.Repositories.ProductImageFiles;

public class ProductImageFileReadRepository : ReadRepository<ProductImageFile>, IProductImageFileReadRepository
{
    public ProductImageFileReadRepository(DirectDbContext context) : base(context)
    {
    }
}

