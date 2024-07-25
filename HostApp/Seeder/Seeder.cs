using Infrastructure.Identity.Models;
using Infrastructure.Identity.Persistence;
using Infrastructure.Identity.Seeds;
using Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HostApp.Seeder;

public static class Seeder
{
    public static async Task Start(IServiceProvider serviceProvider)
    {
        try
        {
            var scope = serviceProvider.CreateScope();

            using var identityContext = scope.ServiceProvider.GetService<IdentityContext>();
            using var applicationDbContext = scope.ServiceProvider.GetService<ApplicationDbContext>();
            using var identityDbContext = scope.ServiceProvider.GetService<IdentityContext>();

            await identityContext!.Database!.MigrateAsync();
            await applicationDbContext!.Database!.MigrateAsync();

            using var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            using var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            await DefaultRoles.SeedAsync(userManager, roleManager);
            await DefaultAdmin.SeedAsync(userManager, roleManager, identityDbContext);

        }
        catch (Exception ex)
        {
            throw new Exception("An error occurred seeding the IdentityContext DB", ex);
        }
    }
}