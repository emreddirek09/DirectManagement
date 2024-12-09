using DirectManagement.APP.Repositories.User;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;
using DirectManagement.DOMAIN; 

namespace DirectManagement.DAL.Repositories.User
{
    public class UserReadRepository : ReadRepository<AppUser>, IUserReadRepository
    {
        public UserReadRepository(DirectDbContext context) : base(context)
        {
        }
    }
}