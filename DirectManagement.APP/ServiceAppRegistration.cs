using Microsoft.Extensions.DependencyInjection; 

namespace DirectManagement.APP
{
    public static class ServiceAppRegistration
    {
        public static void AddApplicationServices(this IServiceCollection serviceCollection, Microsoft.Extensions.Configuration.ConfigurationManager configuration)
        {
            // MediatR yapılandırması
            serviceCollection.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(typeof(ServiceAppRegistration).Assembly);
            });
        }
    }
}
