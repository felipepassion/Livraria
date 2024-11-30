
using Microsoft.AspNetCore.Mvc;
using Niu.Nutri.CrossCutting.Infra.Log.Contexts;
using Niu.Nutri.Core.Application.Aggregates.Common;
using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;
using Niu.Nutri.Core.Application.Extensions;
using Niu.Nutri.Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;
namespace Niu.Nutri.Chat.Api.Controllers {
	using Domain.Aggregates.ChatAgg.Queries.Models;
	using Application.Aggregates.ChatAgg.AppServices;
	using Domain.Aggregates.ChatAgg.Entities;
	[ApiController]
    [Route("api/[controller]")]
	public partial class ConversationController : BaseMiniController {
		IConversationAppService _conversationAppService;
		public ConversationController(
			IServiceProvider scope,
            ILogRequestContext logRequestContext,
			IConversationAppService conversationAppService)
				: base(logRequestContext, scope)
			{ 
				_conversationAppService = conversationAppService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] ConversationQueryModel request) {
		    var obj = await _conversationAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] ConversationQueryModel request) {
            return GetHttpResponseDTO.Ok(await _conversationAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] ConversationQueryModel request, int page = 0, int size = 5) {
		    var obj = await _conversationAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] ConversationQueryModel request, int page = 0, int size = 5) {
		    var obj = await _conversationAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] ConversationQueryModel request, int? page = null, int? size = null) {
		    var obj = await _conversationAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<Conversation>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<GetHttpResponseDTO<object>> Post(Niu.Nutri.Chat.Application.DTO.Aggregates.ChatAgg.Requests.ConversationDTO request) {
			var loggedUserId = User.GetLoggedInUserId<int>();
			var result = await _conversationAppService.Create(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<object>> Delete([FromQuery] ConversationQueryModel request) {
            var result = await _conversationAppService.Delete(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO<object>> DeleteRange(ConversationQueryModel request) {
            var result = await _conversationAppService.DeleteRange(request);
            return result.Success? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class ChatAggSettingsController : BaseMiniController {
		IChatAggSettingsAppService _chatAggSettingsAppService;
		public ChatAggSettingsController(
			IServiceProvider scope,
            ILogRequestContext logRequestContext,
			IChatAggSettingsAppService chatAggSettingsAppService)
				: base(logRequestContext, scope)
			{ 
				_chatAggSettingsAppService = chatAggSettingsAppService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] ChatAggSettingsQueryModel request) {
		    var obj = await _chatAggSettingsAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] ChatAggSettingsQueryModel request) {
            return GetHttpResponseDTO.Ok(await _chatAggSettingsAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] ChatAggSettingsQueryModel request, int page = 0, int size = 5) {
		    var obj = await _chatAggSettingsAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] ChatAggSettingsQueryModel request, int page = 0, int size = 5) {
		    var obj = await _chatAggSettingsAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] ChatAggSettingsQueryModel request, int? page = null, int? size = null) {
		    var obj = await _chatAggSettingsAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<ChatAggSettings>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<GetHttpResponseDTO<object>> Post(Niu.Nutri.Chat.Application.DTO.Aggregates.ChatAgg.Requests.ChatAggSettingsDTO request) {
			var loggedUserId = User.GetLoggedInUserId<int>();
			var result = await _chatAggSettingsAppService.Create(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<object>> Delete([FromQuery] ChatAggSettingsQueryModel request) {
            var result = await _chatAggSettingsAppService.Delete(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO<object>> DeleteRange(ChatAggSettingsQueryModel request) {
            var result = await _chatAggSettingsAppService.DeleteRange(request);
            return result.Success? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class ConversationMessageController : BaseMiniController {
		IConversationMessageAppService _conversationMessageAppService;
		public ConversationMessageController(
			IServiceProvider scope,
            ILogRequestContext logRequestContext,
			IConversationMessageAppService conversationMessageAppService)
				: base(logRequestContext, scope)
			{ 
				_conversationMessageAppService = conversationMessageAppService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] ConversationMessageQueryModel request) {
		    var obj = await _conversationMessageAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] ConversationMessageQueryModel request) {
            return GetHttpResponseDTO.Ok(await _conversationMessageAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] ConversationMessageQueryModel request, int page = 0, int size = 5) {
		    var obj = await _conversationMessageAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] ConversationMessageQueryModel request, int page = 0, int size = 5) {
		    var obj = await _conversationMessageAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] ConversationMessageQueryModel request, int? page = null, int? size = null) {
		    var obj = await _conversationMessageAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<ConversationMessage>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<GetHttpResponseDTO<object>> Post(Niu.Nutri.Chat.Application.DTO.Aggregates.ChatAgg.Requests.ConversationMessageDTO request) {
			var loggedUserId = User.GetLoggedInUserId<int>();
			var result = await _conversationMessageAppService.Create(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<object>> Delete([FromQuery] ConversationMessageQueryModel request) {
            var result = await _conversationMessageAppService.Delete(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO<object>> DeleteRange(ConversationMessageQueryModel request) {
            var result = await _conversationMessageAppService.DeleteRange(request);
            return result.Success? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
	}
}
