 
using DirectManagement.APP.Services;
using DirectManagement.APP.Abstractions.Storage;
using DirectManagement.BUS.Enums;
using DirectManagement.BUS.Services;
using DirectManagement.BUS.Services.Storage;
using DirectManagement.BUS.Services.Storage.Local;
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
            serviceCollection.AddScoped<IStorageService, StorageService>();
        }
        public static void AddStorage<T>(this IServiceCollection serviceCollection) where T : class, IStorage
        {
            serviceCollection.AddScoped<IStorage, T>();
        }
        public static void AddStorage(this IServiceCollection serviceCollection, StorageType storageType)
        {
            switch (storageType)
            {
                case StorageType.Local:
                    serviceCollection.AddScoped<IStorage, LocalStorage>();
                    break;
                case StorageType.AWS:
                    //serviceCollection.AddScoped<IStorage, AWSStorage>();

                    break;
                case StorageType.Azure:
                    //serviceCollection.AddScoped<IStorage, Azure>();

                    break;
                default:
                    serviceCollection.AddScoped<IStorage, LocalStorage>();
                    break;
            }
        }
    }
}
