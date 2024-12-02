
using Microsoft.AspNetCore.Mvc;
using Niu.Nutri.CrossCutting.Infra.Log.Contexts;
using Niu.Nutri.Core.Application.Aggregates.Common;
using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;
using Niu.Nutri.Core.Application.Extensions;
using Niu.Nutri.Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;
namespace Niu.Nutri.Livraria.Api.Controllers {
	using Domain.Aggregates.LivrariaAgg.Queries.Models;
	using Application.Aggregates.LivrariaAgg.AppServices;
	using Domain.Aggregates.LivrariaAgg.Entities;
	[ApiController]
    [Route("api/[controller]")]
	public partial class Livro_AutorController : BaseMiniController {
		ILivro_AutorAppService _livro_AutorAppService;
		public Livro_AutorController(
			IServiceProvider scope,
            ILogRequestContext logRequestContext,
			ILivro_AutorAppService livro_AutorAppService)
				: base(logRequestContext, scope)
			{ 
				_livro_AutorAppService = livro_AutorAppService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] Livro_AutorQueryModel request) {
		    var obj = await _livro_AutorAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] Livro_AutorQueryModel request) {
            return GetHttpResponseDTO.Ok(await _livro_AutorAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] Livro_AutorQueryModel request, int page = 0, int size = 5) {
		    var obj = await _livro_AutorAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] Livro_AutorQueryModel request, int? page = null, int? size = null) {
		    var obj = await _livro_AutorAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<Livro_Autor>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<GetHttpResponseDTO<object>> Post(Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests.Livro_AutorDTO request) {
			var loggedUserId = User.GetLoggedInUserId<int>();
			var result = await _livro_AutorAppService.Create(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<object>> Delete([FromQuery] Livro_AutorQueryModel request) {
            var result = await _livro_AutorAppService.Delete(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO<object>> DeleteRange(Livro_AutorQueryModel request) {
            var result = await _livro_AutorAppService.DeleteRange(request);
            return result.Success? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class LivroController : BaseMiniController {
		ILivroAppService _livroAppService;
		public LivroController(
			IServiceProvider scope,
            ILogRequestContext logRequestContext,
			ILivroAppService livroAppService)
				: base(logRequestContext, scope)
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
		    var obj = await _livroAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<Livro>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<GetHttpResponseDTO<object>> Post(Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests.LivroDTO request) {
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
	[ApiController]
    [Route("api/[controller]")]
	public partial class AssuntoController : BaseMiniController {
		IAssuntoAppService _assuntoAppService;
		public AssuntoController(
			IServiceProvider scope,
            ILogRequestContext logRequestContext,
			IAssuntoAppService assuntoAppService)
				: base(logRequestContext, scope)
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
		public async Task<GetHttpResponseDTO<object>> Post(Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests.AssuntoDTO request) {
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
	[ApiController]
    [Route("api/[controller]")]
	public partial class Livro_AssuntoController : BaseMiniController {
		ILivro_AssuntoAppService _livro_AssuntoAppService;
		public Livro_AssuntoController(
			IServiceProvider scope,
            ILogRequestContext logRequestContext,
			ILivro_AssuntoAppService livro_AssuntoAppService)
				: base(logRequestContext, scope)
			{ 
				_livro_AssuntoAppService = livro_AssuntoAppService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] Livro_AssuntoQueryModel request) {
		    var obj = await _livro_AssuntoAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] Livro_AssuntoQueryModel request) {
            return GetHttpResponseDTO.Ok(await _livro_AssuntoAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] Livro_AssuntoQueryModel request, int page = 0, int size = 5) {
		    var obj = await _livro_AssuntoAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] Livro_AssuntoQueryModel request, int? page = null, int? size = null) {
		    var obj = await _livro_AssuntoAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<Livro_Assunto>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<GetHttpResponseDTO<object>> Post(Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests.Livro_AssuntoDTO request) {
			var loggedUserId = User.GetLoggedInUserId<int>();
			var result = await _livro_AssuntoAppService.Create(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<object>> Delete([FromQuery] Livro_AssuntoQueryModel request) {
            var result = await _livro_AssuntoAppService.Delete(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO<object>> DeleteRange(Livro_AssuntoQueryModel request) {
            var result = await _livro_AssuntoAppService.DeleteRange(request);
            return result.Success? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
	}
	[ApiController]
    [Route("api/[controller]")]
	public partial class AutorController : BaseMiniController {
		IAutorAppService _autorAppService;
		public AutorController(
			IServiceProvider scope,
            ILogRequestContext logRequestContext,
			IAutorAppService autorAppService)
				: base(logRequestContext, scope)
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
		public async Task<GetHttpResponseDTO<object>> Post(Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests.AutorDTO request) {
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
	[ApiController]
    [Route("api/[controller]")]
	public partial class LivrariaAggSettingsController : BaseMiniController {
		ILivrariaAggSettingsAppService _livrariaAggSettingsAppService;
		public LivrariaAggSettingsController(
			IServiceProvider scope,
            ILogRequestContext logRequestContext,
			ILivrariaAggSettingsAppService livrariaAggSettingsAppService)
				: base(logRequestContext, scope)
			{ 
				_livrariaAggSettingsAppService = livrariaAggSettingsAppService; 
			}	
		[HttpGet]
		public async Task<IActionResult> Get([FromQuery] LivrariaAggSettingsQueryModel request) {
		    var obj = await _livrariaAggSettingsAppService.Get(request);
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		[HttpGet("count")]
		public async Task<GetHttpResponseDTO<object>> Count([FromQuery] LivrariaAggSettingsQueryModel request) {
            return GetHttpResponseDTO.Ok(await _livrariaAggSettingsAppService.CountAsync(request));
        }
		[HttpGet("search")]
		public async Task<GetHttpResponseDTO<object>> Get([FromQuery] LivrariaAggSettingsQueryModel request, int page = 0, int size = 5) {
		    var obj = await _livrariaAggSettingsAppService.GetAll(request, page, size);
            return GetHttpResponseDTO.Ok(obj);
        }
		[HttpGet("select")]
		public async Task<IActionResult> Select([FromQuery] LivrariaAggSettingsQueryModel request, int? page = null, int? size = null) {
		    var obj = await _livrariaAggSettingsAppService.GetAll(request, page, size, request.Selector.GetPropertySelector<LivrariaAggSettings>());
            return obj == null? NotFound() : Ok(GetHttpResponseDTO.Ok(obj));
        }
		
		[HttpPost]
		public async Task<GetHttpResponseDTO<object>> Post(Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests.LivrariaAggSettingsDTO request) {
			var loggedUserId = User.GetLoggedInUserId<int>();
			var result = await _livrariaAggSettingsAppService.Create(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
		}
        [HttpDelete("delete")]
		public async Task<GetHttpResponseDTO<object>> Delete([FromQuery] LivrariaAggSettingsQueryModel request) {
            var result = await _livrariaAggSettingsAppService.Delete(request);
            return result.Success ? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
        [HttpDelete("range")]
        public async Task<GetHttpResponseDTO<object>> DeleteRange(LivrariaAggSettingsQueryModel request) {
            var result = await _livrariaAggSettingsAppService.DeleteRange(request);
            return result.Success? GetHttpResponseDTO.Ok(result) : GetHttpResponseDTO.BadRequest(result);
        }
	}
}
