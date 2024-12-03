using Microsoft.AspNetCore.Mvc;

namespace Niu.Nutri.Livraria.Api.Controllers;

using Core.Application.Aggregates.Common;
using Core.Application.Extensions;
using CrossCuting.Infra.Utils.Extensions;
using Core.Application.DTO.Http.Models.Responses;
using Domain.Aggregates.LivrariaAgg.Queries.Models;
using Application.Aggregates.LivrariaAgg.AppServices;
using Domain.Aggregates.LivrariaAgg.Entities;

	[ApiController]
    [Route("api/[controller]")]
	public partial class AssuntoController : BaseMiniController {
		IAssuntoAppService _assuntoAppService;
		public AssuntoController(
			IServiceProvider scope,
			IAssuntoAppService assuntoAppService)
				: base(scope)
			{ 
				_assuntoAppService = assuntoAppService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] AssuntoQueryModel request) {
		    var obj = await _assuntoAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] AssuntoQueryModel request) {
            return GetHttpResponseDTO.Ok(await _assuntoAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] AssuntoQueryModel request, int page = 0, int size = 5) {
		    var obj = await _assuntoAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] AssuntoQueryModel request, int? page = null, int? size = null) {
		    var obj = await _assuntoAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<Assunto>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<GetHttpResponseDTO<object>> Post(Application.DTO.Aggregates.LivrariaAgg.Requests.AssuntoDTO request) {
			var loggedUserId = User.GetLoggedInUserId<int>();
			var result = await _assuntoAppService.Create(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<object>> Delete([FromQuery] AssuntoQueryModel request) {
            var result = await _assuntoAppService.Delete(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO<object>> DeleteRange(AssuntoQueryModel request) {
            var result = await _assuntoAppService.DeleteRange(request);
            return result.Success? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
	}
