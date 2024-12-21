using DirectManagement.APP.Repositories.Repository;
using DirectManagement.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.APP.Repositories.Comments
{
    public interface ICommentReadRepository:IReadRepository<Comment>
    {
    }
}
