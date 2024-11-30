

using Microsoft.AspNetCore.Mvc;
using Niu.Nutri.WebApp.Controllers;
using Niu.Nutri.Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;
namespace Niu.Nutri.Users.Controllers {
 using Domain.Aggregates.UsersAgg.Queries.Models;
 using Application.DTO.Aggregates.UsersAgg.Requests;
	[ApiController]
    [Route("api/[controller]")]
	public partial class UserProfileAccessController : BaseController {
		public UserProfileAccessController(IConfiguration configuration) : base(configuration) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<UserProfileAccessDTO>> Get([FromQuery] UserProfileAccessQueryModel request) {
            return await GetAsync<UserProfileAccessDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<UserProfileAccessDTO>> Count([FromQuery] UserProfileAccessQueryModel request) {
            return await GetAsync<UserProfileAccessDTO>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<UserProfileAccessDTO[]>> Get([FromQuery] UserProfileAccessQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<UserProfileAccessDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<UserProfileAccessDTO[]>> GetSummary([FromQuery] UserProfileAccessQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<UserProfileAccessDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<UserProfileAccessDTO[]>> Select([FromQuery] UserProfileAccessQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<UserProfileAccessDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<UserProfileAccessDTO>> Post(UserProfileAccessDTO request) {
            return await PostAsync<UserProfileAccessDTO>(request);
		}
        [HttpDelete("delete/{externalId}")]
		public async Task<GetHttpResponseDTO> Delete([FromRoute] string externalId) {
            return await DeleteAsync(externalId);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange(UserProfileAccessQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class UserCurrentAccessSelectedController : BaseController {
		public UserCurrentAccessSelectedController(IConfiguration configuration) : base(configuration) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<UserCurrentAccessSelectedDTO>> Get([FromQuery] UserCurrentAccessSelectedQueryModel request) {
            return await GetAsync<UserCurrentAccessSelectedDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<UserCurrentAccessSelectedDTO>> Count([FromQuery] UserCurrentAccessSelectedQueryModel request) {
            return await GetAsync<UserCurrentAccessSelectedDTO>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<UserCurrentAccessSelectedDTO[]>> Get([FromQuery] UserCurrentAccessSelectedQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<UserCurrentAccessSelectedDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<UserCurrentAccessSelectedDTO[]>> GetSummary([FromQuery] UserCurrentAccessSelectedQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<UserCurrentAccessSelectedDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<UserCurrentAccessSelectedDTO[]>> Select([FromQuery] UserCurrentAccessSelectedQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<UserCurrentAccessSelectedDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<UserCurrentAccessSelectedDTO>> Post(UserCurrentAccessSelectedDTO request) {
            return await PostAsync<UserCurrentAccessSelectedDTO>(request);
		}
        [HttpDelete("delete/{externalId}")]
		public async Task<GetHttpResponseDTO> Delete([FromRoute] string externalId) {
            return await DeleteAsync(externalId);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange(UserCurrentAccessSelectedQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class UserProfileListController : BaseController {
		public UserProfileListController(IConfiguration configuration) : base(configuration) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<UserProfileListDTO>> Get([FromQuery] UserProfileListQueryModel request) {
            return await GetAsync<UserProfileListDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<UserProfileListDTO>> Count([FromQuery] UserProfileListQueryModel request) {
            return await GetAsync<UserProfileListDTO>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<UserProfileListDTO[]>> Get([FromQuery] UserProfileListQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<UserProfileListDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<UserProfileListDTO[]>> GetSummary([FromQuery] UserProfileListQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<UserProfileListDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<UserProfileListDTO[]>> Select([FromQuery] UserProfileListQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<UserProfileListDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<UserProfileListDTO>> Post(UserProfileListDTO request) {
            return await PostAsync<UserProfileListDTO>(request);
		}
        [HttpDelete("delete/{externalId}")]
		public async Task<GetHttpResponseDTO> Delete([FromRoute] string externalId) {
            return await DeleteAsync(externalId);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange(UserProfileListQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class UserProfileController : BaseController {
		public UserProfileController(IConfiguration configuration) : base(configuration) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<UserProfileDTO>> Get([FromQuery] UserProfileQueryModel request) {
            return await GetAsync<UserProfileDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<UserProfileDTO>> Count([FromQuery] UserProfileQueryModel request) {
            return await GetAsync<UserProfileDTO>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<UserProfileDTO[]>> Get([FromQuery] UserProfileQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<UserProfileDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<UserProfileDTO[]>> GetSummary([FromQuery] UserProfileQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<UserProfileDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<UserProfileDTO[]>> Select([FromQuery] UserProfileQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<UserProfileDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<UserProfileDTO>> Post(UserProfileDTO request) {
            return await PostAsync<UserProfileDTO>(request);
		}
        [HttpDelete("delete/{externalId}")]
		public async Task<GetHttpResponseDTO> Delete([FromRoute] string externalId) {
            return await DeleteAsync(externalId);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange(UserProfileQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class UsersAggSettingsController : BaseController {
		public UsersAggSettingsController(IConfiguration configuration) : base(configuration) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<UsersAggSettingsDTO>> Get([FromQuery] UsersAggSettingsQueryModel request) {
            return await GetAsync<UsersAggSettingsDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<UsersAggSettingsDTO>> Count([FromQuery] UsersAggSettingsQueryModel request) {
            return await GetAsync<UsersAggSettingsDTO>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<UsersAggSettingsDTO[]>> Get([FromQuery] UsersAggSettingsQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<UsersAggSettingsDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<UsersAggSettingsDTO[]>> GetSummary([FromQuery] UsersAggSettingsQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<UsersAggSettingsDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<UsersAggSettingsDTO[]>> Select([FromQuery] UsersAggSettingsQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<UsersAggSettingsDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<UsersAggSettingsDTO>> Post(UsersAggSettingsDTO request) {
            return await PostAsync<UsersAggSettingsDTO>(request);
		}
        [HttpDelete("delete/{externalId}")]
		public async Task<GetHttpResponseDTO> Delete([FromRoute] string externalId) {
            return await DeleteAsync(externalId);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange(UsersAggSettingsQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class UserController : BaseController {
		public UserController(IConfiguration configuration) : base(configuration) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<UserDTO>> Get([FromQuery] UserQueryModel request) {
            return await GetAsync<UserDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<UserDTO>> Count([FromQuery] UserQueryModel request) {
            return await GetAsync<UserDTO>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<UserDTO[]>> Get([FromQuery] UserQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<UserDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<UserDTO[]>> GetSummary([FromQuery] UserQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<UserDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<UserDTO[]>> Select([FromQuery] UserQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<UserDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<UserDTO>> Post(UserDTO request) {
            return await PostAsync<UserDTO>(request);
		}
        [HttpDelete("delete/{externalId}")]
		public async Task<GetHttpResponseDTO> Delete([FromRoute] string externalId) {
            return await DeleteAsync(externalId);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange(UserQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
}
namespace Niu.Nutri.Chat.Controllers {
 using Domain.Aggregates.ChatAgg.Queries.Models;
 using Application.DTO.Aggregates.ChatAgg.Requests;
	[ApiController]
    [Route("api/[controller]")]
	public partial class ConversationController : BaseController {
		public ConversationController(IConfiguration configuration) : base(configuration) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<ConversationDTO>> Get([FromQuery] ConversationQueryModel request) {
            return await GetAsync<ConversationDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<ConversationDTO>> Count([FromQuery] ConversationQueryModel request) {
            return await GetAsync<ConversationDTO>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<ConversationDTO[]>> Get([FromQuery] ConversationQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<ConversationDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<ConversationDTO[]>> GetSummary([FromQuery] ConversationQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<ConversationDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<ConversationDTO[]>> Select([FromQuery] ConversationQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<ConversationDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<ConversationDTO>> Post(ConversationDTO request) {
            return await PostAsync<ConversationDTO>(request);
		}
        [HttpDelete("delete/{externalId}")]
		public async Task<GetHttpResponseDTO> Delete([FromRoute] string externalId) {
            return await DeleteAsync(externalId);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange(ConversationQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class MessageController : BaseController {
		public MessageController(IConfiguration configuration) : base(configuration) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<MessageDTO>> Get([FromQuery] MessageQueryModel request) {
            return await GetAsync<MessageDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<MessageDTO>> Count([FromQuery] MessageQueryModel request) {
            return await GetAsync<MessageDTO>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<MessageDTO[]>> Get([FromQuery] MessageQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<MessageDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<MessageDTO[]>> GetSummary([FromQuery] MessageQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<MessageDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<MessageDTO[]>> Select([FromQuery] MessageQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<MessageDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<MessageDTO>> Post(MessageDTO request) {
            return await PostAsync<MessageDTO>(request);
		}
        [HttpDelete("delete/{externalId}")]
		public async Task<GetHttpResponseDTO> Delete([FromRoute] string externalId) {
            return await DeleteAsync(externalId);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange(MessageQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class ChatAggSettingsController : BaseController {
		public ChatAggSettingsController(IConfiguration configuration) : base(configuration) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<ChatAggSettingsDTO>> Get([FromQuery] ChatAggSettingsQueryModel request) {
            return await GetAsync<ChatAggSettingsDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<ChatAggSettingsDTO>> Count([FromQuery] ChatAggSettingsQueryModel request) {
            return await GetAsync<ChatAggSettingsDTO>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<ChatAggSettingsDTO[]>> Get([FromQuery] ChatAggSettingsQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<ChatAggSettingsDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<ChatAggSettingsDTO[]>> GetSummary([FromQuery] ChatAggSettingsQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<ChatAggSettingsDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<ChatAggSettingsDTO[]>> Select([FromQuery] ChatAggSettingsQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<ChatAggSettingsDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<ChatAggSettingsDTO>> Post(ChatAggSettingsDTO request) {
            return await PostAsync<ChatAggSettingsDTO>(request);
		}
        [HttpDelete("delete/{externalId}")]
		public async Task<GetHttpResponseDTO> Delete([FromRoute] string externalId) {
            return await DeleteAsync(externalId);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange(ChatAggSettingsQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
}
namespace Niu.Nutri.Nests.Controllers {
 using Domain.Aggregates.NestsAgg.Queries.Models;
 using Application.DTO.Aggregates.NestsAgg.Requests;
	[ApiController]
    [Route("api/[controller]")]
	public partial class TagController : BaseController {
		public TagController(IConfiguration configuration) : base(configuration) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<TagDTO>> Get([FromQuery] TagQueryModel request) {
            return await GetAsync<TagDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<TagDTO>> Count([FromQuery] TagQueryModel request) {
            return await GetAsync<TagDTO>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<TagDTO[]>> Get([FromQuery] TagQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<TagDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<TagDTO[]>> GetSummary([FromQuery] TagQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<TagDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<TagDTO[]>> Select([FromQuery] TagQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<TagDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<TagDTO>> Post(TagDTO request) {
            return await PostAsync<TagDTO>(request);
		}
        [HttpDelete("delete/{externalId}")]
		public async Task<GetHttpResponseDTO> Delete([FromRoute] string externalId) {
            return await DeleteAsync(externalId);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange(TagQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class NestsAggSettingsController : BaseController {
		public NestsAggSettingsController(IConfiguration configuration) : base(configuration) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<NestsAggSettingsDTO>> Get([FromQuery] NestsAggSettingsQueryModel request) {
            return await GetAsync<NestsAggSettingsDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<NestsAggSettingsDTO>> Count([FromQuery] NestsAggSettingsQueryModel request) {
            return await GetAsync<NestsAggSettingsDTO>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<NestsAggSettingsDTO[]>> Get([FromQuery] NestsAggSettingsQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<NestsAggSettingsDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<NestsAggSettingsDTO[]>> GetSummary([FromQuery] NestsAggSettingsQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<NestsAggSettingsDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<NestsAggSettingsDTO[]>> Select([FromQuery] NestsAggSettingsQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<NestsAggSettingsDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<NestsAggSettingsDTO>> Post(NestsAggSettingsDTO request) {
            return await PostAsync<NestsAggSettingsDTO>(request);
		}
        [HttpDelete("delete/{externalId}")]
		public async Task<GetHttpResponseDTO> Delete([FromRoute] string externalId) {
            return await DeleteAsync(externalId);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange(NestsAggSettingsQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class NestLatLngController : BaseController {
		public NestLatLngController(IConfiguration configuration) : base(configuration) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<NestLatLngDTO>> Get([FromQuery] NestLatLngQueryModel request) {
            return await GetAsync<NestLatLngDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<NestLatLngDTO>> Count([FromQuery] NestLatLngQueryModel request) {
            return await GetAsync<NestLatLngDTO>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<NestLatLngDTO[]>> Get([FromQuery] NestLatLngQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<NestLatLngDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<NestLatLngDTO[]>> GetSummary([FromQuery] NestLatLngQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<NestLatLngDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<NestLatLngDTO[]>> Select([FromQuery] NestLatLngQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<NestLatLngDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<NestLatLngDTO>> Post(NestLatLngDTO request) {
            return await PostAsync<NestLatLngDTO>(request);
		}
        [HttpDelete("delete/{externalId}")]
		public async Task<GetHttpResponseDTO> Delete([FromRoute] string externalId) {
            return await DeleteAsync(externalId);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange(NestLatLngQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class NestController : BaseController {
		public NestController(IConfiguration configuration) : base(configuration) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<NestDTO>> Get([FromQuery] NestQueryModel request) {
            return await GetAsync<NestDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<NestDTO>> Count([FromQuery] NestQueryModel request) {
            return await GetAsync<NestDTO>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<NestDTO[]>> Get([FromQuery] NestQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<NestDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<NestDTO[]>> GetSummary([FromQuery] NestQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<NestDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<NestDTO[]>> Select([FromQuery] NestQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<NestDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<NestDTO>> Post(NestDTO request) {
            return await PostAsync<NestDTO>(request);
		}
        [HttpDelete("delete/{externalId}")]
		public async Task<GetHttpResponseDTO> Delete([FromRoute] string externalId) {
            return await DeleteAsync(externalId);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange(NestQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
}
namespace Niu.Nutri.SystemSettings.Controllers {
 using Domain.Aggregates.SystemSettingsAgg.Queries.Models;
 using Application.DTO.Aggregates.SystemSettingsAgg.Requests;
	[ApiController]
    [Route("api/[controller]")]
	public partial class SystemPanelSubItemController : BaseController {
		public SystemPanelSubItemController(IConfiguration configuration) : base(configuration) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<SystemPanelSubItemDTO>> Get([FromQuery] SystemPanelSubItemQueryModel request) {
            return await GetAsync<SystemPanelSubItemDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<SystemPanelSubItemDTO>> Count([FromQuery] SystemPanelSubItemQueryModel request) {
            return await GetAsync<SystemPanelSubItemDTO>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<SystemPanelSubItemDTO[]>> Get([FromQuery] SystemPanelSubItemQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<SystemPanelSubItemDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<SystemPanelSubItemDTO[]>> GetSummary([FromQuery] SystemPanelSubItemQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<SystemPanelSubItemDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<SystemPanelSubItemDTO[]>> Select([FromQuery] SystemPanelSubItemQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<SystemPanelSubItemDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<SystemPanelSubItemDTO>> Post(SystemPanelSubItemDTO request) {
            return await PostAsync<SystemPanelSubItemDTO>(request);
		}
        [HttpDelete("delete/{externalId}")]
		public async Task<GetHttpResponseDTO> Delete([FromRoute] string externalId) {
            return await DeleteAsync(externalId);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange(SystemPanelSubItemQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class SystemPanelController : BaseController {
		public SystemPanelController(IConfiguration configuration) : base(configuration) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<SystemPanelDTO>> Get([FromQuery] SystemPanelQueryModel request) {
            return await GetAsync<SystemPanelDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<SystemPanelDTO>> Count([FromQuery] SystemPanelQueryModel request) {
            return await GetAsync<SystemPanelDTO>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<SystemPanelDTO[]>> Get([FromQuery] SystemPanelQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<SystemPanelDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<SystemPanelDTO[]>> GetSummary([FromQuery] SystemPanelQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<SystemPanelDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<SystemPanelDTO[]>> Select([FromQuery] SystemPanelQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<SystemPanelDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<SystemPanelDTO>> Post(SystemPanelDTO request) {
            return await PostAsync<SystemPanelDTO>(request);
		}
        [HttpDelete("delete/{externalId}")]
		public async Task<GetHttpResponseDTO> Delete([FromRoute] string externalId) {
            return await DeleteAsync(externalId);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange(SystemPanelQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class SystemPanelGroupController : BaseController {
		public SystemPanelGroupController(IConfiguration configuration) : base(configuration) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<SystemPanelGroupDTO>> Get([FromQuery] SystemPanelGroupQueryModel request) {
            return await GetAsync<SystemPanelGroupDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<SystemPanelGroupDTO>> Count([FromQuery] SystemPanelGroupQueryModel request) {
            return await GetAsync<SystemPanelGroupDTO>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<SystemPanelGroupDTO[]>> Get([FromQuery] SystemPanelGroupQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<SystemPanelGroupDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<SystemPanelGroupDTO[]>> GetSummary([FromQuery] SystemPanelGroupQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<SystemPanelGroupDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<SystemPanelGroupDTO[]>> Select([FromQuery] SystemPanelGroupQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<SystemPanelGroupDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<SystemPanelGroupDTO>> Post(SystemPanelGroupDTO request) {
            return await PostAsync<SystemPanelGroupDTO>(request);
		}
        [HttpDelete("delete/{externalId}")]
		public async Task<GetHttpResponseDTO> Delete([FromRoute] string externalId) {
            return await DeleteAsync(externalId);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange(SystemPanelGroupQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class CargaTabelaController : BaseController {
		public CargaTabelaController(IConfiguration configuration) : base(configuration) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<CargaTabelaDTO>> Get([FromQuery] CargaTabelaQueryModel request) {
            return await GetAsync<CargaTabelaDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<CargaTabelaDTO>> Count([FromQuery] CargaTabelaQueryModel request) {
            return await GetAsync<CargaTabelaDTO>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<CargaTabelaDTO[]>> Get([FromQuery] CargaTabelaQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<CargaTabelaDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<CargaTabelaDTO[]>> GetSummary([FromQuery] CargaTabelaQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<CargaTabelaDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<CargaTabelaDTO[]>> Select([FromQuery] CargaTabelaQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<CargaTabelaDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<CargaTabelaDTO>> Post(CargaTabelaDTO request) {
            return await PostAsync<CargaTabelaDTO>(request);
		}
        [HttpDelete("delete/{externalId}")]
		public async Task<GetHttpResponseDTO> Delete([FromRoute] string externalId) {
            return await DeleteAsync(externalId);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange(CargaTabelaQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class SystemSettingsAggSettingsController : BaseController {
		public SystemSettingsAggSettingsController(IConfiguration configuration) : base(configuration) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<SystemSettingsAggSettingsDTO>> Get([FromQuery] SystemSettingsAggSettingsQueryModel request) {
            return await GetAsync<SystemSettingsAggSettingsDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<SystemSettingsAggSettingsDTO>> Count([FromQuery] SystemSettingsAggSettingsQueryModel request) {
            return await GetAsync<SystemSettingsAggSettingsDTO>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<SystemSettingsAggSettingsDTO[]>> Get([FromQuery] SystemSettingsAggSettingsQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<SystemSettingsAggSettingsDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<SystemSettingsAggSettingsDTO[]>> GetSummary([FromQuery] SystemSettingsAggSettingsQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<SystemSettingsAggSettingsDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<SystemSettingsAggSettingsDTO[]>> Select([FromQuery] SystemSettingsAggSettingsQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<SystemSettingsAggSettingsDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<SystemSettingsAggSettingsDTO>> Post(SystemSettingsAggSettingsDTO request) {
            return await PostAsync<SystemSettingsAggSettingsDTO>(request);
		}
        [HttpDelete("delete/{externalId}")]
		public async Task<GetHttpResponseDTO> Delete([FromRoute] string externalId) {
            return await DeleteAsync(externalId);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange(SystemSettingsAggSettingsQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
}
namespace Niu.Nutri.Addresses.Controllers {
 using Domain.Aggregates.AddressesAgg.Queries.Models;
 using Application.DTO.Aggregates.AddressesAgg.Requests;
	[ApiController]
    [Route("api/[controller]")]
	public partial class AddressController : BaseController {
		public AddressController(IConfiguration configuration) : base(configuration) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<AddressDTO>> Get([FromQuery] AddressQueryModel request) {
            return await GetAsync<AddressDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<AddressDTO>> Count([FromQuery] AddressQueryModel request) {
            return await GetAsync<AddressDTO>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<AddressDTO[]>> Get([FromQuery] AddressQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<AddressDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<AddressDTO[]>> GetSummary([FromQuery] AddressQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<AddressDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<AddressDTO[]>> Select([FromQuery] AddressQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<AddressDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<AddressDTO>> Post(AddressDTO request) {
            return await PostAsync<AddressDTO>(request);
		}
        [HttpDelete("delete/{externalId}")]
		public async Task<GetHttpResponseDTO> Delete([FromRoute] string externalId) {
            return await DeleteAsync(externalId);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange(AddressQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class AddressesAggSettingsController : BaseController {
		public AddressesAggSettingsController(IConfiguration configuration) : base(configuration) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<AddressesAggSettingsDTO>> Get([FromQuery] AddressesAggSettingsQueryModel request) {
            return await GetAsync<AddressesAggSettingsDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<AddressesAggSettingsDTO>> Count([FromQuery] AddressesAggSettingsQueryModel request) {
            return await GetAsync<AddressesAggSettingsDTO>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<AddressesAggSettingsDTO[]>> Get([FromQuery] AddressesAggSettingsQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<AddressesAggSettingsDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<AddressesAggSettingsDTO[]>> GetSummary([FromQuery] AddressesAggSettingsQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<AddressesAggSettingsDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<AddressesAggSettingsDTO[]>> Select([FromQuery] AddressesAggSettingsQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<AddressesAggSettingsDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<AddressesAggSettingsDTO>> Post(AddressesAggSettingsDTO request) {
            return await PostAsync<AddressesAggSettingsDTO>(request);
		}
        [HttpDelete("delete/{externalId}")]
		public async Task<GetHttpResponseDTO> Delete([FromRoute] string externalId) {
            return await DeleteAsync(externalId);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange(AddressesAggSettingsQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
}
