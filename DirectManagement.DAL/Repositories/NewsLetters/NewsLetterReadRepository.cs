using DirectManagement.APP.Repositories.NewsLetters;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;
using DirectManagement.DOMAIN.Entities.Concretes;

namespace DirectManagement.DAL.Repositories.NewsLetters
{
    public class NewsLetterReadRepository : ReadRepository<NewsLetter>, INewsLetterReadRepository
    {
        public NewsLetterReadRepository(DirectDbContext context) : base(context)
        {
        }
    }
}
