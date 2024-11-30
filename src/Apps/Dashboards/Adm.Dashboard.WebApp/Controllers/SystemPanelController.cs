using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Niu.Nutri.Core.Application.DTO.Extensions;
using Niu.Nutri.Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;
using Niu.Nutri.SystemSettings.Application.DTO.Aggregates.SystemSettingsAgg.Requests;
using Niu.Nutri.Users.Application.DTO.Aggregates.UsersAgg.Requests;

namespace Niu.Nutri.SystemSettings.Controllers
{
    public partial class SystemPanelController
    {
        [Authorize]
        [HttpGet("{pageRoute}/access/{panelId}/{subPanelId}")]
        [HttpGet("{pageRoute}/access/{panelId}")]
        public async Task<GetHttpResponseDTO<UserDTO>> GetAccessOfPage([FromRoute] string pageRoute, [FromRoute] int panelId, [FromRoute] int? subPanelId)
        {
            var userId = User.GetUserId();
            return await this.GetAsync<UserDTO>(uri: $"{pageRoute}/access/{panelId}/{userId}/{subPanelId}", request: null!);
        }

        [Authorize]
        [HttpGet("get-my-menus")]
        public async Task<GetHttpResponseDTO<List<SystemPanelDTO>>> GetMyMenus()
        {
            return await this.SearchAsync<SystemPanelDTO>(uri: $"/get-my-menus/{User.GetUserId()}", size: 100);
        }



    }
}