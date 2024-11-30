using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Niu.Nutri.Core.Application.DTO.Extensions;
using Niu.Nutri.Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;
using Niu.Nutri.Users.Application.DTO.Aggregates.UsersAgg.Requests;
using Niu.Nutri.Users.Domain.Aggregates.UsersAgg.Queries.Models;

namespace Niu.Nutri.Users.Controllers
{
    public partial class UserProfileListController
    {
        [Authorize]
        [HttpGet("get-my-companies")]
        public async Task<GetHttpResponseDTO<List<UserProfileListDTO>>> GetMyCompoanies()
        {
            var userId = int.Parse(User.GetUserId());
            var access = await base.SearchAsync<UserProfileListDTO>(new UserProfileListQueryModel { UserIdEqual = userId });
            return access;
        }
    }
}
