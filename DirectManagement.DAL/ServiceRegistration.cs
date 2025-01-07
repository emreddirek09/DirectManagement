using DirectManagement.APP.Repositories.Banners;
using DirectManagement.APP.Repositories.Categories;
using DirectManagement.APP.Repositories.Comments;
using DirectManagement.APP.Repositories.Contacts;
using DirectManagement.APP.Repositories.Contens;
using DirectManagement.APP.Repositories.Contents;
using DirectManagement.APP.Repositories.Files;
using DirectManagement.APP.Repositories.Galleries;
using DirectManagement.APP.Repositories.InvoiceFiles;
using DirectManagement.APP.Repositories.Logos;
using DirectManagement.APP.Repositories.Mains;
using DirectManagement.APP.Repositories.NewsLetters;
using DirectManagement.APP.Repositories.OparationHours;
using DirectManagement.APP.Repositories.ProductImageFiles;
using DirectManagement.APP.Repositories.Products;
using DirectManagement.APP.Repositories.Reviews;
using DirectManagement.APP.Repositories.User;
using DirectManagement.APP.Security.Token;
using DirectManagement.DAL.Contexts;
using DirectManagement.DAL.Repositories.Banners;
using DirectManagement.DAL.Repositories.Categories;
using DirectManagement.DAL.Repositories.Comments;
using DirectManagement.DAL.Repositories.Contacts;
using DirectManagement.DAL.Repositories.Contents;
using DirectManagement.DAL.Repositories.Files;
using DirectManagement.DAL.Repositories.Galleries;
using DirectManagement.DAL.Repositories.InvoiceFiles;
using DirectManagement.DAL.Repositories.Logos;
using DirectManagement.DAL.Repositories.Mains;
using DirectManagement.DAL.Repositories.NewsLetters;
using DirectManagement.DAL.Repositories.OparationHours;
using DirectManagement.DAL.Repositories.OperationHour;
using DirectManagement.DAL.Repositories.ProductImageFiles;
using DirectManagement.DAL.Repositories.Products;
using DirectManagement.DAL.Repositories.Reviews;
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
            services.AddTransient<DbInitializer>();


            services.AddScoped<IBannerReadRepository, BannerReadRepository>();
            services.AddScoped<IBannerWriteRepository, BannerWriteRepository>();

            services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
            services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();

            services.AddScoped<ICommentReadRepository, CommentReadRepository>();
            services.AddScoped<ICommentWriteRepository, CommentWriteRepository>();

            services.AddScoped<IContactReadRepository, ContactReadRepository>();
            services.AddScoped<IContactWriteRepository, ContactWriteRepository>();

            services.AddScoped<IContentReadRepository, ContentReadRepository>();
            services.AddScoped<IContentWriteRepository, ContentWriteRepository>();

            services.AddScoped<IFileReadRepository, FileReadRepository>();
            services.AddScoped<IFileWriteRepository, FileWriteRepository>();

            services.AddScoped<IGalleryReadRepository, GalleryReadRepository>();
            services.AddScoped<IGalleryWriteRepository, GalleryWriteRepository>();

            services.AddScoped<IInvoiceFileReadRepository, InvoiceFileReadRepository>();
            services.AddScoped<IInvoiceFileWriteRepository, InvoiceFileWriteRepository>();

            services.AddScoped<ILogoReadRepository, LogoReadRepository>();
            services.AddScoped<ILogoWriteRepository, LogoWriteRepository>();

            services.AddScoped<IMainReadRepository, MainReadRepository>();
            services.AddScoped<IMainWriteRepository, MainWriteRepository>();

            services.AddScoped<INewsLetterReadRepository, NewsLetterReadRepository>();
            services.AddScoped<INewsLetterWriteRepository, NewsLetterWriteRepository>();

            services.AddScoped<IOparationHourReadRepository, OperationHourReadRepository>();
            services.AddScoped<IOparationHourWriteRepository, OperationHourWriteRepository>();

            services.AddScoped<IProductImageFileReadRepository, ProductImageFileReadRepository>();
            services.AddScoped<IProductImageFileWriteRepository, ProductImageFileWriteRepository>();

            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();

            services.AddScoped<IReviewReadRepository, ReviewReadRepository>();
            services.AddScoped<IReviewWriteRepository, ReviewWriteRepository>();

            services.AddScoped<IUserReadRepository, UserReadRepository>();
            services.AddScoped<IUserWriteRepository, UserWriteRepository>();


        }
    }
}
