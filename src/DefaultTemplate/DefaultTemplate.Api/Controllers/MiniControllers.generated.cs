
using Microsoft.AspNetCore.Mvc;
using Niu.Nutri.CrossCutting.Infra.Log.Contexts;
using Niu.Nutri.Core.Application.Aggregates.Common;
using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;
using Niu.Nutri.Core.Application.Extensions;
using Niu.Nutri.Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;
namespace Niu.Nutri.DefaultTemplate.Api.Controllers {
	using Domain.Aggregates.DefaultTemplateAgg.Queries.Models;
	using Application.Aggregates.DefaultTemplateAgg.AppServices;
	using Domain.Aggregates.DefaultTemplateAgg.Entities;
	[ApiController]
    [Route("api/[controller]")]
	public partial class DefaultEntityController : BaseMiniController {
		IDefaultEntityAppService _defaultEntityAppService;
		public DefaultEntityController(
			IServiceProvider scope,
            ILogRequestContext logRequestContext,
			IDefaultEntityAppService defaultEntityAppService)
				: base(logRequestContext, scope)
			{ 
				_defaultEntityAppService = defaultEntityAppService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] DefaultEntityQueryModel request) {
		    var obj = await _defaultEntityAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] DefaultEntityQueryModel request) {
            return GetHttpResponseDTO.Ok(await _defaultEntityAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] DefaultEntityQueryModel request, int page = 0, int size = 5) {
		    var obj = await _defaultEntityAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] DefaultEntityQueryModel request, int page = 0, int size = 5) {
		    var obj = await _defaultEntityAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] DefaultEntityQueryModel request, int? page = null, int? size = null) {
		    var obj = await _defaultEntityAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<DefaultEntity>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<GetHttpResponseDTO<object>> Post(Niu.Nutri.DefaultTemplate.Application.DTO.Aggregates.DefaultTemplateAgg.Requests.DefaultEntityDTO request) {
			var loggedUserId = User.GetLoggedInUserId<int>();
			var result = await _defaultEntityAppService.Create(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<object>> Delete([FromQuery] DefaultEntityQueryModel request) {
            var result = await _defaultEntityAppService.Delete(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO<object>> DeleteRange(DefaultEntityQueryModel request) {
            var result = await _defaultEntityAppService.DeleteRange(request);
            return result.Success? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class DefaultTemplateAggSettingsController : BaseMiniController {
		IDefaultTemplateAggSettingsAppService _defaultTemplateAggSettingsAppService;
		public DefaultTemplateAggSettingsController(
			IServiceProvider scope,
            ILogRequestContext logRequestContext,
			IDefaultTemplateAggSettingsAppService defaultTemplateAggSettingsAppService)
				: base(logRequestContext, scope)
			{ 
				_defaultTemplateAggSettingsAppService = defaultTemplateAggSettingsAppService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] DefaultTemplateAggSettingsQueryModel request) {
		    var obj = await _defaultTemplateAggSettingsAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] DefaultTemplateAggSettingsQueryModel request) {
            return GetHttpResponseDTO.Ok(await _defaultTemplateAggSettingsAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] DefaultTemplateAggSettingsQueryModel request, int page = 0, int size = 5) {
		    var obj = await _defaultTemplateAggSettingsAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] DefaultTemplateAggSettingsQueryModel request, int page = 0, int size = 5) {
		    var obj = await _defaultTemplateAggSettingsAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] DefaultTemplateAggSettingsQueryModel request, int? page = null, int? size = null) {
		    var obj = await _defaultTemplateAggSettingsAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<DefaultTemplateAggSettings>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<GetHttpResponseDTO<object>> Post(Niu.Nutri.DefaultTemplate.Application.DTO.Aggregates.DefaultTemplateAgg.Requests.DefaultTemplateAggSettingsDTO request) {
			var loggedUserId = User.GetLoggedInUserId<int>();
			var result = await _defaultTemplateAggSettingsAppService.Create(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<object>> Delete([FromQuery] DefaultTemplateAggSettingsQueryModel request) {
            var result = await _defaultTemplateAggSettingsAppService.Delete(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO<object>> DeleteRange(DefaultTemplateAggSettingsQueryModel request) {
            var result = await _defaultTemplateAggSettingsAppService.DeleteRange(request);
            return result.Success? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
	}
}
