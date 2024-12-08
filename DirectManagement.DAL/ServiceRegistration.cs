using DirectManagement.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection; 

namespace DirectManagement.DAL
{
    public static class ServiceRegistration
    {
        public static void AddServicesDal(this IServiceCollection services)
        {
            services.AddDbContext<DirectDbContext>(options => options.UseSqlServer(Configuration.ConnectionString)); 
        }
    }
}
