 using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace DirectManagement.APP
{
    public static class ServiceAppRegistration
    {
        public static void AddApplicationServices(this IServiceCollection serviceCollection, Microsoft.Extensions.Configuration.ConfigurationManager configuration)
        { 
            serviceCollection.AddMediatR(typeof(ServiceAppRegistration).Assembly);
        }
    }
}

