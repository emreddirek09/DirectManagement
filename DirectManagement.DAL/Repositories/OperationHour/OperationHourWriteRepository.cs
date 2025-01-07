using DirectManagement.APP.Repositories.OparationHours;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Repository;
using DirectManagement.DOMAIN; 

namespace DirectManagement.DAL.Repositories.OparationHours
{
    public class OperationHourWriteRepository : WriteRepository<OparationHour>, IOparationHourWriteRepository
    {
        public OperationHourWriteRepository(DirectDbContext context) : base(context)
        {
        }
    }
}
