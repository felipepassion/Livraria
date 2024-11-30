using Microsoft.AspNetCore.Mvc;
using Niu.Nutri.WebApp.Controllers;
using Niu.Nutri.Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;
namespace Niu.Nutri.Users.Controllers {
 using Domain.Aggregates.UsersAgg.Queries.Models;
 using Application.DTO.Aggregates.UsersAgg.Requests;
	[ApiController]
    [Route("api/[controller]")]
	public partial class UserProfileAccessController : BaseController {
		public UserProfileAccessController(IServiceProvider provider) : base(provider) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<UserProfileAccessDTO>> Get([FromQuery] UserProfileAccessQueryModel request) {
            return await GetAsync<UserProfileAccessDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<int>> Count([FromQuery] UserProfileAccessQueryModel request) {
            return await GetAsync<UserProfileAccessDTO, int>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<List<UserProfileAccessDTO>>> Get([FromQuery] UserProfileAccessQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<UserProfileAccessDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<List<UserProfileAccessListiningDTO>>> GetSummary([FromQuery] UserProfileAccessQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<UserProfileAccessListiningDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<List<UserProfileAccessDTO>>> Select([FromQuery] UserProfileAccessQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<UserProfileAccessDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<UserProfileAccessDTO>> Post(UserProfileAccessDTO request) {
            return await PostAsync<UserProfileAccessDTO>(request);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<UserProfileAccessDTO>> Delete([FromQuery] UserProfileAccessQueryModel request) {
            return await DeleteAsync<UserProfileAccessDTO>(request);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange([FromQuery] UserProfileAccessQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class UserCurrentAccessSelectedController : BaseController {
		public UserCurrentAccessSelectedController(IServiceProvider provider) : base(provider) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<UserCurrentAccessSelectedDTO>> Get([FromQuery] UserCurrentAccessSelectedQueryModel request) {
            return await GetAsync<UserCurrentAccessSelectedDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<int>> Count([FromQuery] UserCurrentAccessSelectedQueryModel request) {
            return await GetAsync<UserCurrentAccessSelectedDTO, int>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<List<UserCurrentAccessSelectedDTO>>> Get([FromQuery] UserCurrentAccessSelectedQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<UserCurrentAccessSelectedDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<List<UserCurrentAccessSelectedListiningDTO>>> GetSummary([FromQuery] UserCurrentAccessSelectedQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<UserCurrentAccessSelectedListiningDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<List<UserCurrentAccessSelectedDTO>>> Select([FromQuery] UserCurrentAccessSelectedQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<UserCurrentAccessSelectedDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<UserCurrentAccessSelectedDTO>> Post(UserCurrentAccessSelectedDTO request) {
            return await PostAsync<UserCurrentAccessSelectedDTO>(request);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<UserCurrentAccessSelectedDTO>> Delete([FromQuery] UserCurrentAccessSelectedQueryModel request) {
            return await DeleteAsync<UserCurrentAccessSelectedDTO>(request);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange([FromQuery] UserCurrentAccessSelectedQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class UserProfileListController : BaseController {
		public UserProfileListController(IServiceProvider provider) : base(provider) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<UserProfileListDTO>> Get([FromQuery] UserProfileListQueryModel request) {
            return await GetAsync<UserProfileListDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<int>> Count([FromQuery] UserProfileListQueryModel request) {
            return await GetAsync<UserProfileListDTO, int>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<List<UserProfileListDTO>>> Get([FromQuery] UserProfileListQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<UserProfileListDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<List<UserProfileListListiningDTO>>> GetSummary([FromQuery] UserProfileListQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<UserProfileListListiningDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<List<UserProfileListDTO>>> Select([FromQuery] UserProfileListQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<UserProfileListDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<UserProfileListDTO>> Post(UserProfileListDTO request) {
            return await PostAsync<UserProfileListDTO>(request);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<UserProfileListDTO>> Delete([FromQuery] UserProfileListQueryModel request) {
            return await DeleteAsync<UserProfileListDTO>(request);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange([FromQuery] UserProfileListQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class UserProfileController : BaseController {
		public UserProfileController(IServiceProvider provider) : base(provider) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<UserProfileDTO>> Get([FromQuery] UserProfileQueryModel request) {
            return await GetAsync<UserProfileDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<int>> Count([FromQuery] UserProfileQueryModel request) {
            return await GetAsync<UserProfileDTO, int>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<List<UserProfileDTO>>> Get([FromQuery] UserProfileQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<UserProfileDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<List<UserProfileListiningDTO>>> GetSummary([FromQuery] UserProfileQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<UserProfileListiningDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<List<UserProfileDTO>>> Select([FromQuery] UserProfileQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<UserProfileDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<UserProfileDTO>> Post(UserProfileDTO request) {
            return await PostAsync<UserProfileDTO>(request);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<UserProfileDTO>> Delete([FromQuery] UserProfileQueryModel request) {
            return await DeleteAsync<UserProfileDTO>(request);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange([FromQuery] UserProfileQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class UsersAggSettingsController : BaseController {
		public UsersAggSettingsController(IServiceProvider provider) : base(provider) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<UsersAggSettingsDTO>> Get([FromQuery] UsersAggSettingsQueryModel request) {
            return await GetAsync<UsersAggSettingsDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<int>> Count([FromQuery] UsersAggSettingsQueryModel request) {
            return await GetAsync<UsersAggSettingsDTO, int>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<List<UsersAggSettingsDTO>>> Get([FromQuery] UsersAggSettingsQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<UsersAggSettingsDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<List<UsersAggSettingsListiningDTO>>> GetSummary([FromQuery] UsersAggSettingsQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<UsersAggSettingsListiningDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<List<UsersAggSettingsDTO>>> Select([FromQuery] UsersAggSettingsQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<UsersAggSettingsDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<UsersAggSettingsDTO>> Post(UsersAggSettingsDTO request) {
            return await PostAsync<UsersAggSettingsDTO>(request);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<UsersAggSettingsDTO>> Delete([FromQuery] UsersAggSettingsQueryModel request) {
            return await DeleteAsync<UsersAggSettingsDTO>(request);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange([FromQuery] UsersAggSettingsQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class UserController : BaseController {
		public UserController(IServiceProvider provider) : base(provider) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<UserDTO>> Get([FromQuery] UserQueryModel request) {
            return await GetAsync<UserDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<int>> Count([FromQuery] UserQueryModel request) {
            return await GetAsync<UserDTO, int>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<List<UserDTO>>> Get([FromQuery] UserQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<UserDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<List<UserListiningDTO>>> GetSummary([FromQuery] UserQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<UserListiningDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<List<UserDTO>>> Select([FromQuery] UserQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<UserDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<UserDTO>> Post(UserDTO request) {
            return await PostAsync<UserDTO>(request);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<UserDTO>> Delete([FromQuery] UserQueryModel request) {
            return await DeleteAsync<UserDTO>(request);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange([FromQuery] UserQueryModel request) {
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
		public ConversationController(IServiceProvider provider) : base(provider) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<ConversationDTO>> Get([FromQuery] ConversationQueryModel request) {
            return await GetAsync<ConversationDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<int>> Count([FromQuery] ConversationQueryModel request) {
            return await GetAsync<ConversationDTO, int>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<List<ConversationDTO>>> Get([FromQuery] ConversationQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<ConversationDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<List<ConversationListiningDTO>>> GetSummary([FromQuery] ConversationQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<ConversationListiningDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<List<ConversationDTO>>> Select([FromQuery] ConversationQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<ConversationDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<ConversationDTO>> Post(ConversationDTO request) {
            return await PostAsync<ConversationDTO>(request);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<ConversationDTO>> Delete([FromQuery] ConversationQueryModel request) {
            return await DeleteAsync<ConversationDTO>(request);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange([FromQuery] ConversationQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class ChatAggSettingsController : BaseController {
		public ChatAggSettingsController(IServiceProvider provider) : base(provider) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<ChatAggSettingsDTO>> Get([FromQuery] ChatAggSettingsQueryModel request) {
            return await GetAsync<ChatAggSettingsDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<int>> Count([FromQuery] ChatAggSettingsQueryModel request) {
            return await GetAsync<ChatAggSettingsDTO, int>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<List<ChatAggSettingsDTO>>> Get([FromQuery] ChatAggSettingsQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<ChatAggSettingsDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<List<ChatAggSettingsListiningDTO>>> GetSummary([FromQuery] ChatAggSettingsQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<ChatAggSettingsListiningDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<List<ChatAggSettingsDTO>>> Select([FromQuery] ChatAggSettingsQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<ChatAggSettingsDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<ChatAggSettingsDTO>> Post(ChatAggSettingsDTO request) {
            return await PostAsync<ChatAggSettingsDTO>(request);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<ChatAggSettingsDTO>> Delete([FromQuery] ChatAggSettingsQueryModel request) {
            return await DeleteAsync<ChatAggSettingsDTO>(request);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange([FromQuery] ChatAggSettingsQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class ConversationMessageController : BaseController {
		public ConversationMessageController(IServiceProvider provider) : base(provider) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<ConversationMessageDTO>> Get([FromQuery] ConversationMessageQueryModel request) {
            return await GetAsync<ConversationMessageDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<int>> Count([FromQuery] ConversationMessageQueryModel request) {
            return await GetAsync<ConversationMessageDTO, int>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<List<ConversationMessageDTO>>> Get([FromQuery] ConversationMessageQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<ConversationMessageDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<List<ConversationMessageListiningDTO>>> GetSummary([FromQuery] ConversationMessageQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<ConversationMessageListiningDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<List<ConversationMessageDTO>>> Select([FromQuery] ConversationMessageQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<ConversationMessageDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<ConversationMessageDTO>> Post(ConversationMessageDTO request) {
            return await PostAsync<ConversationMessageDTO>(request);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<ConversationMessageDTO>> Delete([FromQuery] ConversationMessageQueryModel request) {
            return await DeleteAsync<ConversationMessageDTO>(request);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange([FromQuery] ConversationMessageQueryModel request) {
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
		public SystemPanelSubItemController(IServiceProvider provider) : base(provider) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<SystemPanelSubItemDTO>> Get([FromQuery] SystemPanelSubItemQueryModel request) {
            return await GetAsync<SystemPanelSubItemDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<int>> Count([FromQuery] SystemPanelSubItemQueryModel request) {
            return await GetAsync<SystemPanelSubItemDTO, int>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<List<SystemPanelSubItemDTO>>> Get([FromQuery] SystemPanelSubItemQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<SystemPanelSubItemDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<List<SystemPanelSubItemListiningDTO>>> GetSummary([FromQuery] SystemPanelSubItemQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<SystemPanelSubItemListiningDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<List<SystemPanelSubItemDTO>>> Select([FromQuery] SystemPanelSubItemQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<SystemPanelSubItemDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<SystemPanelSubItemDTO>> Post(SystemPanelSubItemDTO request) {
            return await PostAsync<SystemPanelSubItemDTO>(request);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<SystemPanelSubItemDTO>> Delete([FromQuery] SystemPanelSubItemQueryModel request) {
            return await DeleteAsync<SystemPanelSubItemDTO>(request);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange([FromQuery] SystemPanelSubItemQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class SystemPanelController : BaseController {
		public SystemPanelController(IServiceProvider provider) : base(provider) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<SystemPanelDTO>> Get([FromQuery] SystemPanelQueryModel request) {
            return await GetAsync<SystemPanelDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<int>> Count([FromQuery] SystemPanelQueryModel request) {
            return await GetAsync<SystemPanelDTO, int>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<List<SystemPanelDTO>>> Get([FromQuery] SystemPanelQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<SystemPanelDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<List<SystemPanelListiningDTO>>> GetSummary([FromQuery] SystemPanelQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<SystemPanelListiningDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<List<SystemPanelDTO>>> Select([FromQuery] SystemPanelQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<SystemPanelDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<SystemPanelDTO>> Post(SystemPanelDTO request) {
            return await PostAsync<SystemPanelDTO>(request);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<SystemPanelDTO>> Delete([FromQuery] SystemPanelQueryModel request) {
            return await DeleteAsync<SystemPanelDTO>(request);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange([FromQuery] SystemPanelQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class SystemPanelGroupController : BaseController {
		public SystemPanelGroupController(IServiceProvider provider) : base(provider) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<SystemPanelGroupDTO>> Get([FromQuery] SystemPanelGroupQueryModel request) {
            return await GetAsync<SystemPanelGroupDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<int>> Count([FromQuery] SystemPanelGroupQueryModel request) {
            return await GetAsync<SystemPanelGroupDTO, int>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<List<SystemPanelGroupDTO>>> Get([FromQuery] SystemPanelGroupQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<SystemPanelGroupDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<List<SystemPanelGroupListiningDTO>>> GetSummary([FromQuery] SystemPanelGroupQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<SystemPanelGroupListiningDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<List<SystemPanelGroupDTO>>> Select([FromQuery] SystemPanelGroupQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<SystemPanelGroupDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<SystemPanelGroupDTO>> Post(SystemPanelGroupDTO request) {
            return await PostAsync<SystemPanelGroupDTO>(request);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<SystemPanelGroupDTO>> Delete([FromQuery] SystemPanelGroupQueryModel request) {
            return await DeleteAsync<SystemPanelGroupDTO>(request);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange([FromQuery] SystemPanelGroupQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class CargaTabelaController : BaseController {
		public CargaTabelaController(IServiceProvider provider) : base(provider) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<CargaTabelaDTO>> Get([FromQuery] CargaTabelaQueryModel request) {
            return await GetAsync<CargaTabelaDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<int>> Count([FromQuery] CargaTabelaQueryModel request) {
            return await GetAsync<CargaTabelaDTO, int>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<List<CargaTabelaDTO>>> Get([FromQuery] CargaTabelaQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<CargaTabelaDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<List<CargaTabelaListiningDTO>>> GetSummary([FromQuery] CargaTabelaQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<CargaTabelaListiningDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<List<CargaTabelaDTO>>> Select([FromQuery] CargaTabelaQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<CargaTabelaDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<CargaTabelaDTO>> Post(CargaTabelaDTO request) {
            return await PostAsync<CargaTabelaDTO>(request);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<CargaTabelaDTO>> Delete([FromQuery] CargaTabelaQueryModel request) {
            return await DeleteAsync<CargaTabelaDTO>(request);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange([FromQuery] CargaTabelaQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class SystemSettingsAggSettingsController : BaseController {
		public SystemSettingsAggSettingsController(IServiceProvider provider) : base(provider) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<SystemSettingsAggSettingsDTO>> Get([FromQuery] SystemSettingsAggSettingsQueryModel request) {
            return await GetAsync<SystemSettingsAggSettingsDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<int>> Count([FromQuery] SystemSettingsAggSettingsQueryModel request) {
            return await GetAsync<SystemSettingsAggSettingsDTO, int>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<List<SystemSettingsAggSettingsDTO>>> Get([FromQuery] SystemSettingsAggSettingsQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<SystemSettingsAggSettingsDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<List<SystemSettingsAggSettingsListiningDTO>>> GetSummary([FromQuery] SystemSettingsAggSettingsQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<SystemSettingsAggSettingsListiningDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<List<SystemSettingsAggSettingsDTO>>> Select([FromQuery] SystemSettingsAggSettingsQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<SystemSettingsAggSettingsDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<SystemSettingsAggSettingsDTO>> Post(SystemSettingsAggSettingsDTO request) {
            return await PostAsync<SystemSettingsAggSettingsDTO>(request);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<SystemSettingsAggSettingsDTO>> Delete([FromQuery] SystemSettingsAggSettingsQueryModel request) {
            return await DeleteAsync<SystemSettingsAggSettingsDTO>(request);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange([FromQuery] SystemSettingsAggSettingsQueryModel request) {
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
		public AddressController(IServiceProvider provider) : base(provider) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<AddressDTO>> Get([FromQuery] AddressQueryModel request) {
            return await GetAsync<AddressDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<int>> Count([FromQuery] AddressQueryModel request) {
            return await GetAsync<AddressDTO, int>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<List<AddressDTO>>> Get([FromQuery] AddressQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<AddressDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<List<AddressListiningDTO>>> GetSummary([FromQuery] AddressQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<AddressListiningDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<List<AddressDTO>>> Select([FromQuery] AddressQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<AddressDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<AddressDTO>> Post(AddressDTO request) {
            return await PostAsync<AddressDTO>(request);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<AddressDTO>> Delete([FromQuery] AddressQueryModel request) {
            return await DeleteAsync<AddressDTO>(request);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange([FromQuery] AddressQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class AddressesAggSettingsController : BaseController {
		public AddressesAggSettingsController(IServiceProvider provider) : base(provider) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<AddressesAggSettingsDTO>> Get([FromQuery] AddressesAggSettingsQueryModel request) {
            return await GetAsync<AddressesAggSettingsDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<int>> Count([FromQuery] AddressesAggSettingsQueryModel request) {
            return await GetAsync<AddressesAggSettingsDTO, int>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<List<AddressesAggSettingsDTO>>> Get([FromQuery] AddressesAggSettingsQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<AddressesAggSettingsDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<List<AddressesAggSettingsListiningDTO>>> GetSummary([FromQuery] AddressesAggSettingsQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<AddressesAggSettingsListiningDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<List<AddressesAggSettingsDTO>>> Select([FromQuery] AddressesAggSettingsQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<AddressesAggSettingsDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<AddressesAggSettingsDTO>> Post(AddressesAggSettingsDTO request) {
            return await PostAsync<AddressesAggSettingsDTO>(request);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<AddressesAggSettingsDTO>> Delete([FromQuery] AddressesAggSettingsQueryModel request) {
            return await DeleteAsync<AddressesAggSettingsDTO>(request);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange([FromQuery] AddressesAggSettingsQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
}
namespace Niu.Nutri.Livraria.Controllers {
 using Domain.Aggregates.LivrariaAgg.Queries.Models;
 using Application.DTO.Aggregates.LivrariaAgg.Requests;
	[ApiController]
    [Route("api/[controller]")]
	public partial class Livro_AutorController : BaseController {
		public Livro_AutorController(IServiceProvider provider) : base(provider) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<Livro_AutorDTO>> Get([FromQuery] Livro_AutorQueryModel request) {
            return await GetAsync<Livro_AutorDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<int>> Count([FromQuery] Livro_AutorQueryModel request) {
            return await GetAsync<Livro_AutorDTO, int>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<List<Livro_AutorDTO>>> Get([FromQuery] Livro_AutorQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<Livro_AutorDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<List<Livro_AutorListiningDTO>>> GetSummary([FromQuery] Livro_AutorQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<Livro_AutorListiningDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<List<Livro_AutorDTO>>> Select([FromQuery] Livro_AutorQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<Livro_AutorDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<Livro_AutorDTO>> Post(Livro_AutorDTO request) {
            return await PostAsync<Livro_AutorDTO>(request);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<Livro_AutorDTO>> Delete([FromQuery] Livro_AutorQueryModel request) {
            return await DeleteAsync<Livro_AutorDTO>(request);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange([FromQuery] Livro_AutorQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class LivroController : BaseController {
		public LivroController(IServiceProvider provider) : base(provider) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<LivroDTO>> Get([FromQuery] LivroQueryModel request) {
            return await GetAsync<LivroDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<int>> Count([FromQuery] LivroQueryModel request) {
            return await GetAsync<LivroDTO, int>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<List<LivroDTO>>> Get([FromQuery] LivroQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<LivroDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<List<LivroListiningDTO>>> GetSummary([FromQuery] LivroQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<LivroListiningDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<List<LivroDTO>>> Select([FromQuery] LivroQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<LivroDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<LivroDTO>> Post(LivroDTO request) {
            return await PostAsync<LivroDTO>(request);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<LivroDTO>> Delete([FromQuery] LivroQueryModel request) {
            return await DeleteAsync<LivroDTO>(request);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange([FromQuery] LivroQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class AssuntoController : BaseController {
		public AssuntoController(IServiceProvider provider) : base(provider) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<AssuntoDTO>> Get([FromQuery] AssuntoQueryModel request) {
            return await GetAsync<AssuntoDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<int>> Count([FromQuery] AssuntoQueryModel request) {
            return await GetAsync<AssuntoDTO, int>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<List<AssuntoDTO>>> Get([FromQuery] AssuntoQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<AssuntoDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<List<AssuntoListiningDTO>>> GetSummary([FromQuery] AssuntoQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<AssuntoListiningDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<List<AssuntoDTO>>> Select([FromQuery] AssuntoQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<AssuntoDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<AssuntoDTO>> Post(AssuntoDTO request) {
            return await PostAsync<AssuntoDTO>(request);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<AssuntoDTO>> Delete([FromQuery] AssuntoQueryModel request) {
            return await DeleteAsync<AssuntoDTO>(request);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange([FromQuery] AssuntoQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class Livro_AssuntoController : BaseController {
		public Livro_AssuntoController(IServiceProvider provider) : base(provider) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<Livro_AssuntoDTO>> Get([FromQuery] Livro_AssuntoQueryModel request) {
            return await GetAsync<Livro_AssuntoDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<int>> Count([FromQuery] Livro_AssuntoQueryModel request) {
            return await GetAsync<Livro_AssuntoDTO, int>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<List<Livro_AssuntoDTO>>> Get([FromQuery] Livro_AssuntoQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<Livro_AssuntoDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<List<Livro_AssuntoListiningDTO>>> GetSummary([FromQuery] Livro_AssuntoQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<Livro_AssuntoListiningDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<List<Livro_AssuntoDTO>>> Select([FromQuery] Livro_AssuntoQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<Livro_AssuntoDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<Livro_AssuntoDTO>> Post(Livro_AssuntoDTO request) {
            return await PostAsync<Livro_AssuntoDTO>(request);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<Livro_AssuntoDTO>> Delete([FromQuery] Livro_AssuntoQueryModel request) {
            return await DeleteAsync<Livro_AssuntoDTO>(request);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange([FromQuery] Livro_AssuntoQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class AutorController : BaseController {
		public AutorController(IServiceProvider provider) : base(provider) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<AutorDTO>> Get([FromQuery] AutorQueryModel request) {
            return await GetAsync<AutorDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<int>> Count([FromQuery] AutorQueryModel request) {
            return await GetAsync<AutorDTO, int>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<List<AutorDTO>>> Get([FromQuery] AutorQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<AutorDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<List<AutorListiningDTO>>> GetSummary([FromQuery] AutorQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<AutorListiningDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<List<AutorDTO>>> Select([FromQuery] AutorQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<AutorDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<AutorDTO>> Post(AutorDTO request) {
            return await PostAsync<AutorDTO>(request);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<AutorDTO>> Delete([FromQuery] AutorQueryModel request) {
            return await DeleteAsync<AutorDTO>(request);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange([FromQuery] AutorQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class LivrariaAggSettingsController : BaseController {
		public LivrariaAggSettingsController(IServiceProvider provider) : base(provider) { }
		[HttpGet]
		public async Task<GetHttpResponseDTO<LivrariaAggSettingsDTO>> Get([FromQuery] LivrariaAggSettingsQueryModel request) {
            return await GetAsync<LivrariaAggSettingsDTO>(request);
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<int>> Count([FromQuery] LivrariaAggSettingsQueryModel request) {
            return await GetAsync<LivrariaAggSettingsDTO, int>("count", request);
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<List<LivrariaAggSettingsDTO>>> Get([FromQuery] LivrariaAggSettingsQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<LivrariaAggSettingsDTO>("search", request, page, size);

        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<List<LivrariaAggSettingsListiningDTO>>> GetSummary([FromQuery] LivrariaAggSettingsQueryModel request, int page = 0, int size = 5) {
            return await SearchAsync<LivrariaAggSettingsListiningDTO>("summary", request, page, size);
        }
		[HttpGet("select")]
		public async Task<GetHttpResponseDTO<List<LivrariaAggSettingsDTO>>> Select([FromQuery] LivrariaAggSettingsQueryModel request, int? page = null, int? size = null) {
            return await SearchAsync<LivrariaAggSettingsDTO>("select", request, page, size);
        }
		[HttpPost]
		public async Task<GetHttpResponseDTO<LivrariaAggSettingsDTO>> Post(LivrariaAggSettingsDTO request) {
            return await PostAsync<LivrariaAggSettingsDTO>(request);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<LivrariaAggSettingsDTO>> Delete([FromQuery] LivrariaAggSettingsQueryModel request) {
            return await DeleteAsync<LivrariaAggSettingsDTO>(request);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO> DeleteRange([FromQuery] LivrariaAggSettingsQueryModel request) {
            return GetHttpResponseDTO.Ok();
        }
	}
}
