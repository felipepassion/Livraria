using System.Linq.Expressions;
using Niu.Nutri.Core.Domain.CrossCutting;
using Niu.Nutri.Core.Application.Aggregates.Common;

namespace Niu.Nutri.SystemSettings.Application.Aggregates.SystemSettingsAgg.AppServices {
	using Application.DTO.Aggregates.SystemSettingsAgg.Requests;
    using Domain.Aggregates.SystemSettingsAgg.Queries.Models;
	public partial interface ISystemPanelSubItemAppService : IBaseAppService {	
		public Task<SystemPanelSubItemDTO> Get(SystemPanelSubItemQueryModel request);
		public Task<int> CountAsync(SystemPanelSubItemQueryModel request);
		public Task<IEnumerable<SystemPanelSubItemDTO>> GetAll(SystemPanelSubItemQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(SystemPanelSubItemQueryModel request, Expression<Func<Domain.Aggregates.SystemSettingsAgg.Entities.SystemPanelSubItem, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(SystemPanelSubItemQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.SystemSettingsAgg.Entities.SystemPanelSubItem, T>> selector = null);
		public Task<IEnumerable<SystemPanelSubItemListiningDTO>> GetAllSummary(SystemPanelSubItemQueryModel request, int? page = null, int? size = null);

		public Task<DomainResponse> Create(SystemPanelSubItemDTO request, bool updateIfExists = true, SystemPanelSubItemQueryModel searchQuery = null);
		public Task<DomainResponse> Delete(SystemPanelSubItemQueryModel request);
		public Task<DomainResponse> DeleteRange(SystemPanelSubItemQueryModel request);
		public Task Update(SystemPanelSubItemQueryModel searchQuery, SystemPanelSubItemDTO request, bool createIfNotExists = true);
	}
	public partial interface ISystemPanelAppService : IBaseAppService {	
		public Task<SystemPanelDTO> Get(SystemPanelQueryModel request);
		public Task<int> CountAsync(SystemPanelQueryModel request);
		public Task<IEnumerable<SystemPanelDTO>> GetAll(SystemPanelQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(SystemPanelQueryModel request, Expression<Func<Domain.Aggregates.SystemSettingsAgg.Entities.SystemPanel, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(SystemPanelQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.SystemSettingsAgg.Entities.SystemPanel, T>> selector = null);
		public Task<IEnumerable<SystemPanelListiningDTO>> GetAllSummary(SystemPanelQueryModel request, int? page = null, int? size = null);

		public Task<DomainResponse> Create(SystemPanelDTO request, bool updateIfExists = true, SystemPanelQueryModel searchQuery = null);
		public Task<DomainResponse> Delete(SystemPanelQueryModel request);
		public Task<DomainResponse> DeleteRange(SystemPanelQueryModel request);
		public Task Update(SystemPanelQueryModel searchQuery, SystemPanelDTO request, bool createIfNotExists = true);
	}
	public partial interface ISystemPanelGroupAppService : IBaseAppService {	
		public Task<SystemPanelGroupDTO> Get(SystemPanelGroupQueryModel request);
		public Task<int> CountAsync(SystemPanelGroupQueryModel request);
		public Task<IEnumerable<SystemPanelGroupDTO>> GetAll(SystemPanelGroupQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(SystemPanelGroupQueryModel request, Expression<Func<Domain.Aggregates.SystemSettingsAgg.Entities.SystemPanelGroup, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(SystemPanelGroupQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.SystemSettingsAgg.Entities.SystemPanelGroup, T>> selector = null);
		public Task<IEnumerable<SystemPanelGroupListiningDTO>> GetAllSummary(SystemPanelGroupQueryModel request, int? page = null, int? size = null);

		public Task<DomainResponse> Create(SystemPanelGroupDTO request, bool updateIfExists = true, SystemPanelGroupQueryModel searchQuery = null);
		public Task<DomainResponse> Delete(SystemPanelGroupQueryModel request);
		public Task<DomainResponse> DeleteRange(SystemPanelGroupQueryModel request);
		public Task Update(SystemPanelGroupQueryModel searchQuery, SystemPanelGroupDTO request, bool createIfNotExists = true);
	}
	public partial interface ICargaTabelaAppService : IBaseAppService {	
		public Task<CargaTabelaDTO> Get(CargaTabelaQueryModel request);
		public Task<int> CountAsync(CargaTabelaQueryModel request);
		public Task<IEnumerable<CargaTabelaDTO>> GetAll(CargaTabelaQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(CargaTabelaQueryModel request, Expression<Func<Domain.Aggregates.SystemSettingsAgg.Entities.CargaTabela, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(CargaTabelaQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.SystemSettingsAgg.Entities.CargaTabela, T>> selector = null);
		public Task<IEnumerable<CargaTabelaListiningDTO>> GetAllSummary(CargaTabelaQueryModel request, int? page = null, int? size = null);

		public Task<DomainResponse> Create(CargaTabelaDTO request, bool updateIfExists = true, CargaTabelaQueryModel searchQuery = null);
		public Task<DomainResponse> Delete(CargaTabelaQueryModel request);
		public Task<DomainResponse> DeleteRange(CargaTabelaQueryModel request);
		public Task Update(CargaTabelaQueryModel searchQuery, CargaTabelaDTO request, bool createIfNotExists = true);
	}
	public partial interface ISystemSettingsAggSettingsAppService : IBaseAppService {	
		public Task<SystemSettingsAggSettingsDTO> Get(SystemSettingsAggSettingsQueryModel request);
		public Task<int> CountAsync(SystemSettingsAggSettingsQueryModel request);
		public Task<IEnumerable<SystemSettingsAggSettingsDTO>> GetAll(SystemSettingsAggSettingsQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(SystemSettingsAggSettingsQueryModel request, Expression<Func<Domain.Aggregates.SystemSettingsAgg.Entities.SystemSettingsAggSettings, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(SystemSettingsAggSettingsQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.SystemSettingsAgg.Entities.SystemSettingsAggSettings, T>> selector = null);
		public Task<IEnumerable<SystemSettingsAggSettingsListiningDTO>> GetAllSummary(SystemSettingsAggSettingsQueryModel request, int? page = null, int? size = null);

		public Task<DomainResponse> Create(SystemSettingsAggSettingsDTO request, bool updateIfExists = true, SystemSettingsAggSettingsQueryModel searchQuery = null);
		public Task<DomainResponse> Delete(SystemSettingsAggSettingsQueryModel request);
		public Task<DomainResponse> DeleteRange(SystemSettingsAggSettingsQueryModel request);
		public Task Update(SystemSettingsAggSettingsQueryModel searchQuery, SystemSettingsAggSettingsDTO request, bool createIfNotExists = true);
	}
}
