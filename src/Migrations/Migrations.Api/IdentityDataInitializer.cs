using Microsoft.AspNetCore.Identity;
using Niu.Nutri.Core.Application.DTO.Extensions;
using Niu.Nutri.CrossCutting.Infra.Log.Entries;
using Niu.Nutri.CrossCutting.Infra.Log.Providers;
using Niu.Nutri.SystemSettings.Domain.Aggregates.SystemSettingsAgg.Repositories;
using Niu.Nutri.Users.Domain.Aggregates.UsersAgg.Entities;
using Niu.Nutri.Users.Domain.Aggregates.UsersAgg.Repositories;
using Niu.Nutri.Users.Enumerations;
using Niu.Nutri.Users.Identity;

using SystemPanel = Niu.Nutri.SystemSettings.Domain.Aggregates.SystemSettingsAgg.Entities.SystemPanel;
using SystemPanelGroup = Niu.Nutri.SystemSettings.Domain.Aggregates.SystemSettingsAgg.Entities.SystemPanelGroup;
using SystemPanelSubItem = Niu.Nutri.SystemSettings.Domain.Aggregates.SystemSettingsAgg.Entities.SystemPanelSubItem;

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

                    var menuRepo = scope.ServiceProvider.GetRequiredService<ISystemPanelRepository>();
                    var menuGroupRepo = scope.ServiceProvider.GetRequiredService<ISystemPanelGroupRepository>();
                    var myMenuGroup = await menuGroupRepo.FindAsync(x => x.Code == UserRole.ADMIN.ToString());
                    
                    if (myMenuGroup == null)
                    {
                        myMenuGroup = await CreateMenusAsync(logProvider, menuRepo, menuGroupRepo);
                    }

                    var userProfile = await CreateUserProfileAsync(logProvider, scope, myMenuGroup);

                    var user = userManager.FindByNameAsync(adminUsername).Result;
                    if (user == null)
                    {
                        user = await CreateUserAsync(scope, logProvider, userManager, adminUsername, userProfile);
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

        private async static Task<SystemPanelGroup> CreateMenusAsync(ILogProvider logProvider, ISystemPanelRepository menuRepo, ISystemPanelGroupRepository menuGroupRepo)
        {
            var newMenu = new SystemPanelGroup
            {
                Description = "MENU ADM - SYSTEM",
                Code = UserRole.ADMIN.ToString(),
                IsPrivate = true
            };

            newMenu.SubItems = new List<SystemPanel>();

            //var panel2 = await CreateAdmMenu2(menuRepo);
            //var panel3 = await CreateAdmMenu3(menuRepo);
            newMenu.SubItems.Add(await CreateAdmMenu1(menuRepo));
            //newMenu.SubItems.Add(panel2);
            //newMenu.SubItems.Add(panel3);

            logProvider.Write(new LogEntry("Starting to Create the Standard Menu", action: nameof(SeedAdministratorUser), content: newMenu));
            menuGroupRepo.Add(newMenu);
            await menuGroupRepo.UnitOfWork.CommitAsync();
            logProvider.Write(new LogEntry("Default Menu Creation Completed", action: nameof(SeedAdministratorUser), content: newMenu));
            return newMenu;
        }

        private async static Task<SystemPanel> CreateAdmMenu1(ISystemPanelRepository menuRepo)
        {
            return new SystemPanel
            {
                Icon = @"/imgs/menus/1-adm-system/sidebar-closed/1-menu-estruturacao/1-menu-estruturacao-master.svg",
                Active = true,
                Code = UserRole.ADMIN.ToString(),
                Description = "ADM - Menus and Users",
                SubItems = new List<SystemPanelSubItem>()
                                        {
                                            new SystemPanelSubItem
                                            {
                                                Url=$"/{nameof(SystemPanel)}",
                                                Description="Menus",
                                                Position = 0
                                            },
                                            new SystemPanelSubItem
                                            {
                                                Url=$"/{nameof(SystemPanelGroup)}",
                                                Description="Group of Menus",
                                                Position = 1
                                            },
                                            new SystemPanelSubItem
                                            {
                                                Url=$"/{nameof(UserProfile)}",
                                                Description="User Profiles",
                                                Position = 2
                                            },
                                            new SystemPanelSubItem
                                            {
                                                Url=$"/{nameof(User)}",
                                                Description="Users",
                                                Position = 3
                                            }
                                        }
            };
        }

        private static async Task<UserProfile> CreateUserProfileAsync(ILogProvider logProvider, IServiceScope scope, SystemPanelGroup newMenu)
        {
            using var userProfileRepo = scope.ServiceProvider.GetRequiredService<IUserProfileRepository>();
            var newUserProfile = await userProfileRepo.FindAsync(x => x.Code == newMenu.Code, include: x => x.Accesses);
            var needUpdate = newUserProfile is null || !newMenu.AccessesOfMyProfile.Any();

            if (needUpdate)
            {
                logProvider.Write(new LogEntry("Starting to Create Default Admin Access to the User", action: nameof(SeedAdministratorUser), content: newUserProfile));
                if (newUserProfile is null)
                {
                    newUserProfile = new UserProfile
                    {
                        IsPrivateProfile = true,
                        Active = true,
                        Description = "ADM - SYSTEM",
                        Code = newMenu.Code,
                        InitialPage = "/User",
                        ShowSideBar = true,
                        Accesses = new List<UserProfileAccess>
                                    {
                                        new UserProfileAccess
                                        {
                                            SystemPanelGroupId = newMenu.Id,
                                            CanInsert = true,
                                            CanDelete=true,
                                            CanList =true,
                                            CanUpdate=true,
                                            Description = "Administrators - SYSTEM"
                                        },
                                    }
                    };
                    userProfileRepo.Add(newUserProfile);
                }
                else if (!newUserProfile.Accesses.Any())
                {
                    newUserProfile.Accesses.Add(new UserProfileAccess
                    {
                        SystemPanelGroupId = newMenu.Id,
                        CanInsert = true,
                        CanDelete = true,
                        CanList = true,
                        CanUpdate = true,
                        Description = "Administrators - SYSTEM"
                    });
                }

                var result = await userProfileRepo.UnitOfWork.CommitAsync();
                if (!result.Success)
                    logProvider.WriteError(new LogEntry("Error creating default Admin Access for User", action: nameof(SeedAdministratorUser), content: result, exception: result.Exception));
                logProvider.Write(new LogEntry("Creation of Standard Admin Access to be Completed", action: nameof(SeedAdministratorUser), content: newUserProfile));
            }
            return newUserProfile;
        }

        private async static Task CreateRoleAsync(IServiceScope scope, UserManager<ApplicationUser> userManager, ApplicationUser? user)
        {
            using var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole<int>>>();
            var adminRoleAsString = UserRole.ADMIN.ToString();
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

        private static async Task<ApplicationUser?> CreateUserAsync(IServiceScope scope, ILogProvider logProvider, UserManager<ApplicationUser> userManager, string adminUsername, UserProfile userProfile)
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

                var newDomainUser = user.ProjectedAs<User>();

                logProvider.Write(new LogEntry("Creating User Niu.Nutri...", action: nameof(SeedAdministratorUser), content: newDomainUser));
                var userRepo = scope.ServiceProvider.GetRequiredService<IUserRepository>();

                var newUser = user.ProjectedAs<User>();
                newUser.SelectedAccess = new UserCurrentAccessSelected { Id = user.Id, UserProfileId = userProfile.Id };

                newUser.NeedResetPassword = false;
                newUser.Active = true;
                newUser.Accesses = new List<UserProfileList>()
                {
                    new UserProfileList
                    {
                        UserProfiles = new List<UserProfile>{ userProfile }
                    }
                };
                userRepo.Add(newUser);
                await userRepo.UnitOfWork.CommitAsync();
                logProvider.Write(new LogEntry("User Niu.Nutri Created", action: nameof(SeedAdministratorUser), content: newUser));
            }
            else
            {
                logProvider.WriteError(new LogEntry("Error IdentityUser", action: nameof(SeedAdministratorUser), content: result));
            }

            return user;
        }
    }
}
