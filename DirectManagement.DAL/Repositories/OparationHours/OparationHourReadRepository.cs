using DirectManagement.APP.Repositories.OparationHours;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;
using DirectManagement.DOMAIN; 

namespace DirectManagement.DAL.Repositories.OparationHours
{
    public class OparationHourReadRepository : ReadRepository<OparationHour>, IOparationHourReadRepository
    {
        public OparationHourReadRepository(DirectDbContext context) : base(context)
        {
        }
    }
}
