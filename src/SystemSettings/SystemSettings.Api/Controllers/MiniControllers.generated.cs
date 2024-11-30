
using Microsoft.AspNetCore.Mvc;
using Niu.Nutri.CrossCutting.Infra.Log.Contexts;
using Niu.Nutri.Core.Application.Aggregates.Common;
using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;
using Niu.Nutri.Core.Application.Extensions;
using Niu.Nutri.Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;
namespace Niu.Nutri.SystemSettings.Api.Controllers {
	using Domain.Aggregates.SystemSettingsAgg.Queries.Models;
	using Application.Aggregates.SystemSettingsAgg.AppServices;
	using Domain.Aggregates.SystemSettingsAgg.Entities;
	[ApiController]
    [Route("api/[controller]")]
	public partial class SystemPanelSubItemController : BaseMiniController {
		ISystemPanelSubItemAppService _systemPanelSubItemAppService;
		public SystemPanelSubItemController(
			IServiceProvider scope,
            ILogRequestContext logRequestContext,
			ISystemPanelSubItemAppService systemPanelSubItemAppService)
				: base(logRequestContext, scope)
			{ 
				_systemPanelSubItemAppService = systemPanelSubItemAppService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] SystemPanelSubItemQueryModel request) {
		    var obj = await _systemPanelSubItemAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] SystemPanelSubItemQueryModel request) {
            return GetHttpResponseDTO.Ok(await _systemPanelSubItemAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] SystemPanelSubItemQueryModel request, int page = 0, int size = 5) {
		    var obj = await _systemPanelSubItemAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] SystemPanelSubItemQueryModel request, int page = 0, int size = 5) {
		    var obj = await _systemPanelSubItemAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] SystemPanelSubItemQueryModel request, int? page = null, int? size = null) {
		    var obj = await _systemPanelSubItemAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<SystemPanelSubItem>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<GetHttpResponseDTO<object>> Post(Niu.Nutri.SystemSettings.Application.DTO.Aggregates.SystemSettingsAgg.Requests.SystemPanelSubItemDTO request) {
			var loggedUserId = User.GetLoggedInUserId<int>();
			var result = await _systemPanelSubItemAppService.Create(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<object>> Delete([FromQuery] SystemPanelSubItemQueryModel request) {
            var result = await _systemPanelSubItemAppService.Delete(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO<object>> DeleteRange(SystemPanelSubItemQueryModel request) {
            var result = await _systemPanelSubItemAppService.DeleteRange(request);
            return result.Success? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class SystemPanelController : BaseMiniController {
		ISystemPanelAppService _systemPanelAppService;
		public SystemPanelController(
			IServiceProvider scope,
            ILogRequestContext logRequestContext,
			ISystemPanelAppService systemPanelAppService)
				: base(logRequestContext, scope)
			{ 
				_systemPanelAppService = systemPanelAppService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] SystemPanelQueryModel request) {
		    var obj = await _systemPanelAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] SystemPanelQueryModel request) {
            return GetHttpResponseDTO.Ok(await _systemPanelAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] SystemPanelQueryModel request, int page = 0, int size = 5) {
		    var obj = await _systemPanelAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] SystemPanelQueryModel request, int page = 0, int size = 5) {
		    var obj = await _systemPanelAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] SystemPanelQueryModel request, int? page = null, int? size = null) {
		    var obj = await _systemPanelAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<SystemPanel>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<GetHttpResponseDTO<object>> Post(Niu.Nutri.SystemSettings.Application.DTO.Aggregates.SystemSettingsAgg.Requests.SystemPanelDTO request) {
			var loggedUserId = User.GetLoggedInUserId<int>();
			var result = await _systemPanelAppService.Create(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<object>> Delete([FromQuery] SystemPanelQueryModel request) {
            var result = await _systemPanelAppService.Delete(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO<object>> DeleteRange(SystemPanelQueryModel request) {
            var result = await _systemPanelAppService.DeleteRange(request);
            return result.Success? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class SystemPanelGroupController : BaseMiniController {
		ISystemPanelGroupAppService _systemPanelGroupAppService;
		public SystemPanelGroupController(
			IServiceProvider scope,
            ILogRequestContext logRequestContext,
			ISystemPanelGroupAppService systemPanelGroupAppService)
				: base(logRequestContext, scope)
			{ 
				_systemPanelGroupAppService = systemPanelGroupAppService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] SystemPanelGroupQueryModel request) {
		    var obj = await _systemPanelGroupAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] SystemPanelGroupQueryModel request) {
            return GetHttpResponseDTO.Ok(await _systemPanelGroupAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] SystemPanelGroupQueryModel request, int page = 0, int size = 5) {
		    var obj = await _systemPanelGroupAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] SystemPanelGroupQueryModel request, int page = 0, int size = 5) {
		    var obj = await _systemPanelGroupAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] SystemPanelGroupQueryModel request, int? page = null, int? size = null) {
		    var obj = await _systemPanelGroupAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<SystemPanelGroup>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<GetHttpResponseDTO<object>> Post(Niu.Nutri.SystemSettings.Application.DTO.Aggregates.SystemSettingsAgg.Requests.SystemPanelGroupDTO request) {
			var loggedUserId = User.GetLoggedInUserId<int>();
			var result = await _systemPanelGroupAppService.Create(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<object>> Delete([FromQuery] SystemPanelGroupQueryModel request) {
            var result = await _systemPanelGroupAppService.Delete(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO<object>> DeleteRange(SystemPanelGroupQueryModel request) {
            var result = await _systemPanelGroupAppService.DeleteRange(request);
            return result.Success? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class CargaTabelaController : BaseMiniController {
		ICargaTabelaAppService _cargaTabelaAppService;
		public CargaTabelaController(
			IServiceProvider scope,
            ILogRequestContext logRequestContext,
			ICargaTabelaAppService cargaTabelaAppService)
				: base(logRequestContext, scope)
			{ 
				_cargaTabelaAppService = cargaTabelaAppService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] CargaTabelaQueryModel request) {
		    var obj = await _cargaTabelaAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] CargaTabelaQueryModel request) {
            return GetHttpResponseDTO.Ok(await _cargaTabelaAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] CargaTabelaQueryModel request, int page = 0, int size = 5) {
		    var obj = await _cargaTabelaAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] CargaTabelaQueryModel request, int page = 0, int size = 5) {
		    var obj = await _cargaTabelaAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] CargaTabelaQueryModel request, int? page = null, int? size = null) {
		    var obj = await _cargaTabelaAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<CargaTabela>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<GetHttpResponseDTO<object>> Post(Niu.Nutri.SystemSettings.Application.DTO.Aggregates.SystemSettingsAgg.Requests.CargaTabelaDTO request) {
			var loggedUserId = User.GetLoggedInUserId<int>();
			var result = await _cargaTabelaAppService.Create(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<object>> Delete([FromQuery] CargaTabelaQueryModel request) {
            var result = await _cargaTabelaAppService.Delete(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO<object>> DeleteRange(CargaTabelaQueryModel request) {
            var result = await _cargaTabelaAppService.DeleteRange(request);
            return result.Success? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class SystemSettingsAggSettingsController : BaseMiniController {
		ISystemSettingsAggSettingsAppService _systemSettingsAggSettingsAppService;
		public SystemSettingsAggSettingsController(
			IServiceProvider scope,
            ILogRequestContext logRequestContext,
			ISystemSettingsAggSettingsAppService systemSettingsAggSettingsAppService)
				: base(logRequestContext, scope)
			{ 
				_systemSettingsAggSettingsAppService = systemSettingsAggSettingsAppService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] SystemSettingsAggSettingsQueryModel request) {
		    var obj = await _systemSettingsAggSettingsAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] SystemSettingsAggSettingsQueryModel request) {
            return GetHttpResponseDTO.Ok(await _systemSettingsAggSettingsAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] SystemSettingsAggSettingsQueryModel request, int page = 0, int size = 5) {
		    var obj = await _systemSettingsAggSettingsAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] SystemSettingsAggSettingsQueryModel request, int page = 0, int size = 5) {
		    var obj = await _systemSettingsAggSettingsAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] SystemSettingsAggSettingsQueryModel request, int? page = null, int? size = null) {
		    var obj = await _systemSettingsAggSettingsAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<SystemSettingsAggSettings>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<GetHttpResponseDTO<object>> Post(Niu.Nutri.SystemSettings.Application.DTO.Aggregates.SystemSettingsAgg.Requests.SystemSettingsAggSettingsDTO request) {
			var loggedUserId = User.GetLoggedInUserId<int>();
			var result = await _systemSettingsAggSettingsAppService.Create(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<object>> Delete([FromQuery] SystemSettingsAggSettingsQueryModel request) {
            var result = await _systemSettingsAggSettingsAppService.Delete(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO<object>> DeleteRange(SystemSettingsAggSettingsQueryModel request) {
            var result = await _systemSettingsAggSettingsAppService.DeleteRange(request);
            return result.Success? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
	}
}
