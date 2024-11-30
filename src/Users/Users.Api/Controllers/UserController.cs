using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Niu.Nutri.Core.Application.DTO.Extensions;
using Niu.Nutri.Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;
using Niu.Nutri.Users.Application.Aggregates.UsersAgg.AppServices;
using Niu.Nutri.Users.Application.DTO.Aggregates.SystemSettingsAgg.Requests;
using Niu.Nutri.Users.Application.DTO.Aggregates.UsersAgg.Requests;
using Niu.Nutri.Users.Domain.Aggregates.SystemSettingsAgg.Repositories;
using Niu.Nutri.Users.Domain.Aggregates.UsersAgg.Queries.Models;
using Niu.Nutri.Users.Domain.Aggregates.UsersAgg.Repositories;
using Niu.Nutri.Users.Enumerations;
using Niu.Nutri.Users.Identity;
using System.ComponentModel.DataAnnotations;

namespace Niu.Nutri.Users.Api.Controllers
{
    public partial class UserController
    {
        [HttpGet("minha-rota-user/{id}")]
        public async Task<UserDTO> GetUserById(int id)
        {
            var myRepo = this._scope.GetRequiredService<IUserRepository>();

            var myUser = await myRepo.FindAsync(x => x.Id == id);

            return myRepo.ProjectedAs<UserDTO>();
        }

        [Authorize]
        [HttpPost("reset-user-current-access")]
        public async Task<GetHttpResponseDTO> ResetUserAccess()
        {
            var userId = int.Parse(User.GetUserId());
            using var userRepo = this._scope.GetRequiredService<IUserRepository>();
            var userAccessesService = this._scope.GetRequiredService<IUserProfileListAppService>();

            var me = await userRepo.FindAsync(x => x.Id == userId);
            if (me == null) { return GetHttpResponseDTO.Forbidden("Usuário não logado."); }

            me.SelectedAccess = null!;
            await userRepo.UnitOfWork.CommitAsync();

            var userAllAccesses = await userAccessesService.GetAll(new UserProfileListQueryModel { UserIdEqual = me.Id });

            return GetHttpResponseDTO.Ok(userAllAccesses);
        }

        [HttpPost("validate-engineer-user/{userId}/{password}")]
        public async Task<IActionResult> ValidateEngineerUser(string userId, string password)
        {
            var userManager = this._scope.GetRequiredService<UserManager<ApplicationUser>>();
            var signIn = this._scope.GetRequiredService<SignInManager<ApplicationUser>>();
            var me = await userManager.FindByIdAsync(userId);
            var user = await _userAppService.Get(new UserQueryModel { IdEqual = int.Parse(userId) });
            using var userProfileService = _scope.GetRequiredService<IUserProfileAppService>();
            var myProfile = await userProfileService.Get(new UserProfileQueryModel { IdEqual = user.SelectedAccess.UserProfileId });

            var result = await userManager.CheckPasswordAsync(me, password);
            if (result)
            {
                return Ok();
            }

            return NotFound();
        }
    }
}