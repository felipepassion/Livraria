﻿//using Microsoft.AspNetCore.Mvc;
//using Niu.Nutri.Users.Application.DTO.Aggregates.UsersAgg.Requests;
//using Niu.Nutri.Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;
//using System.ComponentModel.DataAnnotations;
//using Niu.Nutri.Users.Application.DTO.Aggregates.SystemSettingsAgg.Requests;

//namespace Niu.Nutri.Users.Controllers
//{
//    public partial class UserController
//    {
//        [HttpGet("{pageRoute}/access/{panelId}/{userId}/{subPanelId}")]
//        [HttpGet("{pageRoute}/access/{panelId}/{userId}")]
//        public async Task<GetHttpResponseDTO<UserDTO>> GetAccessOfPage([FromRoute] string pageRoute, [FromRoute] int panelId, [FromRoute] int? subPanelId, [FromRoute] string userId)
//        {
//            return await this.GetAsync<UserDTO>(uri: $"{pageRoute}/access/{panelId}/{userId}/{subPanelId}", request: null!);
//        }

//        [HttpGet("get-my-menus/{myId}")]
//        public async Task<GetHttpResponseDTO<SystemPanelListiningDTO[]>> GetMyMenus([Required] int? myId)
//        {
//            return await this.SearchAsync<SystemPanelListiningDTO>(uri: $"/get-my-menus/{myId}", size: 100);
//        }
//    }
//}