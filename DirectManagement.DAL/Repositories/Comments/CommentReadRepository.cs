using DirectManagement.APP.Repositories.Comments;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;
using DirectManagement.DOMAIN.Entities.Concretes;

namespace DirectManagement.DAL.Repositories.Comments
{
    public class CommentReadRepository : ReadRepository<Comment>, ICommentReadRepository
    {
        public CommentReadRepository(DirectDbContext context) : base(context)
        {
        }
    }
}
