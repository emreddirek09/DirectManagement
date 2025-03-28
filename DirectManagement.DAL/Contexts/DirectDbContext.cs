﻿using DirectManagement.DOMAIN.Entities.BaseEntitiy;
using DirectManagement.DOMAIN.Entities.Concretes;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DirectManagement.DAL.Contexts
{
    public class DirectDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public DirectDbContext(DbContextOptions<DirectDbContext> options)
          : base(options)
        {
        }
        DbSet<Files> Files { get; set; }
        DbSet<ProductImageFile> ProductImageFiles { get; set; }
        DbSet<InvoiceFile> InvoiceFiles { get; set; }
        DbSet<Banner> Banners { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Comment> Comments { get; set; }
        DbSet<Contact> Contacts { get; set; }
        DbSet<Content> Contents { get; set; }
        DbSet<Gallery> Galleries { get; set; }
        DbSet<Logo> Logos { get; set; }
        DbSet<Main> Mains { get; set; }
        DbSet<NewsLetter> NewsLetters { get; set; }
        DbSet<OparationHour> OparationHours { get; set; }
        DbSet<Review> Reviews { get; set; }
        DbSet<Product> Products { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<Base>();
            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreateDate == DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdateDate == DateTime.UtcNow,
                    EntityState.Deleted => data.Entity.DeleteDate == DateTime.UtcNow
                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }


    }
}
