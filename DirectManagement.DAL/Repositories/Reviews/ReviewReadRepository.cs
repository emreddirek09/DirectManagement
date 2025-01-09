using DirectManagement.APP.Repositories.Reviews;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;
using DirectManagement.DOMAIN.Entities.Concretes;

namespace DirectManagement.DAL.Repositories.Reviews
{
    public class ReviewReadRepository : ReadRepository<Review>, IReviewReadRepository
    {
        public ReviewReadRepository(DirectDbContext context) : base(context)
        {
        }
    }
}
