using DirectManagement.APP.Repositories.OparationHours;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;
using DirectManagement.DOMAIN; 

namespace DirectManagement.DAL.Repositories.OperationHour
{
    public class OperationHourReadRepository : ReadRepository<OparationHour>, IOparationHourReadRepository
    {
        public OperationHourReadRepository(DirectDbContext context) : base(context)
        {
        }
    }
}
