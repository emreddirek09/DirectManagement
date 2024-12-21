using DirectManagement.APP.Repositories.OparationHours;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;
using DirectManagement.DOMAIN; 

namespace DirectManagement.DAL.Repositories.OparationHours
{
    public class OparationHourWriteRepository : WriteRepository<OparationHour>, IOparationHourWriteRepository
    {
        public OparationHourWriteRepository(DirectDbContext context) : base(context)
        {
        }
    }
}
