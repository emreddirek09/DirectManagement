using DirectManagement.APP.Repositories.Comments;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;
using DirectManagement.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.DAL.Repositories.Comments
{
    public class CommentWriteRepository : WriteRepository<Comment>, ICommentWriteRepository
    {
        public CommentWriteRepository(DirectDbContext context) : base(context)
        {
        }
    }
}
