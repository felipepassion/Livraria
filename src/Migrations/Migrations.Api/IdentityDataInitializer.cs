using Microsoft.AspNetCore.Identity;
using Niu.Nutri.CrossCutting.Infra.Log.Entries;
using Niu.Nutri.CrossCutting.Infra.Log.Providers;
using Niu.Nutri.Users.Identity;

namespace Niu.Nutri.Migrations.Api
{
    public static class BasePathConfigurator
    {
        public static async Task SeedAdministratorUser(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var logProvider = scope.ServiceProvider.GetRequiredService<ILogProvider>();

            try
            {
                logProvider.Write(new LogEntry("Starting Admin User Verification ------>", action: nameof(SeedAdministratorUser)));

                using (var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>())
                {
                    var adminUsername = "admroot@niu.nutri.com.br";

                    var user = userManager.FindByNameAsync(adminUsername).Result;
                    if (user == null)
                    {
                        user = await CreateUserAsync(scope, logProvider, userManager, adminUsername);
                    }

                    await CreateRoleAsync(scope, userManager, user);
                }
            }
            catch (Exception ex)
            {
                logProvider.WriteError(ex, new Niu.Nutri.CrossCutting.Infra.Log.Entries.LogEntry(
                    title: $"Error initializing administrators: {ex.Message}",
                    action: nameof(SeedAdministratorUser),
                    exception: ex));
            }
            finally
            {
                logProvider.Write(new LogEntry("<------ Admin User Verification Completed", action: nameof(SeedAdministratorUser)));
            }
        }

        private async static Task CreateRoleAsync(IServiceScope scope, UserManager<ApplicationUser> userManager, ApplicationUser? user)
        {
            using var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole<int>>>();
            var adminRoleAsString = "ADMIN";
            var roles = await userManager.GetRolesAsync(user);
            var admRole = roles?.FirstOrDefault(x => x.Equals(adminRoleAsString, System.StringComparison.InvariantCultureIgnoreCase));
            if (admRole == null)
            {
                var existingRole = await roleManager.FindByNameAsync(adminRoleAsString);
                if (existingRole == null)
                {
                    await roleManager.CreateAsync(new IdentityRole<int>(adminRoleAsString));
                }
                await userManager.AddToRoleAsync(user, adminRoleAsString.ToString());
            }
        }

        private static async Task<ApplicationUser?> CreateUserAsync(IServiceScope scope, ILogProvider logProvider, UserManager<ApplicationUser> userManager, string adminUsername)
        {
            ApplicationUser? user = new ApplicationUser();
            user.Name = adminUsername;
            user.Email = "admroot@Niu.Nutri.com";
            user.UserName = "00000000000";
            user.EmailConfirmed = true;
            user.PhoneNumber = "21000000000";

            IdentityResult result = userManager.CreateAsync(user, "drill123").Result;

            if (result.Succeeded)
            {
                logProvider.Write(new LogEntry("IdentityUser created", action: nameof(SeedAdministratorUser), content: result));
            }
            else
            {
                logProvider.WriteError(new LogEntry("Error IdentityUser", action: nameof(SeedAdministratorUser), content: result));
            }

            return user;
        }
    }
}
