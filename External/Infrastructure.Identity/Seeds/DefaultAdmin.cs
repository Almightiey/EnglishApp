using Domain.Common;
using Infrastructure.Identity.Models;
using Infrastructure.Identity.Persistence;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity.Seeds;

public static class DefaultAdmin
{
    public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IdentityContext identityDbContext)
    {
        string password = "Password";

        var adminUser = new ApplicationUser
        {
            Id = Guid.NewGuid().ToString(),
            UserName = "admin",
            Email = "admin@gmail.com",
            FirstName = "Admin",
            LastName = "Admin",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
        };

        if (userManager.Users.All(u => u.Id != adminUser.Id))
        {
            var existUser = await userManager.FindByEmailAsync(adminUser.Email);
            if (existUser == null)
            {
                await userManager.CreateAsync(adminUser, password);
                await identityDbContext.AddAsync(adminUser);
                await identityDbContext.SaveChangesAsync();
                await userManager.AddToRoleAsync(adminUser, Roles.Admin.ToString());
            }
        }
    }
}
