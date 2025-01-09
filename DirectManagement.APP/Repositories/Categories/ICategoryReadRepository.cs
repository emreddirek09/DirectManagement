using DirectManagement.APP.Repositories.Repository;
using DirectManagement.DOMAIN.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.APP.Repositories.Categories
{
    public interface ICategoryReadRepository:IReadRepository<Category>
    {
    }
}
