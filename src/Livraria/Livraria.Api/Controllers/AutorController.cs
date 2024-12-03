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
	public partial class AutorController : BaseMiniController {
		IAutorAppService _autorAppService;
		public AutorController(
			IServiceProvider scope,
			IAutorAppService autorAppService)
				: base(scope)
			{ 
				_autorAppService = autorAppService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] AutorQueryModel request) {
		    var obj = await _autorAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] AutorQueryModel request) {
            return GetHttpResponseDTO.Ok(await _autorAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] AutorQueryModel request, int page = 0, int size = 5) {
		    var obj = await _autorAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] AutorQueryModel request, int? page = null, int? size = null) {
		    var obj = await _autorAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<Autor>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<GetHttpResponseDTO<object>> Post(Application.DTO.Aggregates.LivrariaAgg.Requests.AutorDTO request) {
			var loggedUserId = User.GetLoggedInUserId<int>();
			var result = await _autorAppService.Create(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<object>> Delete([FromQuery] AutorQueryModel request) {
            var result = await _autorAppService.Delete(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO<object>> DeleteRange(AutorQueryModel request) {
            var result = await _autorAppService.DeleteRange(request);
            return result.Success? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
	}
