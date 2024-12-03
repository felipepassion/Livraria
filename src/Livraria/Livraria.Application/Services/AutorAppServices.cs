using MediatR;
using System.Linq.Expressions;

namespace Niu.Nutri.Livraria.Application.Aggregates.LivrariaAgg.AppServices;
	using Core.Application.DTO.Http.Models.Responses;
	using CrossCuting.Infra.Utils.Extensions;
	using Application.DTO.Aggregates.LivrariaAgg.Requests;
	using Domain.Aggregates.LivrariaAgg.Queries.Models;
	using Domain.Aggregates.LivrariaAgg.Repositories;
	using Domain.Aggregates.LivrariaAgg.Filters;
	using Domain.Aggregates.LivrariaAgg.Entities;
	using Domain.Aggregates.LivrariaAgg.Commands;
	using Core.Application.DTO.Extensions;
	using Core.Application.Aggregates.Common;

	public partial class AutorAppService : BaseAppService, IAutorAppService {	
		public IAutorRepository _autorRepository;
		public AutorAppService(IMediator mediator, Niu.Nutri.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IAutorRepository autorRepository) : base(ctx, mediator) { _autorRepository = autorRepository; }	
		public async Task<AutorDTO> Get(AutorQueryModel request) {
            return (await _autorRepository.FindAsync(filter: AutorFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification), selector: x => x.ProjectedAs<AutorDTO>()));
        }
		public void Dispose()
        {
			_autorRepository = null;
        }
		public async Task<IEnumerable<T>> GetAll<T>(AutorQueryModel request, int? page = null, int? size = null, Expression<Func<Autor, T>> selector = null) {
			return await _autorRepository.SelectAllAsync(
                filter: AutorFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Autor>(),
                selector: selector);
		}
		public async Task<T> Select<T>(AutorQueryModel request, Expression<Func<Autor, T>> selector = null)
        {
            return (await _autorRepository.FindAsync(filter: AutorFilters.GetFilters(request, isOrSpecification: true), selector: selector));
        }
        public async Task<IEnumerable<AutorDTO>> GetAll(AutorQueryModel request, int? page = null, int? size = null) {
            return await _autorRepository.FindAllAsync(
                filter: AutorFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Autor>(),
                selector: x => x.ProjectedAs<AutorDTO>());
        }

		public Task<DomainResponse> Create(AutorDTO request, bool updateIfExists = true, AutorQueryModel searchQuery = null) { return _mediator.Send(new CreateAutorCommand(_logRequestContext, request)); }
		public async Task<int> CountAsync(AutorQueryModel request) { return await _autorRepository.CountAsync(filter: AutorFilters.GetFilters(request, isOrSpecification: true)); }
		public Task Update(AutorQueryModel searchQuery, AutorDTO request, bool createIfNotExists = true) { return _mediator.Send(new UpdateAutorCommand(_logRequestContext, searchQuery, request)); }
		public Task<DomainResponse> DeleteRange(AutorQueryModel request){ return _mediator.Send(new DeleteRangeAutorCommand(_logRequestContext, request)); }
		public Task<DomainResponse> Delete(AutorQueryModel request){ return _mediator.Send(new DeleteAutorCommand(_logRequestContext, request)); }
	}
