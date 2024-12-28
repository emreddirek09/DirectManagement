using DirectManagement.APP.Hashing;
using DirectManagement.DAL.Contexts;
using DirectManagement.DOMAIN;
using Microsoft.AspNetCore.Identity;

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
                PasswordHash = Convert.ToBase64String(passwordHash),
                SecurityStamp = Convert.ToBase64String(passwordSalt),
                PhoneNumber = "12312312312",
                CreateDate = DateTime.Now
            };

            AppRole role = new AppRole
            {
                Id = 1,
                Name = "Admin",
                NormalizedName = "ADMIN",
                CreateDate = DateTime.UtcNow
            };

            IdentityUserRole<int> userRole = new IdentityUserRole<int>
            {
                RoleId = 1,
                UserId = 1905
            };
            context.Set<AppRole>().Add(role);
            context.Set<AppUser>().Add(user);
            context.Set<IdentityUserRole<int>>().Add(userRole); 
            context.SaveChanges();
        }
    }
}
