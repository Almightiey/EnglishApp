using Domain.Common;
using Infrastructure.Identity.Models;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity.Seeds;

public static class DefaultRoles
{
    public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        var role = roleManager.Roles
            .Where(c => c.Name == Roles.Admin.ToString() || c.Name == Roles.User.ToString())
            .ToList();

        if (!role.Any())
        {
            await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.User.ToString()));
        }
    }
}
