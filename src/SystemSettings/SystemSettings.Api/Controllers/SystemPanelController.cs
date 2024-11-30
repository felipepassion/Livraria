using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Niu.Nutri.Core.Application.DTO.Extensions;
using Niu.Nutri.Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;
using Niu.Nutri.SystemSettings.Application.Aggregates.SystemSettingsAgg.AppServices;
using Niu.Nutri.SystemSettings.Application.DTO.Aggregates.SystemSettingsAgg.Requests;
using Niu.Nutri.SystemSettings.Application.DTO.Aggregates.UsersAgg.Requests;
using Niu.Nutri.SystemSettings.Domain.Aggregates.SystemSettingsAgg.Queries.Models;
using Niu.Nutri.SystemSettings.Domain.Aggregates.SystemSettingsAgg.Repositories;
using Niu.Nutri.SystemSettings.Domain.Aggregates.UsersAgg.Repositories;
using Niu.Nutri.Users.Enumerations;
using System.ComponentModel.DataAnnotations;

namespace Niu.Nutri.SystemSettings.Api.Controllers
{
    public partial class SystemPanelController
    {
        [HttpPost("update-subitem-positions/{systemPanelId}")]
        public async Task<GetHttpResponseDTO> UpdatePositions([FromRoute] string systemPanelId, string[] positions)
        {
            var service = _scope.GetRequiredService<ISystemPanelSubItemRepository>();

            var panels = await service.FindAllAsync(x => positions.Contains(x.ExternalId));

            int pos = 0;
            foreach (var item in panels.OrderBy(x => positions.ToList().IndexOf(x.ExternalId)))
            {
                item.Position = pos++;
            }

            await service.UnitOfWork.CommitAsync();

            return GetHttpResponseDTO.Ok();
        }


        [HttpGet("{pageRoute}/access/{panelId}/{userId}")]
        [HttpGet("{pageRoute}/access/{panelId}/{userId}/{subPanelId}")]
        public async Task<GetHttpResponseDTO> GetAccessOfPage([FromRoute] string pageRoute, [FromRoute] int panelId, [FromRoute] int? subPanelId, [FromRoute] string userId)
        {
            try
            {
                using var _userAppService = _scope.GetRequiredService<IUserCurrentAccessSelectedRepository>();
                var me = await _userAppService.FindAsync(x => x.Id == int.Parse(userId));
                using var userProfileService = _scope.GetRequiredService<IUserProfileRepository>();
                var myProfile = await userProfileService.FindAsync(filter: x => x.Id == me.UserProfileId, selector: x => x.ProjectedAs<UserProfileDTO>());

                if (me != null)
                {
                    var isAdmin = myProfile.Code == UserRole.ADMIN.ToString();
                    if (isAdmin)
                        return GetHttpResponseDTO.Ok(new UserProfileAccessDTO { CanUpdate = true, CanList = true, CanDelete = true, CanInsert = true });
                }

                //if (subPanelId == null || panelId == 0)
                //return GetHttpResponseDTO.Ok(new UserProfileAccessDTO { });

                using var panelService = _scope.GetRequiredService<ISystemPanelSubItemRepository>();

                var panels = await panelService.FindAllAsync(x => x.Url.Contains(pageRoute));

                var myAccess = myProfile.Accesses.FirstOrDefault(x => panels.Any(p => p.Id == x.SystemPanelSubItemId));

                return GetHttpResponseDTO.Ok(myAccess ?? new UserProfileAccessDTO { });
            }
            catch (Exception ex)
            {
                return GetHttpResponseDTO.Error(ex);
            }
        }

        [HttpGet("get-my-menus/{myId}")]
        public async Task<GetHttpResponseDTO<IEnumerable<SystemPanelDTO>>> GetMyMenus([Required] int? myId)
        {
            using var groupOfMenusRepository = _scope.GetRequiredService<ISystemPanelGroupAppService>();
            using var _userAccesses = _scope.GetRequiredService<IUserProfileAccessRepository>();
            using var _userProfileRepo = _scope.GetRequiredService<IUserProfileRepository>();
            using var _userProfileListaRepo = _scope.GetRequiredService<IUserProfileListRepository>();
            using var _selectedAccessAppService = _scope.GetRequiredService<IUserCurrentAccessSelectedRepository>();

            if (myId.HasValue)
            {
                var isAdmin = false;//await userManager.IsInRoleAsync(await userManager.GetUserAsync(this.User), AccountType.Admin.ToString());
                if (isAdmin)
                {
                    return GetHttpResponseDTO.Ok<IEnumerable<SystemPanelDTO>>(await _systemPanelAppService.GetAll(new SystemPanelQueryModel()));
                }
                else
                {
                    var mySelectedAccess = await _selectedAccessAppService.FindAsync(x => x.Id == myId.Value);
                    var avalMenusForMe = new List<SystemPanelDTO>();
                    if (mySelectedAccess != null)
                    {
                        var myProfiles1 = await _userProfileListaRepo.FindAllAsync(x => x.UserId == myId.Value);
                        var myProfile = await _userProfileRepo.FindAsync(x => x.Id == mySelectedAccess.UserProfileId);

                        if (myProfile != null)
                        {
                            var myAccesses = await _userAccesses.FindAllAsync(filter: x => x.UserProfileId == myProfile.Id);

                            var profileids = myAccesses.Where(p => p.SystemPanelId.HasValue).Select(p => p.SystemPanelId).ToArray() ?? new int?[0];

                            var groupProfileids = myAccesses.Where(p => p.SystemPanelGroupId.HasValue).Select(p => p.SystemPanelGroupId).ToArray() ?? new int?[0];

                            if (groupProfileids?.Any() == true)
                            {
                                var myMenus = await groupOfMenusRepository.GetAll(new SystemPanelGroupQueryModel
                                {
                                    IdContains = groupProfileids.Select(x => x.Value).ToArray()
                                });
                                avalMenusForMe.AddRange(myMenus.SelectMany(x => x.SubItems));
                            }

                            if (profileids?.Any() == true)
                            {
                                avalMenusForMe.AddRange(await _systemPanelAppService.GetAll(new SystemPanelQueryModel
                                {
                                    IdContains = profileids.Select(x => x.Value).ToArray(),
                                    IdNotContains = avalMenusForMe.Select(x => x.Id.Value).ToArray()
                                }));
                            }
                        }
                        else
                        {
                            return GetHttpResponseDTO.Forbidden<IEnumerable<SystemPanelDTO>>($"User does not have access to profile {mySelectedAccess.UserProfileId}");
                        }
                    }

                    return GetHttpResponseDTO.Ok<IEnumerable<SystemPanelDTO>>(avalMenusForMe);
                }
            }
            else
            {
                return GetHttpResponseDTO.ErrorTyped<IEnumerable<SystemPanelDTO>>("User is not logged in.");
            }
        }

    }
}
