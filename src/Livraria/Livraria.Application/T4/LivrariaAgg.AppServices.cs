﻿
using MediatR;
using System.Linq.Expressions;
using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;
using Niu.Nutri.Core.Application.DTO.Extensions;
using Niu.Nutri.Core.Application.Aggregates.Common;
using Niu.Nutri.Core.Domain.CrossCutting;

namespace Niu.Nutri.Livraria.Application.Aggregates.LivrariaAgg.AppServices {
	using Application.DTO.Aggregates.LivrariaAgg.Requests;
	using Domain.Aggregates.LivrariaAgg.Queries.Models;
	using Domain.Aggregates.LivrariaAgg.Repositories;
	using Domain.Aggregates.LivrariaAgg.Filters;
	using Domain.Aggregates.LivrariaAgg.Entities;
	using Domain.Aggregates.LivrariaAgg.CommandModels;
	public partial class LivrariaAggSettingsAppService : BaseAppService, ILivrariaAggSettingsAppService {	
		public ILivrariaAggSettingsRepository _livrariaAggSettingsRepository;
		public LivrariaAggSettingsAppService(IMediator mediator, Niu.Nutri.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, ILivrariaAggSettingsRepository livrariaAggSettingsRepository) : base(ctx, mediator) { _livrariaAggSettingsRepository = livrariaAggSettingsRepository; }	
		public async Task<LivrariaAggSettingsDTO> Get(LivrariaAggSettingsQueryModel request) {
            return (await _livrariaAggSettingsRepository.FindAsync(filter: LivrariaAggSettingsFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification), selector: x => x.ProjectedAs<LivrariaAggSettingsDTO>()));
        }
		public void Dispose()
        {
			_livrariaAggSettingsRepository = null;
        }
		public async Task<IEnumerable<T>> GetAll<T>(LivrariaAggSettingsQueryModel request, int? page = null, int? size = null, Expression<Func<LivrariaAggSettings, T>> selector = null) {
			return await _livrariaAggSettingsRepository.SelectAllAsync(
                filter: LivrariaAggSettingsFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<LivrariaAggSettings>(),
                selector: selector);
		}
		public async Task<T> Select<T>(LivrariaAggSettingsQueryModel request, Expression<Func<LivrariaAggSettings, T>> selector = null)
        {
            return (await _livrariaAggSettingsRepository.FindAsync(filter: LivrariaAggSettingsFilters.GetFilters(request, isOrSpecification: true), selector: selector));
        }
        public async Task<IEnumerable<LivrariaAggSettingsDTO>> GetAll(LivrariaAggSettingsQueryModel request, int? page = null, int? size = null) {
            return await _livrariaAggSettingsRepository.FindAllAsync(
                filter: LivrariaAggSettingsFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<LivrariaAggSettings>(),
                selector: x => x.ProjectedAs<LivrariaAggSettingsDTO>());
        }
		public async Task<IEnumerable<LivrariaAggSettingsListiningDTO>> GetAllSummary(LivrariaAggSettingsQueryModel request, int? page = null, int? size = null)
        {
            return await _livrariaAggSettingsRepository.FindAllAsync(
                filter: LivrariaAggSettingsFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<LivrariaAggSettings>(),
                selector: x => x.ProjectedAs<LivrariaAggSettingsListiningDTO>());
        }

		public Task<DomainResponse> Create(LivrariaAggSettingsDTO request, bool updateIfExists = true, LivrariaAggSettingsQueryModel searchQuery = null) { return _mediator.Send(new CreateLivrariaAggSettingsCommand(_logRequestContext, request)); }
		public async Task<int> CountAsync(LivrariaAggSettingsQueryModel request) { return await _livrariaAggSettingsRepository.CountAsync(filter: LivrariaAggSettingsFilters.GetFilters(request, isOrSpecification: true)); }
		public Task Update(LivrariaAggSettingsQueryModel searchQuery, LivrariaAggSettingsDTO request, bool createIfNotExists = true) { return _mediator.Send(new UpdateLivrariaAggSettingsCommand(_logRequestContext, searchQuery, request)); }
		public Task<DomainResponse> DeleteRange(LivrariaAggSettingsQueryModel request){ return _mediator.Send(new DeleteRangeLivrariaAggSettingsCommand(_logRequestContext, request)); }
		public Task<DomainResponse> Delete(LivrariaAggSettingsQueryModel request){ return _mediator.Send(new DeleteLivrariaAggSettingsCommand(_logRequestContext, request)); }
	}
	public partial class Livro_AutorAppService : BaseAppService, ILivro_AutorAppService {	
		public ILivro_AutorRepository _livro_AutorRepository;
		public Livro_AutorAppService(IMediator mediator, Niu.Nutri.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, ILivro_AutorRepository livro_AutorRepository) : base(ctx, mediator) { _livro_AutorRepository = livro_AutorRepository; }	
		public async Task<Livro_AutorDTO> Get(Livro_AutorQueryModel request) {
            return (await _livro_AutorRepository.FindAsync(filter: Livro_AutorFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification), selector: x => x.ProjectedAs<Livro_AutorDTO>()));
        }
		public void Dispose()
        {
			_livro_AutorRepository = null;
        }
		public async Task<IEnumerable<T>> GetAll<T>(Livro_AutorQueryModel request, int? page = null, int? size = null, Expression<Func<Livro_Autor, T>> selector = null) {
			return await _livro_AutorRepository.SelectAllAsync(
                filter: Livro_AutorFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Livro_Autor>(),
                selector: selector);
		}
		public async Task<T> Select<T>(Livro_AutorQueryModel request, Expression<Func<Livro_Autor, T>> selector = null)
        {
            return (await _livro_AutorRepository.FindAsync(filter: Livro_AutorFilters.GetFilters(request, isOrSpecification: true), selector: selector));
        }
        public async Task<IEnumerable<Livro_AutorDTO>> GetAll(Livro_AutorQueryModel request, int? page = null, int? size = null) {
            return await _livro_AutorRepository.FindAllAsync(
                filter: Livro_AutorFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Livro_Autor>(),
                selector: x => x.ProjectedAs<Livro_AutorDTO>());
        }
		public async Task<IEnumerable<Livro_AutorListiningDTO>> GetAllSummary(Livro_AutorQueryModel request, int? page = null, int? size = null)
        {
            return await _livro_AutorRepository.FindAllAsync(
                filter: Livro_AutorFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Livro_Autor>(),
                selector: x => x.ProjectedAs<Livro_AutorListiningDTO>());
        }

		public Task<DomainResponse> Create(Livro_AutorDTO request, bool updateIfExists = true, Livro_AutorQueryModel searchQuery = null) { return _mediator.Send(new CreateLivro_AutorCommand(_logRequestContext, request)); }
		public async Task<int> CountAsync(Livro_AutorQueryModel request) { return await _livro_AutorRepository.CountAsync(filter: Livro_AutorFilters.GetFilters(request, isOrSpecification: true)); }
		public Task Update(Livro_AutorQueryModel searchQuery, Livro_AutorDTO request, bool createIfNotExists = true) { return _mediator.Send(new UpdateLivro_AutorCommand(_logRequestContext, searchQuery, request)); }
		public Task<DomainResponse> DeleteRange(Livro_AutorQueryModel request){ return _mediator.Send(new DeleteRangeLivro_AutorCommand(_logRequestContext, request)); }
		public Task<DomainResponse> Delete(Livro_AutorQueryModel request){ return _mediator.Send(new DeleteLivro_AutorCommand(_logRequestContext, request)); }
	}
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
		public async Task<IEnumerable<AutorListiningDTO>> GetAllSummary(AutorQueryModel request, int? page = null, int? size = null)
        {
            return await _autorRepository.FindAllAsync(
                filter: AutorFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Autor>(),
                selector: x => x.ProjectedAs<AutorListiningDTO>());
        }

		public Task<DomainResponse> Create(AutorDTO request, bool updateIfExists = true, AutorQueryModel searchQuery = null) { return _mediator.Send(new CreateAutorCommand(_logRequestContext, request)); }
		public async Task<int> CountAsync(AutorQueryModel request) { return await _autorRepository.CountAsync(filter: AutorFilters.GetFilters(request, isOrSpecification: true)); }
		public Task Update(AutorQueryModel searchQuery, AutorDTO request, bool createIfNotExists = true) { return _mediator.Send(new UpdateAutorCommand(_logRequestContext, searchQuery, request)); }
		public Task<DomainResponse> DeleteRange(AutorQueryModel request){ return _mediator.Send(new DeleteRangeAutorCommand(_logRequestContext, request)); }
		public Task<DomainResponse> Delete(AutorQueryModel request){ return _mediator.Send(new DeleteAutorCommand(_logRequestContext, request)); }
	}
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
		public async Task<IEnumerable<AssuntoListiningDTO>> GetAllSummary(AssuntoQueryModel request, int? page = null, int? size = null)
        {
            return await _assuntoRepository.FindAllAsync(
                filter: AssuntoFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Assunto>(),
                selector: x => x.ProjectedAs<AssuntoListiningDTO>());
        }

		public Task<DomainResponse> Create(AssuntoDTO request, bool updateIfExists = true, AssuntoQueryModel searchQuery = null) { return _mediator.Send(new CreateAssuntoCommand(_logRequestContext, request)); }
		public async Task<int> CountAsync(AssuntoQueryModel request) { return await _assuntoRepository.CountAsync(filter: AssuntoFilters.GetFilters(request, isOrSpecification: true)); }
		public Task Update(AssuntoQueryModel searchQuery, AssuntoDTO request, bool createIfNotExists = true) { return _mediator.Send(new UpdateAssuntoCommand(_logRequestContext, searchQuery, request)); }
		public Task<DomainResponse> DeleteRange(AssuntoQueryModel request){ return _mediator.Send(new DeleteRangeAssuntoCommand(_logRequestContext, request)); }
		public Task<DomainResponse> Delete(AssuntoQueryModel request){ return _mediator.Send(new DeleteAssuntoCommand(_logRequestContext, request)); }
	}
	public partial class Livro_AssuntoAppService : BaseAppService, ILivro_AssuntoAppService {	
		public ILivro_AssuntoRepository _livro_AssuntoRepository;
		public Livro_AssuntoAppService(IMediator mediator, Niu.Nutri.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, ILivro_AssuntoRepository livro_AssuntoRepository) : base(ctx, mediator) { _livro_AssuntoRepository = livro_AssuntoRepository; }	
		public async Task<Livro_AssuntoDTO> Get(Livro_AssuntoQueryModel request) {
            return (await _livro_AssuntoRepository.FindAsync(filter: Livro_AssuntoFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification), selector: x => x.ProjectedAs<Livro_AssuntoDTO>()));
        }
		public void Dispose()
        {
			_livro_AssuntoRepository = null;
        }
		public async Task<IEnumerable<T>> GetAll<T>(Livro_AssuntoQueryModel request, int? page = null, int? size = null, Expression<Func<Livro_Assunto, T>> selector = null) {
			return await _livro_AssuntoRepository.SelectAllAsync(
                filter: Livro_AssuntoFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Livro_Assunto>(),
                selector: selector);
		}
		public async Task<T> Select<T>(Livro_AssuntoQueryModel request, Expression<Func<Livro_Assunto, T>> selector = null)
        {
            return (await _livro_AssuntoRepository.FindAsync(filter: Livro_AssuntoFilters.GetFilters(request, isOrSpecification: true), selector: selector));
        }
        public async Task<IEnumerable<Livro_AssuntoDTO>> GetAll(Livro_AssuntoQueryModel request, int? page = null, int? size = null) {
            return await _livro_AssuntoRepository.FindAllAsync(
                filter: Livro_AssuntoFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Livro_Assunto>(),
                selector: x => x.ProjectedAs<Livro_AssuntoDTO>());
        }
		public async Task<IEnumerable<Livro_AssuntoListiningDTO>> GetAllSummary(Livro_AssuntoQueryModel request, int? page = null, int? size = null)
        {
            return await _livro_AssuntoRepository.FindAllAsync(
                filter: Livro_AssuntoFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Livro_Assunto>(),
                selector: x => x.ProjectedAs<Livro_AssuntoListiningDTO>());
        }

		public Task<DomainResponse> Create(Livro_AssuntoDTO request, bool updateIfExists = true, Livro_AssuntoQueryModel searchQuery = null) { return _mediator.Send(new CreateLivro_AssuntoCommand(_logRequestContext, request)); }
		public async Task<int> CountAsync(Livro_AssuntoQueryModel request) { return await _livro_AssuntoRepository.CountAsync(filter: Livro_AssuntoFilters.GetFilters(request, isOrSpecification: true)); }
		public Task Update(Livro_AssuntoQueryModel searchQuery, Livro_AssuntoDTO request, bool createIfNotExists = true) { return _mediator.Send(new UpdateLivro_AssuntoCommand(_logRequestContext, searchQuery, request)); }
		public Task<DomainResponse> DeleteRange(Livro_AssuntoQueryModel request){ return _mediator.Send(new DeleteRangeLivro_AssuntoCommand(_logRequestContext, request)); }
		public Task<DomainResponse> Delete(Livro_AssuntoQueryModel request){ return _mediator.Send(new DeleteLivro_AssuntoCommand(_logRequestContext, request)); }
	}
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
		public async Task<IEnumerable<LivroListiningDTO>> GetAllSummary(LivroQueryModel request, int? page = null, int? size = null)
        {
            return await _livroRepository.FindAllAsync(
                filter: LivroFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Livro>(),
                selector: x => x.ProjectedAs<LivroListiningDTO>());
        }

		public Task<DomainResponse> Create(LivroDTO request, bool updateIfExists = true, LivroQueryModel searchQuery = null) { return _mediator.Send(new CreateLivroCommand(_logRequestContext, request)); }
		public async Task<int> CountAsync(LivroQueryModel request) { return await _livroRepository.CountAsync(filter: LivroFilters.GetFilters(request, isOrSpecification: true)); }
		public Task Update(LivroQueryModel searchQuery, LivroDTO request, bool createIfNotExists = true) { return _mediator.Send(new UpdateLivroCommand(_logRequestContext, searchQuery, request)); }
		public Task<DomainResponse> DeleteRange(LivroQueryModel request){ return _mediator.Send(new DeleteRangeLivroCommand(_logRequestContext, request)); }
		public Task<DomainResponse> Delete(LivroQueryModel request){ return _mediator.Send(new DeleteLivroCommand(_logRequestContext, request)); }
	}
}
