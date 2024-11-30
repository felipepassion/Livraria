
using MediatR;
using System.Linq.Expressions;
using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;
using Niu.Nutri.Core.Application.DTO.Extensions;
using Niu.Nutri.Core.Application.Aggregates.Common;
using Niu.Nutri.Core.Domain.CrossCutting;

namespace Niu.Nutri.Addresses.Application.Aggregates.AddressesAgg.AppServices {
	using Application.DTO.Aggregates.AddressesAgg.Requests;
	using Domain.Aggregates.AddressesAgg.Queries.Models;
	using Domain.Aggregates.AddressesAgg.Repositories;
	using Domain.Aggregates.AddressesAgg.Filters;
	using Domain.Aggregates.AddressesAgg.Entities;
	using Domain.Aggregates.AddressesAgg.CommandModels;
	public partial class AddressAppService : BaseAppService, IAddressAppService {	
		public IAddressRepository _addressRepository;
		public AddressAppService(IMediator mediator, Niu.Nutri.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IAddressRepository addressRepository) : base(ctx, mediator) { _addressRepository = addressRepository; }	
		public async Task<AddressDTO> Get(AddressQueryModel request) {
            return (await _addressRepository.FindAsync(filter: AddressFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification), selector: x => x.ProjectedAs<AddressDTO>()));
        }
		public void Dispose()
        {
			_addressRepository = null;
        }
		public async Task<IEnumerable<T>> GetAll<T>(AddressQueryModel request, int? page = null, int? size = null, Expression<Func<Address, T>> selector = null) {
			return await _addressRepository.SelectAllAsync(
                filter: AddressFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Address>(),
                selector: selector);
		}
		public async Task<T> Select<T>(AddressQueryModel request, Expression<Func<Address, T>> selector = null)
        {
            return (await _addressRepository.FindAsync(filter: AddressFilters.GetFilters(request, isOrSpecification: true), selector: selector));
        }
        public async Task<IEnumerable<AddressDTO>> GetAll(AddressQueryModel request, int? page = null, int? size = null) {
            return await _addressRepository.FindAllAsync(
                filter: AddressFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Address>(),
                selector: x => x.ProjectedAs<AddressDTO>());
        }
		public async Task<IEnumerable<AddressListiningDTO>> GetAllSummary(AddressQueryModel request, int? page = null, int? size = null)
        {
            return await _addressRepository.FindAllAsync(
                filter: AddressFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Address>(),
                selector: x => x.ProjectedAs<AddressListiningDTO>());
        }

		public Task<DomainResponse> Create(AddressDTO request, bool updateIfExists = true, AddressQueryModel searchQuery = null) { return _mediator.Send(new CreateAddressCommand(_logRequestContext, request)); }
		public async Task<int> CountAsync(AddressQueryModel request) { return await _addressRepository.CountAsync(filter: AddressFilters.GetFilters(request, isOrSpecification: true)); }
		public Task Update(AddressQueryModel searchQuery, AddressDTO request, bool createIfNotExists = true) { return _mediator.Send(new UpdateAddressCommand(_logRequestContext, searchQuery, request)); }
		public Task<DomainResponse> DeleteRange(AddressQueryModel request){ return _mediator.Send(new DeleteRangeAddressCommand(_logRequestContext, request)); }
		public Task<DomainResponse> Delete(AddressQueryModel request){ return _mediator.Send(new DeleteAddressCommand(_logRequestContext, request)); }
	}
	public partial class AddressesAggSettingsAppService : BaseAppService, IAddressesAggSettingsAppService {	
		public IAddressesAggSettingsRepository _addressesAggSettingsRepository;
		public AddressesAggSettingsAppService(IMediator mediator, Niu.Nutri.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IAddressesAggSettingsRepository addressesAggSettingsRepository) : base(ctx, mediator) { _addressesAggSettingsRepository = addressesAggSettingsRepository; }	
		public async Task<AddressesAggSettingsDTO> Get(AddressesAggSettingsQueryModel request) {
            return (await _addressesAggSettingsRepository.FindAsync(filter: AddressesAggSettingsFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification), selector: x => x.ProjectedAs<AddressesAggSettingsDTO>()));
        }
		public void Dispose()
        {
			_addressesAggSettingsRepository = null;
        }
		public async Task<IEnumerable<T>> GetAll<T>(AddressesAggSettingsQueryModel request, int? page = null, int? size = null, Expression<Func<AddressesAggSettings, T>> selector = null) {
			return await _addressesAggSettingsRepository.SelectAllAsync(
                filter: AddressesAggSettingsFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<AddressesAggSettings>(),
                selector: selector);
		}
		public async Task<T> Select<T>(AddressesAggSettingsQueryModel request, Expression<Func<AddressesAggSettings, T>> selector = null)
        {
            return (await _addressesAggSettingsRepository.FindAsync(filter: AddressesAggSettingsFilters.GetFilters(request, isOrSpecification: true), selector: selector));
        }
        public async Task<IEnumerable<AddressesAggSettingsDTO>> GetAll(AddressesAggSettingsQueryModel request, int? page = null, int? size = null) {
            return await _addressesAggSettingsRepository.FindAllAsync(
                filter: AddressesAggSettingsFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<AddressesAggSettings>(),
                selector: x => x.ProjectedAs<AddressesAggSettingsDTO>());
        }
		public async Task<IEnumerable<AddressesAggSettingsListiningDTO>> GetAllSummary(AddressesAggSettingsQueryModel request, int? page = null, int? size = null)
        {
            return await _addressesAggSettingsRepository.FindAllAsync(
                filter: AddressesAggSettingsFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<AddressesAggSettings>(),
                selector: x => x.ProjectedAs<AddressesAggSettingsListiningDTO>());
        }

		public Task<DomainResponse> Create(AddressesAggSettingsDTO request, bool updateIfExists = true, AddressesAggSettingsQueryModel searchQuery = null) { return _mediator.Send(new CreateAddressesAggSettingsCommand(_logRequestContext, request)); }
		public async Task<int> CountAsync(AddressesAggSettingsQueryModel request) { return await _addressesAggSettingsRepository.CountAsync(filter: AddressesAggSettingsFilters.GetFilters(request, isOrSpecification: true)); }
		public Task Update(AddressesAggSettingsQueryModel searchQuery, AddressesAggSettingsDTO request, bool createIfNotExists = true) { return _mediator.Send(new UpdateAddressesAggSettingsCommand(_logRequestContext, searchQuery, request)); }
		public Task<DomainResponse> DeleteRange(AddressesAggSettingsQueryModel request){ return _mediator.Send(new DeleteRangeAddressesAggSettingsCommand(_logRequestContext, request)); }
		public Task<DomainResponse> Delete(AddressesAggSettingsQueryModel request){ return _mediator.Send(new DeleteAddressesAggSettingsCommand(_logRequestContext, request)); }
	}
}
