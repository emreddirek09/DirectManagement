using DirectManagement.APP.Repositories.Reviews;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;
using DirectManagement.DOMAIN; 

namespace DirectManagement.DAL.Repositories.Reviews
{
    public class ReviewWriteRepository : WriteRepository<Review>, IReviewWriteRepository
    {
        public ReviewWriteRepository(DirectDbContext context) : base(context)
        {
        }
    }
}
