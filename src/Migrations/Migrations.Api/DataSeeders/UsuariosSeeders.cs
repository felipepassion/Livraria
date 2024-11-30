using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using Niu.Nutri.Core.Application.DTO.Extensions;
using Niu.Nutri.Users.Application.Aggregates.UsersAgg.AppServices;
using Niu.Nutri.Users.Application.DTO.Aggregates.UsersAgg.Requests;
using Niu.Nutri.Users.Domain.Aggregates.UsersAgg.Entities;
using Niu.Nutri.Users.Domain.Aggregates.UsersAgg.Queries.Models;
using Niu.Nutri.Users.Enumerations;
using Niu.Nutri.Users.Identity;

namespace Niu.Nutri.Migrations.Api.DataSeeders
{
    public static class UsuariosSeeders
    {
        public static async Task CriarSeedUsers(this WebApplication app, IServiceCollection collection)
        {
            // DR
            await CreateTearDownUser(collection.BuildServiceProvider(), "user", UserRole.USER.ToFriendlyString(), UserProfileTypes.USER);

            await CreateTearDownUser(collection.BuildServiceProvider(), "support", UserRole.SUPPORT.ToFriendlyString(), UserProfileTypes.SUPPORT);

            await CreateTearDownUser(collection.BuildServiceProvider(), "multiple", "Multiple User AR", [UserProfileTypes.USER, UserProfileTypes.SUPPORT]);
        }

        public static async Task<ApplicationUser?> CreateTearDownUser(IServiceProvider serviceProvider, string userName, string name, params string[] userProfileCodes)
        {
            var _userProfileAppService = serviceProvider.GetRequiredService<IUserProfileAppService>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var userRepo = serviceProvider.GetRequiredService<IUserAppService>();

            var expectedCPF = userName;

            List<UserProfileDTO> profiles = new List<UserProfileDTO>();

            foreach (var code in userProfileCodes)
            {
                profiles.Add(await _userProfileAppService.Get(new UserProfileQueryModel { CodeEqual = code }));
            }

            if (!profiles.Any())
                throw new Exception("Assert.NotEmpty(profiles)");

            if (profiles.Count != userProfileCodes.Length)
                throw new Exception("Assert.Equal(profiles.Count, userProfileCodes.Length)");

            ApplicationUser? user = await userManager.FindByNameAsync(expectedCPF);
            IdentityResult result;

            if (user is null)
            {
                user = new ApplicationUser();
                user.Name = $"{name} User";
                user.UserName = expectedCPF;
                user.Email = $"{Guid.NewGuid()}@niu.nutri.com";
                user.EmailConfirmed = true;
                user.PhoneNumber = "21000000000";
                result = userManager.CreateAsync(user, "drill123").Result;
            }
            else
            {
                result = IdentityResult.Success;
                return user;
            }

            if (user.Id > 0)
            {
                var newDomainUser = user.ProjectedAs<User>();

                var newUser = user.ProjectedAs<User>().ProjectedAs<UserDTO>();
                newUser.Password = "drill123";

                try
                {
                    newUser.SelectedAccess = new UserCurrentAccessSelectedDTO
                    {
                        ExternalId = Guid.NewGuid().ToString(),
                        UserProfileId = profiles.FirstOrDefault()?.Id
                    };

                    newUser.Accesses = new List<UserProfileListDTO>()
                    {
                        new UserProfileListDTO
                        {
                            UserProfiles = profiles
                        }
                    };

                    var str = JsonConvert.SerializeObject(newUser);

                    var response = await userRepo.Create(newUser);

                    if (!response.Success) throw new Exception("Assert.True(response.Success)");
                }
                catch (Exception ex)
                {
                    throw;
                }
            }

            if (!result.Succeeded) throw new Exception("Assert.True(response.Success)");

            return user;
        }
    }
}