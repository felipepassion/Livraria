using Niu.Nutri.SystemSettings.Domain.Aggregates.SystemSettingsAgg.Repositories;
using Niu.Nutri.Users.Domain.Aggregates.UsersAgg.Entities;
using Niu.Nutri.Users.Domain.Aggregates.UsersAgg.Repositories;
using Niu.Nutri.Users.Enumerations;

namespace Schedulings.Domain.Tests
{
    public static class UserProfilesSeeder
    {
        //List<string> CaseUses = new List<string>();
        //protected ISystemPanelGroupRepository _systemPanelGroupRepository;
        //protected ISystemPanelRepository _systemPanelRepository;
        //protected IUserProfileRepository _userProfileRepository;

        //public UserProfilesSeeder(ISystemPanelGroupRepository systemPanelGroupRepository,
        //    ISystemPanelRepository systemPanelRepository,
        //    IUserProfileRepository userProfileRepository)
        //        : base()
        //{
        //    _systemPanelGroupRepository = systemPanelGroupRepository;
        //    _systemPanelRepository = systemPanelRepository;
        //    _userProfileRepository = userProfileRepository;
        //}

        public static async Task CriarPerfisDeUsuario(this WebApplication app, IServiceCollection collection)
        {
            try
            {
                // DR
                var CaseUses = new List<string>();
                await CreateAdmBravoPerfil(collection.BuildServiceProvider(), [UserProfileTypes.SUPPORT, UserProfileTypes.USER]);
            }

            catch (Exception ex)
            {
                throw;
            }
        }

        private static async Task CreateAdmBravoPerfil(IServiceProvider provider, List<string> CaseUses)
        {
            foreach (var group in CaseUses)
            {
                var _systemPanelGroupRepository = provider.GetRequiredService<ISystemPanelGroupRepository>();
                var _systemPanelRepository = provider.GetRequiredService<ISystemPanelRepository>();
                var _userProfileRepository = provider.GetRequiredService<IUserProfileRepository>();

                var myGroup = await _systemPanelGroupRepository.FindAsync(x => x.Code.ToLower() == group.ToLower());
                if (myGroup == null) throw new Exception($"Group not found. '{group}'");
                if (myGroup.AccessesOfMyProfile.Any() == false)
                {
                    if (await _systemPanelRepository.AnyAsync(x => x.Description.ToLower() == group.ToLower()))
                        return;

                    var novoPerfil = await _userProfileRepository.FindAsync(x => x.Code == myGroup.Code) ?? new UserProfile
                    {
                        Code = myGroup.Code,
                        Active = true,
                        Description = Enum.Parse<UserRole>(group).ToFriendlyString(),
                        InitialPage = ""
                    };

                    if (novoPerfil.Accesses.Any() == false)
                    {
                        foreach (var item in myGroup.SubItems)
                        {
                            novoPerfil.Accesses = new List<UserProfileAccess>
                            {
                                new UserProfileAccess
                                {
                                    SystemPanelGroupId = myGroup.Id,
                                    Description = "Group " + myGroup.Description + " - " + item.Description,
                                    Active= true,
                                    CanUpdate=true,
                                    CanInsert=true,
                                    CanDelete=true,
                                    CanList=true
                                }
                            };
                        }

                    }
                    try
                    {
                        _userProfileRepository.Add(novoPerfil);
                        var response = await _userProfileRepository.UnitOfWork.CommitAsync();
                        if (!response.Success)
                            throw new Exception("response.Success.Should().BeTrue()");
                        if (response.Errors.Any())
                            throw new Exception("response.Errors.Should().BeEmpty()");
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }
        }

    }
}