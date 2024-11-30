
using Microsoft.AspNetCore.Mvc;
using Niu.Nutri.CrossCutting.Infra.Log.Contexts;
using Niu.Nutri.Core.Application.Aggregates.Common;
using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;
using Niu.Nutri.Core.Application.Extensions;
using Niu.Nutri.Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;
namespace Niu.Nutri.Addresses.Api.Controllers {
	using Domain.Aggregates.AddressesAgg.Queries.Models;
	using Application.Aggregates.AddressesAgg.AppServices;
	using Domain.Aggregates.AddressesAgg.Entities;
	[ApiController]
    [Route("api/[controller]")]
	public partial class AddressController : BaseMiniController {
		IAddressAppService _addressAppService;
		public AddressController(
			IServiceProvider scope,
            ILogRequestContext logRequestContext,
			IAddressAppService addressAppService)
				: base(logRequestContext, scope)
			{ 
				_addressAppService = addressAppService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] AddressQueryModel request) {
		    var obj = await _addressAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] AddressQueryModel request) {
            return GetHttpResponseDTO.Ok(await _addressAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] AddressQueryModel request, int page = 0, int size = 5) {
		    var obj = await _addressAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] AddressQueryModel request, int page = 0, int size = 5) {
		    var obj = await _addressAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] AddressQueryModel request, int? page = null, int? size = null) {
		    var obj = await _addressAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<Address>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<GetHttpResponseDTO<object>> Post(Niu.Nutri.Addresses.Application.DTO.Aggregates.AddressesAgg.Requests.AddressDTO request) {
			var loggedUserId = User.GetLoggedInUserId<int>();
			var result = await _addressAppService.Create(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<object>> Delete([FromQuery] AddressQueryModel request) {
            var result = await _addressAppService.Delete(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO<object>> DeleteRange(AddressQueryModel request) {
            var result = await _addressAppService.DeleteRange(request);
            return result.Success? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class AddressesAggSettingsController : BaseMiniController {
		IAddressesAggSettingsAppService _addressesAggSettingsAppService;
		public AddressesAggSettingsController(
			IServiceProvider scope,
            ILogRequestContext logRequestContext,
			IAddressesAggSettingsAppService addressesAggSettingsAppService)
				: base(logRequestContext, scope)
			{ 
				_addressesAggSettingsAppService = addressesAggSettingsAppService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] AddressesAggSettingsQueryModel request) {
		    var obj = await _addressesAggSettingsAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] AddressesAggSettingsQueryModel request) {
            return GetHttpResponseDTO.Ok(await _addressesAggSettingsAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] AddressesAggSettingsQueryModel request, int page = 0, int size = 5) {
		    var obj = await _addressesAggSettingsAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("summary")]
		public async Task<GetHttpResponseDTO<object>> GetSummary([FromQuery] AddressesAggSettingsQueryModel request, int page = 0, int size = 5) {
		    var obj = await _addressesAggSettingsAppService.GetAllSummary(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] AddressesAggSettingsQueryModel request, int? page = null, int? size = null) {
		    var obj = await _addressesAggSettingsAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<AddressesAggSettings>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<GetHttpResponseDTO<object>> Post(Niu.Nutri.Addresses.Application.DTO.Aggregates.AddressesAgg.Requests.AddressesAggSettingsDTO request) {
			var loggedUserId = User.GetLoggedInUserId<int>();
			var result = await _addressesAggSettingsAppService.Create(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<object>> Delete([FromQuery] AddressesAggSettingsQueryModel request) {
            var result = await _addressesAggSettingsAppService.Delete(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO<object>> DeleteRange(AddressesAggSettingsQueryModel request) {
            var result = await _addressesAggSettingsAppService.DeleteRange(request);
            return result.Success? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
	}
}
