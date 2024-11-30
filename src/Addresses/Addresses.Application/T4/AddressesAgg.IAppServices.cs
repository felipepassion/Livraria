using System.Linq.Expressions;
using Niu.Nutri.Core.Domain.CrossCutting;
using Niu.Nutri.Core.Application.Aggregates.Common;

namespace Niu.Nutri.Addresses.Application.Aggregates.AddressesAgg.AppServices {
	using Application.DTO.Aggregates.AddressesAgg.Requests;
    using Domain.Aggregates.AddressesAgg.Queries.Models;
	public partial interface IAddressAppService : IBaseAppService {	
		public Task<AddressDTO> Get(AddressQueryModel request);
		public Task<int> CountAsync(AddressQueryModel request);
		public Task<IEnumerable<AddressDTO>> GetAll(AddressQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(AddressQueryModel request, Expression<Func<Domain.Aggregates.AddressesAgg.Entities.Address, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(AddressQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.AddressesAgg.Entities.Address, T>> selector = null);
		public Task<IEnumerable<AddressListiningDTO>> GetAllSummary(AddressQueryModel request, int? page = null, int? size = null);

		public Task<DomainResponse> Create(AddressDTO request, bool updateIfExists = true, AddressQueryModel searchQuery = null);
		public Task<DomainResponse> Delete(AddressQueryModel request);
		public Task<DomainResponse> DeleteRange(AddressQueryModel request);
		public Task Update(AddressQueryModel searchQuery, AddressDTO request, bool createIfNotExists = true);
	}
	public partial interface IAddressesAggSettingsAppService : IBaseAppService {	
		public Task<AddressesAggSettingsDTO> Get(AddressesAggSettingsQueryModel request);
		public Task<int> CountAsync(AddressesAggSettingsQueryModel request);
		public Task<IEnumerable<AddressesAggSettingsDTO>> GetAll(AddressesAggSettingsQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(AddressesAggSettingsQueryModel request, Expression<Func<Domain.Aggregates.AddressesAgg.Entities.AddressesAggSettings, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(AddressesAggSettingsQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.AddressesAgg.Entities.AddressesAggSettings, T>> selector = null);
		public Task<IEnumerable<AddressesAggSettingsListiningDTO>> GetAllSummary(AddressesAggSettingsQueryModel request, int? page = null, int? size = null);

		public Task<DomainResponse> Create(AddressesAggSettingsDTO request, bool updateIfExists = true, AddressesAggSettingsQueryModel searchQuery = null);
		public Task<DomainResponse> Delete(AddressesAggSettingsQueryModel request);
		public Task<DomainResponse> DeleteRange(AddressesAggSettingsQueryModel request);
		public Task Update(AddressesAggSettingsQueryModel searchQuery, AddressesAggSettingsDTO request, bool createIfNotExists = true);
	}
}
