

using DirectManagement.APP.Hashing;
using DirectManagement.DAL.Contexts;
using DirectManagement.DOMAIN;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DirectManagement.DAL.SeedData
{
    public static class SeedModelBuilderExt
    {
        public static void Seed(this DirectDbContext context)
        {
            if (context.Set<AppUser>().Any())
            {
                return;
            }
            context.SaveChanges();
            HashingHelper.CreatePassword("1234", out byte[] passwordHash, out byte[] passwordSalt);
            AppUser user = new AppUser
            {
                Id = 1905,
                Name = "Emre",
                Surname = "Direk",
                UserName = "emreddirek",
                NormalizedUserName = "EMREDDIREK",
                Email = "emreddirek@gmail.com",
                NormalizedEmail = "EMREDDIREK@GMAIL.COM",
                EmailConfirmed = true,
                CreateDate = DateTime.Now,
                PasswordHash = passwordHash.ToString(),
                SecurityStamp = passwordSalt.ToString(),
                PhoneNumber = "12312312312"
            };
            AppRole role = new AppRole
            {
                Id = 1,
                Name = "Admin",
                NormalizedName = "ADMIN",
                CreateDate = DateTime.UtcNow
            };

            IdentityUserRole userRole = new IdentityUserRole
            {
                RoleId = "1",
                UserId = "1905"
            };
            context.Set<AppRole>().Add(role);
            context.Set<AppUser>().Add(user);
            context.Set<IdentityUserRole>().Add(userRole);
            context.SaveChanges();
        }


    }
}
