
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
	public partial class LivroController : BaseMiniController {
		ILivroAppService _livroAppService;
		public LivroController(
			IServiceProvider scope,
			ILivroAppService livroAppService)
				: base(scope)
			{ 
				_livroAppService = livroAppService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] LivroQueryModel request) {
		    var obj = await _livroAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] LivroQueryModel request) {
            return GetHttpResponseDTO.Ok(await _livroAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] LivroQueryModel request, int page = 0, int size = 5) {
		    var obj = await _livroAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] LivroQueryModel request, int? page = null, int? size = null) {
		    var obj = await _livroAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<Book>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<GetHttpResponseDTO<object>> Post(Application.DTO.Aggregates.LivrariaAgg.Requests.LivroDTO request) {
			var loggedUserId = User.GetLoggedInUserId<int>();
			var result = await _livroAppService.Create(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<object>> Delete([FromQuery] LivroQueryModel request) {
            var result = await _livroAppService.Delete(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO<object>> DeleteRange(LivroQueryModel request) {
            var result = await _livroAppService.DeleteRange(request);
            return result.Success? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
	}
