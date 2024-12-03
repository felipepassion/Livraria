


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
	using Domain.Aggregates.LivrariaAgg.Commands;
	using Core.Application.DTO.Extensions;
	using Core.Application.Aggregates.Common;

	public partial class LivroAppService : BaseAppService, ILivroAppService {	
		public ILivroRepository _livroRepository;
		public LivroAppService(IMediator mediator, Niu.Nutri.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, ILivroRepository livroRepository) : base(ctx, mediator) { _livroRepository = livroRepository; }	
		public async Task<LivroDTO> Get(LivroQueryModel request) {
            return (await _livroRepository.FindAsync(filter: LivroFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification), selector: x => x.ProjectedAs<LivroDTO>()));
        }
		public void Dispose()
        {
			_livroRepository = null;
        }
		public async Task<IEnumerable<T>> GetAll<T>(LivroQueryModel request, int? page = null, int? size = null, Expression<Func<Livro, T>> selector = null) {
			return await _livroRepository.SelectAllAsync(
                filter: LivroFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Livro>(),
                selector: selector);
		}
		public async Task<T> Select<T>(LivroQueryModel request, Expression<Func<Livro, T>> selector = null)
        {
            return (await _livroRepository.FindAsync(filter: LivroFilters.GetFilters(request, isOrSpecification: true), selector: selector));
        }
        public async Task<IEnumerable<LivroDTO>> GetAll(LivroQueryModel request, int? page = null, int? size = null) {
            return await _livroRepository.FindAllAsync(
                filter: LivroFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Livro>(),
                selector: x => x.ProjectedAs<LivroDTO>());
        }

		public Task<DomainResponse> Create(LivroDTO request, bool updateIfExists = true, LivroQueryModel searchQuery = null) { return _mediator.Send(new CreateLivroCommand(_logRequestContext, request)); }
		public async Task<int> CountAsync(LivroQueryModel request) { return await _livroRepository.CountAsync(filter: LivroFilters.GetFilters(request, isOrSpecification: true)); }
		public Task Update(LivroQueryModel searchQuery, LivroDTO request, bool createIfNotExists = true) { return _mediator.Send(new UpdateLivroCommand(_logRequestContext, searchQuery, request)); }
		public Task<DomainResponse> DeleteRange(LivroQueryModel request){ return _mediator.Send(new DeleteRangeLivroCommand(_logRequestContext, request)); }
		public Task<DomainResponse> Delete(LivroQueryModel request){ return _mediator.Send(new DeleteLivroCommand(_logRequestContext, request)); }
	}
