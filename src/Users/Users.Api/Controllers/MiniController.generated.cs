
using Microsoft.AspNetCore.Mvc;
using Niu.Nutri.CrossCutting.Infra.Log.Contexts;
using Niu.Nutri.Core.Application.Aggregates.Common;
using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;
using Niu.Nutri.Core.Application.Extensions;
using Niu.Nutri.Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;
namespace Niu.Nutri.Users.Api.Controllers {
	using Domain.Aggregates.UsersAgg.Queries.Models;
	using Application.Aggregates.UsersAgg.AppServices;
	using Domain.Aggregates.UsersAgg.Entities;
	[ApiController]
    [Route("api/[controller]")]
	public partial class UserProfileAccessController : BaseMiniController {
		IUserProfileAccessAppService _userProfileAccessAppService;
		public UserProfileAccessController(
			IServiceProvider scope,
            ILogRequestContext logRequestContext,
			IUserProfileAccessAppService userProfileAccessAppService)
				: base(logRequestContext, scope)
			{ 
				_userProfileAccessAppService = userProfileAccessAppService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] UserProfileAccessQueryModel request) {
		    var obj = await _userProfileAccessAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] UserProfileAccessQueryModel request) {
            return GetHttpResponseDTO.Ok(await _userProfileAccessAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] UserProfileAccessQueryModel request, int page = 0, int size = 5) {
		    var obj = await _userProfileAccessAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] UserProfileAccessQueryModel request, int page = 0, int size = 5) {
		    var obj = await _userProfileAccessAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] UserProfileAccessQueryModel request, int? page = null, int? size = null) {
		    var obj = await _userProfileAccessAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<UserProfileAccess>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<GetHttpResponseDTO<object>> Post(Niu.Nutri.Users.Application.DTO.Aggregates.UsersAgg.Requests.UserProfileAccessDTO request) {
			var loggedUserId = User.GetLoggedInUserId<int>();
			var result = await _userProfileAccessAppService.Create(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<object>> Delete([FromQuery] UserProfileAccessQueryModel request) {
            var result = await _userProfileAccessAppService.Delete(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO<object>> DeleteRange(UserProfileAccessQueryModel request) {
            var result = await _userProfileAccessAppService.DeleteRange(request);
            return result.Success? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class UserCurrentAccessSelectedController : BaseMiniController {
		IUserCurrentAccessSelectedAppService _userCurrentAccessSelectedAppService;
		public UserCurrentAccessSelectedController(
			IServiceProvider scope,
            ILogRequestContext logRequestContext,
			IUserCurrentAccessSelectedAppService userCurrentAccessSelectedAppService)
				: base(logRequestContext, scope)
			{ 
				_userCurrentAccessSelectedAppService = userCurrentAccessSelectedAppService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] UserCurrentAccessSelectedQueryModel request) {
		    var obj = await _userCurrentAccessSelectedAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] UserCurrentAccessSelectedQueryModel request) {
            return GetHttpResponseDTO.Ok(await _userCurrentAccessSelectedAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] UserCurrentAccessSelectedQueryModel request, int page = 0, int size = 5) {
		    var obj = await _userCurrentAccessSelectedAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] UserCurrentAccessSelectedQueryModel request, int page = 0, int size = 5) {
		    var obj = await _userCurrentAccessSelectedAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] UserCurrentAccessSelectedQueryModel request, int? page = null, int? size = null) {
		    var obj = await _userCurrentAccessSelectedAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<UserCurrentAccessSelected>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<GetHttpResponseDTO<object>> Post(Niu.Nutri.Users.Application.DTO.Aggregates.UsersAgg.Requests.UserCurrentAccessSelectedDTO request) {
			var loggedUserId = User.GetLoggedInUserId<int>();
			var result = await _userCurrentAccessSelectedAppService.Create(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<object>> Delete([FromQuery] UserCurrentAccessSelectedQueryModel request) {
            var result = await _userCurrentAccessSelectedAppService.Delete(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO<object>> DeleteRange(UserCurrentAccessSelectedQueryModel request) {
            var result = await _userCurrentAccessSelectedAppService.DeleteRange(request);
            return result.Success? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class UserProfileListController : BaseMiniController {
		IUserProfileListAppService _userProfileListAppService;
		public UserProfileListController(
			IServiceProvider scope,
            ILogRequestContext logRequestContext,
			IUserProfileListAppService userProfileListAppService)
				: base(logRequestContext, scope)
			{ 
				_userProfileListAppService = userProfileListAppService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] UserProfileListQueryModel request) {
		    var obj = await _userProfileListAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] UserProfileListQueryModel request) {
            return GetHttpResponseDTO.Ok(await _userProfileListAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] UserProfileListQueryModel request, int page = 0, int size = 5) {
		    var obj = await _userProfileListAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] UserProfileListQueryModel request, int page = 0, int size = 5) {
		    var obj = await _userProfileListAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] UserProfileListQueryModel request, int? page = null, int? size = null) {
		    var obj = await _userProfileListAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<UserProfileList>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<GetHttpResponseDTO<object>> Post(Niu.Nutri.Users.Application.DTO.Aggregates.UsersAgg.Requests.UserProfileListDTO request) {
			var loggedUserId = User.GetLoggedInUserId<int>();
			var result = await _userProfileListAppService.Create(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<object>> Delete([FromQuery] UserProfileListQueryModel request) {
            var result = await _userProfileListAppService.Delete(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO<object>> DeleteRange(UserProfileListQueryModel request) {
            var result = await _userProfileListAppService.DeleteRange(request);
            return result.Success? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class UserProfileController : BaseMiniController {
		IUserProfileAppService _userProfileAppService;
		public UserProfileController(
			IServiceProvider scope,
            ILogRequestContext logRequestContext,
			IUserProfileAppService userProfileAppService)
				: base(logRequestContext, scope)
			{ 
				_userProfileAppService = userProfileAppService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] UserProfileQueryModel request) {
		    var obj = await _userProfileAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] UserProfileQueryModel request) {
            return GetHttpResponseDTO.Ok(await _userProfileAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] UserProfileQueryModel request, int page = 0, int size = 5) {
		    var obj = await _userProfileAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] UserProfileQueryModel request, int page = 0, int size = 5) {
		    var obj = await _userProfileAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] UserProfileQueryModel request, int? page = null, int? size = null) {
		    var obj = await _userProfileAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<UserProfile>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<GetHttpResponseDTO<object>> Post(Niu.Nutri.Users.Application.DTO.Aggregates.UsersAgg.Requests.UserProfileDTO request) {
			var loggedUserId = User.GetLoggedInUserId<int>();
			var result = await _userProfileAppService.Create(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<object>> Delete([FromQuery] UserProfileQueryModel request) {
            var result = await _userProfileAppService.Delete(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO<object>> DeleteRange(UserProfileQueryModel request) {
            var result = await _userProfileAppService.DeleteRange(request);
            return result.Success? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class UsersAggSettingsController : BaseMiniController {
		IUsersAggSettingsAppService _usersAggSettingsAppService;
		public UsersAggSettingsController(
			IServiceProvider scope,
            ILogRequestContext logRequestContext,
			IUsersAggSettingsAppService usersAggSettingsAppService)
				: base(logRequestContext, scope)
			{ 
				_usersAggSettingsAppService = usersAggSettingsAppService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] UsersAggSettingsQueryModel request) {
		    var obj = await _usersAggSettingsAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] UsersAggSettingsQueryModel request) {
            return GetHttpResponseDTO.Ok(await _usersAggSettingsAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] UsersAggSettingsQueryModel request, int page = 0, int size = 5) {
		    var obj = await _usersAggSettingsAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] UsersAggSettingsQueryModel request, int page = 0, int size = 5) {
		    var obj = await _usersAggSettingsAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] UsersAggSettingsQueryModel request, int? page = null, int? size = null) {
		    var obj = await _usersAggSettingsAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<UsersAggSettings>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<GetHttpResponseDTO<object>> Post(Niu.Nutri.Users.Application.DTO.Aggregates.UsersAgg.Requests.UsersAggSettingsDTO request) {
			var loggedUserId = User.GetLoggedInUserId<int>();
			var result = await _usersAggSettingsAppService.Create(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<object>> Delete([FromQuery] UsersAggSettingsQueryModel request) {
            var result = await _usersAggSettingsAppService.Delete(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO<object>> DeleteRange(UsersAggSettingsQueryModel request) {
            var result = await _usersAggSettingsAppService.DeleteRange(request);
            return result.Success? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class UserController : BaseMiniController {
		IUserAppService _userAppService;
		public UserController(
			IServiceProvider scope,
            ILogRequestContext logRequestContext,
			IUserAppService userAppService)
				: base(logRequestContext, scope)
			{ 
				_userAppService = userAppService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] UserQueryModel request) {
		    var obj = await _userAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] UserQueryModel request) {
            return GetHttpResponseDTO.Ok(await _userAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] UserQueryModel request, int page = 0, int size = 5) {
		    var obj = await _userAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] UserQueryModel request, int page = 0, int size = 5) {
		    var obj = await _userAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] UserQueryModel request, int? page = null, int? size = null) {
		    var obj = await _userAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<User>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<GetHttpResponseDTO<object>> Post(Niu.Nutri.Users.Application.DTO.Aggregates.UsersAgg.Requests.UserDTO request) {
			var loggedUserId = User.GetLoggedInUserId<int>();
			var result = await _userAppService.Create(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<object>> Delete([FromQuery] UserQueryModel request) {
            var result = await _userAppService.Delete(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO<object>> DeleteRange(UserQueryModel request) {
            var result = await _userAppService.DeleteRange(request);
            return result.Success? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
	}
}
