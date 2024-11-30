
using MediatR;
using System.Linq.Expressions;
using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;
using Niu.Nutri.Core.Application.DTO.Extensions;
using Niu.Nutri.Core.Application.Aggregates.Common;
using Niu.Nutri.Core.Domain.CrossCutting;

namespace Niu.Nutri.SystemSettings.Application.Aggregates.SystemSettingsAgg.AppServices {
	using Application.DTO.Aggregates.SystemSettingsAgg.Requests;
	using Domain.Aggregates.SystemSettingsAgg.Queries.Models;
	using Domain.Aggregates.SystemSettingsAgg.Repositories;
	using Domain.Aggregates.SystemSettingsAgg.Filters;
	using Domain.Aggregates.SystemSettingsAgg.Entities;
	using Domain.Aggregates.SystemSettingsAgg.CommandModels;
	public partial class SystemPanelSubItemAppService : BaseAppService, ISystemPanelSubItemAppService {	
		public ISystemPanelSubItemRepository _systemPanelSubItemRepository;
		public SystemPanelSubItemAppService(IMediator mediator, Niu.Nutri.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, ISystemPanelSubItemRepository systemPanelSubItemRepository) : base(ctx, mediator) { _systemPanelSubItemRepository = systemPanelSubItemRepository; }	
		public async Task<SystemPanelSubItemDTO> Get(SystemPanelSubItemQueryModel request) {
            return (await _systemPanelSubItemRepository.FindAsync(filter: SystemPanelSubItemFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification), selector: x => x.ProjectedAs<SystemPanelSubItemDTO>()));
        }
		public void Dispose()
        {
			_systemPanelSubItemRepository = null;
        }
		public async Task<IEnumerable<T>> GetAll<T>(SystemPanelSubItemQueryModel request, int? page = null, int? size = null, Expression<Func<SystemPanelSubItem, T>> selector = null) {
			return await _systemPanelSubItemRepository.SelectAllAsync(
                filter: SystemPanelSubItemFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<SystemPanelSubItem>(),
                selector: selector);
		}
		public async Task<T> Select<T>(SystemPanelSubItemQueryModel request, Expression<Func<SystemPanelSubItem, T>> selector = null)
        {
            return (await _systemPanelSubItemRepository.FindAsync(filter: SystemPanelSubItemFilters.GetFilters(request, isOrSpecification: true), selector: selector));
        }
        public async Task<IEnumerable<SystemPanelSubItemDTO>> GetAll(SystemPanelSubItemQueryModel request, int? page = null, int? size = null) {
            return await _systemPanelSubItemRepository.FindAllAsync(
                filter: SystemPanelSubItemFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<SystemPanelSubItem>(),
                selector: x => x.ProjectedAs<SystemPanelSubItemDTO>());
        }
		public async Task<IEnumerable<SystemPanelSubItemListiningDTO>> GetAllSummary(SystemPanelSubItemQueryModel request, int? page = null, int? size = null)
        {
            return await _systemPanelSubItemRepository.FindAllAsync(
                filter: SystemPanelSubItemFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<SystemPanelSubItem>(),
                selector: x => x.ProjectedAs<SystemPanelSubItemListiningDTO>());
        }

		public Task<DomainResponse> Create(SystemPanelSubItemDTO request, bool updateIfExists = true, SystemPanelSubItemQueryModel searchQuery = null) { return _mediator.Send(new CreateSystemPanelSubItemCommand(_logRequestContext, request)); }
		public async Task<int> CountAsync(SystemPanelSubItemQueryModel request) { return await _systemPanelSubItemRepository.CountAsync(filter: SystemPanelSubItemFilters.GetFilters(request, isOrSpecification: true)); }
		public Task Update(SystemPanelSubItemQueryModel searchQuery, SystemPanelSubItemDTO request, bool createIfNotExists = true) { return _mediator.Send(new UpdateSystemPanelSubItemCommand(_logRequestContext, searchQuery, request)); }
		public Task<DomainResponse> DeleteRange(SystemPanelSubItemQueryModel request){ return _mediator.Send(new DeleteRangeSystemPanelSubItemCommand(_logRequestContext, request)); }
		public Task<DomainResponse> Delete(SystemPanelSubItemQueryModel request){ return _mediator.Send(new DeleteSystemPanelSubItemCommand(_logRequestContext, request)); }
	}
	public partial class SystemPanelAppService : BaseAppService, ISystemPanelAppService {	
		public ISystemPanelRepository _systemPanelRepository;
		public SystemPanelAppService(IMediator mediator, Niu.Nutri.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, ISystemPanelRepository systemPanelRepository) : base(ctx, mediator) { _systemPanelRepository = systemPanelRepository; }	
		public async Task<SystemPanelDTO> Get(SystemPanelQueryModel request) {
            return (await _systemPanelRepository.FindAsync(filter: SystemPanelFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification), selector: x => x.ProjectedAs<SystemPanelDTO>()));
        }
		public void Dispose()
        {
			_systemPanelRepository = null;
        }
		public async Task<IEnumerable<T>> GetAll<T>(SystemPanelQueryModel request, int? page = null, int? size = null, Expression<Func<SystemPanel, T>> selector = null) {
			return await _systemPanelRepository.SelectAllAsync(
                filter: SystemPanelFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<SystemPanel>(),
                selector: selector);
		}
		public async Task<T> Select<T>(SystemPanelQueryModel request, Expression<Func<SystemPanel, T>> selector = null)
        {
            return (await _systemPanelRepository.FindAsync(filter: SystemPanelFilters.GetFilters(request, isOrSpecification: true), selector: selector));
        }
        public async Task<IEnumerable<SystemPanelDTO>> GetAll(SystemPanelQueryModel request, int? page = null, int? size = null) {
            return await _systemPanelRepository.FindAllAsync(
                filter: SystemPanelFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<SystemPanel>(),
                selector: x => x.ProjectedAs<SystemPanelDTO>());
        }
		public async Task<IEnumerable<SystemPanelListiningDTO>> GetAllSummary(SystemPanelQueryModel request, int? page = null, int? size = null)
        {
            return await _systemPanelRepository.FindAllAsync(
                filter: SystemPanelFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<SystemPanel>(),
                selector: x => x.ProjectedAs<SystemPanelListiningDTO>());
        }

		public Task<DomainResponse> Create(SystemPanelDTO request, bool updateIfExists = true, SystemPanelQueryModel searchQuery = null) { return _mediator.Send(new CreateSystemPanelCommand(_logRequestContext, request)); }
		public async Task<int> CountAsync(SystemPanelQueryModel request) { return await _systemPanelRepository.CountAsync(filter: SystemPanelFilters.GetFilters(request, isOrSpecification: true)); }
		public Task Update(SystemPanelQueryModel searchQuery, SystemPanelDTO request, bool createIfNotExists = true) { return _mediator.Send(new UpdateSystemPanelCommand(_logRequestContext, searchQuery, request)); }
		public Task<DomainResponse> DeleteRange(SystemPanelQueryModel request){ return _mediator.Send(new DeleteRangeSystemPanelCommand(_logRequestContext, request)); }
		public Task<DomainResponse> Delete(SystemPanelQueryModel request){ return _mediator.Send(new DeleteSystemPanelCommand(_logRequestContext, request)); }
	}
	public partial class SystemPanelGroupAppService : BaseAppService, ISystemPanelGroupAppService {	
		public ISystemPanelGroupRepository _systemPanelGroupRepository;
		public SystemPanelGroupAppService(IMediator mediator, Niu.Nutri.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, ISystemPanelGroupRepository systemPanelGroupRepository) : base(ctx, mediator) { _systemPanelGroupRepository = systemPanelGroupRepository; }	
		public async Task<SystemPanelGroupDTO> Get(SystemPanelGroupQueryModel request) {
            return (await _systemPanelGroupRepository.FindAsync(filter: SystemPanelGroupFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification), selector: x => x.ProjectedAs<SystemPanelGroupDTO>()));
        }
		public void Dispose()
        {
			_systemPanelGroupRepository = null;
        }
		public async Task<IEnumerable<T>> GetAll<T>(SystemPanelGroupQueryModel request, int? page = null, int? size = null, Expression<Func<SystemPanelGroup, T>> selector = null) {
			return await _systemPanelGroupRepository.SelectAllAsync(
                filter: SystemPanelGroupFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<SystemPanelGroup>(),
                selector: selector);
		}
		public async Task<T> Select<T>(SystemPanelGroupQueryModel request, Expression<Func<SystemPanelGroup, T>> selector = null)
        {
            return (await _systemPanelGroupRepository.FindAsync(filter: SystemPanelGroupFilters.GetFilters(request, isOrSpecification: true), selector: selector));
        }
        public async Task<IEnumerable<SystemPanelGroupDTO>> GetAll(SystemPanelGroupQueryModel request, int? page = null, int? size = null) {
            return await _systemPanelGroupRepository.FindAllAsync(
                filter: SystemPanelGroupFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<SystemPanelGroup>(),
                selector: x => x.ProjectedAs<SystemPanelGroupDTO>());
        }
		public async Task<IEnumerable<SystemPanelGroupListiningDTO>> GetAllSummary(SystemPanelGroupQueryModel request, int? page = null, int? size = null)
        {
            return await _systemPanelGroupRepository.FindAllAsync(
                filter: SystemPanelGroupFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<SystemPanelGroup>(),
                selector: x => x.ProjectedAs<SystemPanelGroupListiningDTO>());
        }

		public Task<DomainResponse> Create(SystemPanelGroupDTO request, bool updateIfExists = true, SystemPanelGroupQueryModel searchQuery = null) { return _mediator.Send(new CreateSystemPanelGroupCommand(_logRequestContext, request)); }
		public async Task<int> CountAsync(SystemPanelGroupQueryModel request) { return await _systemPanelGroupRepository.CountAsync(filter: SystemPanelGroupFilters.GetFilters(request, isOrSpecification: true)); }
		public Task Update(SystemPanelGroupQueryModel searchQuery, SystemPanelGroupDTO request, bool createIfNotExists = true) { return _mediator.Send(new UpdateSystemPanelGroupCommand(_logRequestContext, searchQuery, request)); }
		public Task<DomainResponse> DeleteRange(SystemPanelGroupQueryModel request){ return _mediator.Send(new DeleteRangeSystemPanelGroupCommand(_logRequestContext, request)); }
		public Task<DomainResponse> Delete(SystemPanelGroupQueryModel request){ return _mediator.Send(new DeleteSystemPanelGroupCommand(_logRequestContext, request)); }
	}
	public partial class CargaTabelaAppService : BaseAppService, ICargaTabelaAppService {	
		public ICargaTabelaRepository _cargaTabelaRepository;
		public CargaTabelaAppService(IMediator mediator, Niu.Nutri.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, ICargaTabelaRepository cargaTabelaRepository) : base(ctx, mediator) { _cargaTabelaRepository = cargaTabelaRepository; }	
		public async Task<CargaTabelaDTO> Get(CargaTabelaQueryModel request) {
            return (await _cargaTabelaRepository.FindAsync(filter: CargaTabelaFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification), selector: x => x.ProjectedAs<CargaTabelaDTO>()));
        }
		public void Dispose()
        {
			_cargaTabelaRepository = null;
        }
		public async Task<IEnumerable<T>> GetAll<T>(CargaTabelaQueryModel request, int? page = null, int? size = null, Expression<Func<CargaTabela, T>> selector = null) {
			return await _cargaTabelaRepository.SelectAllAsync(
                filter: CargaTabelaFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<CargaTabela>(),
                selector: selector);
		}
		public async Task<T> Select<T>(CargaTabelaQueryModel request, Expression<Func<CargaTabela, T>> selector = null)
        {
            return (await _cargaTabelaRepository.FindAsync(filter: CargaTabelaFilters.GetFilters(request, isOrSpecification: true), selector: selector));
        }
        public async Task<IEnumerable<CargaTabelaDTO>> GetAll(CargaTabelaQueryModel request, int? page = null, int? size = null) {
            return await _cargaTabelaRepository.FindAllAsync(
                filter: CargaTabelaFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<CargaTabela>(),
                selector: x => x.ProjectedAs<CargaTabelaDTO>());
        }
		public async Task<IEnumerable<CargaTabelaListiningDTO>> GetAllSummary(CargaTabelaQueryModel request, int? page = null, int? size = null)
        {
            return await _cargaTabelaRepository.FindAllAsync(
                filter: CargaTabelaFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<CargaTabela>(),
                selector: x => x.ProjectedAs<CargaTabelaListiningDTO>());
        }

		public Task<DomainResponse> Create(CargaTabelaDTO request, bool updateIfExists = true, CargaTabelaQueryModel searchQuery = null) { return _mediator.Send(new CreateCargaTabelaCommand(_logRequestContext, request)); }
		public async Task<int> CountAsync(CargaTabelaQueryModel request) { return await _cargaTabelaRepository.CountAsync(filter: CargaTabelaFilters.GetFilters(request, isOrSpecification: true)); }
		public Task Update(CargaTabelaQueryModel searchQuery, CargaTabelaDTO request, bool createIfNotExists = true) { return _mediator.Send(new UpdateCargaTabelaCommand(_logRequestContext, searchQuery, request)); }
		public Task<DomainResponse> DeleteRange(CargaTabelaQueryModel request){ return _mediator.Send(new DeleteRangeCargaTabelaCommand(_logRequestContext, request)); }
		public Task<DomainResponse> Delete(CargaTabelaQueryModel request){ return _mediator.Send(new DeleteCargaTabelaCommand(_logRequestContext, request)); }
	}
	public partial class SystemSettingsAggSettingsAppService : BaseAppService, ISystemSettingsAggSettingsAppService {	
		public ISystemSettingsAggSettingsRepository _systemSettingsAggSettingsRepository;
		public SystemSettingsAggSettingsAppService(IMediator mediator, Niu.Nutri.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, ISystemSettingsAggSettingsRepository systemSettingsAggSettingsRepository) : base(ctx, mediator) { _systemSettingsAggSettingsRepository = systemSettingsAggSettingsRepository; }	
		public async Task<SystemSettingsAggSettingsDTO> Get(SystemSettingsAggSettingsQueryModel request) {
            return (await _systemSettingsAggSettingsRepository.FindAsync(filter: SystemSettingsAggSettingsFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification), selector: x => x.ProjectedAs<SystemSettingsAggSettingsDTO>()));
        }
		public void Dispose()
        {
			_systemSettingsAggSettingsRepository = null;
        }
		public async Task<IEnumerable<T>> GetAll<T>(SystemSettingsAggSettingsQueryModel request, int? page = null, int? size = null, Expression<Func<SystemSettingsAggSettings, T>> selector = null) {
			return await _systemSettingsAggSettingsRepository.SelectAllAsync(
                filter: SystemSettingsAggSettingsFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<SystemSettingsAggSettings>(),
                selector: selector);
		}
		public async Task<T> Select<T>(SystemSettingsAggSettingsQueryModel request, Expression<Func<SystemSettingsAggSettings, T>> selector = null)
        {
            return (await _systemSettingsAggSettingsRepository.FindAsync(filter: SystemSettingsAggSettingsFilters.GetFilters(request, isOrSpecification: true), selector: selector));
        }
        public async Task<IEnumerable<SystemSettingsAggSettingsDTO>> GetAll(SystemSettingsAggSettingsQueryModel request, int? page = null, int? size = null) {
            return await _systemSettingsAggSettingsRepository.FindAllAsync(
                filter: SystemSettingsAggSettingsFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<SystemSettingsAggSettings>(),
                selector: x => x.ProjectedAs<SystemSettingsAggSettingsDTO>());
        }
		public async Task<IEnumerable<SystemSettingsAggSettingsListiningDTO>> GetAllSummary(SystemSettingsAggSettingsQueryModel request, int? page = null, int? size = null)
        {
            return await _systemSettingsAggSettingsRepository.FindAllAsync(
                filter: SystemSettingsAggSettingsFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<SystemSettingsAggSettings>(),
                selector: x => x.ProjectedAs<SystemSettingsAggSettingsListiningDTO>());
        }

		public Task<DomainResponse> Create(SystemSettingsAggSettingsDTO request, bool updateIfExists = true, SystemSettingsAggSettingsQueryModel searchQuery = null) { return _mediator.Send(new CreateSystemSettingsAggSettingsCommand(_logRequestContext, request)); }
		public async Task<int> CountAsync(SystemSettingsAggSettingsQueryModel request) { return await _systemSettingsAggSettingsRepository.CountAsync(filter: SystemSettingsAggSettingsFilters.GetFilters(request, isOrSpecification: true)); }
		public Task Update(SystemSettingsAggSettingsQueryModel searchQuery, SystemSettingsAggSettingsDTO request, bool createIfNotExists = true) { return _mediator.Send(new UpdateSystemSettingsAggSettingsCommand(_logRequestContext, searchQuery, request)); }
		public Task<DomainResponse> DeleteRange(SystemSettingsAggSettingsQueryModel request){ return _mediator.Send(new DeleteRangeSystemSettingsAggSettingsCommand(_logRequestContext, request)); }
		public Task<DomainResponse> Delete(SystemSettingsAggSettingsQueryModel request){ return _mediator.Send(new DeleteSystemSettingsAggSettingsCommand(_logRequestContext, request)); }
	}
}
