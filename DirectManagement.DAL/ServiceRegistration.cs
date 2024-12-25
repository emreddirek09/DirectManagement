using DirectManagement.APP.Repositories.User;
using DirectManagement.APP.Security.Token;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.User;
using DirectManagement.DAL.SeedData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DirectManagement.DAL
{
    public static class ServiceRegistration
    {
        public static void AddServicesDal(this IServiceCollection services)
        {
            services.AddDbContext<DirectDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
            services.AddScoped<IUserReadRepository, UserReadRepository>();
            services.AddScoped<IUserWriteRepository, UserWriteRepository>();
            services.AddScoped<ITokenHandler, TokenHandler>();
            services.AddScoped<DbInitializer>();

        }
    }
}
