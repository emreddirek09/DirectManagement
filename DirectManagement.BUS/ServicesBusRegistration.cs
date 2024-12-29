using DirectManagement.APP.Services;
using DirectManagement.BUS.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectManagement.BUS
{
    public static class ServicesBusRegistration
    {
        public static void AddBusinessServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IFileService, FileService>();
        }
    }
}
