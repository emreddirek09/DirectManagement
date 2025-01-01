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
                KimlikNo = "11111111111",
                CreateDate = DateTime.Now
            };

            AppRole role = new AppRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN",
                CreateDate = DateTime.UtcNow
            };
 
            context.Set<AppRole>().Add(role);
            context.Set<AppUser>().Add(user);
            context.SaveChanges();

            IdentityUserRole<int> userRole = new IdentityUserRole<int>
            {
                RoleId = role.Id,
                UserId = user.Id
            };

            context.Set<IdentityUserRole<int>>().Add(userRole);
            context.SaveChanges();

        }
    }
}
