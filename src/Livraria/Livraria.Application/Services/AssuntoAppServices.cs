using MediatR;
using System.Linq.Expressions;

namespace Niu.Nutri.Livraria.Application.Aggregates.LivrariaAgg.AppServices;
	using Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;
	using CrossCuting.Infra.Utils.Extensions;
	using Application.DTO.Aggregates.LivrariaAgg.Requests;
	using Domain.Aggregates.LivrariaAgg.Queries.Models;
	using Domain.Aggregates.LivrariaAgg.Repositories;
	using Domain.Aggregates.LivrariaAgg.Filters;
	using Domain.Aggregates.LivrariaAgg.Entities;
	using Domain.Aggregates.LivrariaAgg.CommandModels;
	using Core.Application.DTO.Extensions;
	using Core.Application.Aggregates.Common;

	public partial class AssuntoAppService : BaseAppService, IAssuntoAppService {	
		public IAssuntoRepository _assuntoRepository;
		public AssuntoAppService(IMediator mediator, Niu.Nutri.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IAssuntoRepository assuntoRepository) : base(ctx, mediator) { _assuntoRepository = assuntoRepository; }	
		public async Task<AssuntoDTO> Get(AssuntoQueryModel request) {
            return (await _assuntoRepository.FindAsync(filter: AssuntoFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification), selector: x => x.ProjectedAs<AssuntoDTO>()));
        }
		public void Dispose()
        {
			_assuntoRepository = null;
        }
		public async Task<IEnumerable<T>> GetAll<T>(AssuntoQueryModel request, int? page = null, int? size = null, Expression<Func<Assunto, T>> selector = null) {
			return await _assuntoRepository.SelectAllAsync(
                filter: AssuntoFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Assunto>(),
                selector: selector);
		}
		public async Task<T> Select<T>(AssuntoQueryModel request, Expression<Func<Assunto, T>> selector = null)
        {
            return (await _assuntoRepository.FindAsync(filter: AssuntoFilters.GetFilters(request, isOrSpecification: true), selector: selector));
        }
        public async Task<IEnumerable<AssuntoDTO>> GetAll(AssuntoQueryModel request, int? page = null, int? size = null) {
            return await _assuntoRepository.FindAllAsync(
                filter: AssuntoFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Assunto>(),
                selector: x => x.ProjectedAs<AssuntoDTO>());
        }

		public Task<DomainResponse> Create(AssuntoDTO request, bool updateIfExists = true, AssuntoQueryModel searchQuery = null) { return _mediator.Send(new CreateAssuntoCommand(_logRequestContext, request)); }
		public async Task<int> CountAsync(AssuntoQueryModel request) { return await _assuntoRepository.CountAsync(filter: AssuntoFilters.GetFilters(request, isOrSpecification: true)); }
		public Task Update(AssuntoQueryModel searchQuery, AssuntoDTO request, bool createIfNotExists = true) { return _mediator.Send(new UpdateAssuntoCommand(_logRequestContext, searchQuery, request)); }
		public Task<DomainResponse> DeleteRange(AssuntoQueryModel request){ return _mediator.Send(new DeleteRangeAssuntoCommand(_logRequestContext, request)); }
		public Task<DomainResponse> Delete(AssuntoQueryModel request){ return _mediator.Send(new DeleteAssuntoCommand(_logRequestContext, request)); }
	}
