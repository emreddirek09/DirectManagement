using DirectManagement.APP.Repositories.User;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;
using DirectManagement.DOMAIN.Entities.Concretes;
namespace DirectManagement.DAL.Repositories.User
{
    public class UserWriteRepository : WriteRepository<AppUser>, IUserWriteRepository
    {
        public UserWriteRepository(DirectDbContext context) : base(context)
        {
        }
    }
}