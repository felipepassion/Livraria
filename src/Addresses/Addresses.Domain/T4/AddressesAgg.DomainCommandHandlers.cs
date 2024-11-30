using MediatR;
using Niu.Nutri.Core.Domain.CrossCutting;
using Niu.Nutri.Core.Application.DTO.Extensions;
using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Commands.Handles;

namespace Niu.Nutri.Addresses.Domain.Aggregates.AddressesAgg.CommandHandlers
{
    using Filters;
    using ModelEvents;
    using Repositories;
    using CommandModels;
    using Entities;
    using Queries.Models;
    using Application.DTO.Aggregates.AddressesAgg.Requests;
    
    public class BaseAddressesAggCommandHandler<T> : BaseCommandHandler<T> where T : IEntity {public BaseAddressesAggCommandHandler(IServiceProvider provider,IMediator mediator):base(mediator, provider){}}
    public partial class AddressCommandHandler : BaseAddressesAggCommandHandler<Address>,
        IRequestHandler<CreateAddressCommand,DomainResponse>,
        IRequestHandler<DeleteRangeAddressCommand,DomainResponse>,
        IRequestHandler<DeleteAddressCommand,DomainResponse>,
        IRequestHandler<UpdateRangeAddressCommand,DomainResponse>,
        IRequestHandler<UpdateAddressCommand,DomainResponse>,
        IRequestHandler<ActiveAddressCommand,DomainResponse>,
        IRequestHandler<DeactiveAddressCommand,DomainResponse>
    {
        IAddressRepository _addressRepository;

        public AddressCommandHandler(IServiceProvider provider,IMediator mediator,IAddressRepository addressRepository ) : base(provider,mediator) { _addressRepository = addressRepository; }

        partial void OnCreate(Address entity);
        partial void OnUpdate(Address entity);

        public async Task<DomainResponse> Handle(CreateAddressCommand command,CancellationToken cancellationToken) {

            Address entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = AddressFilters.GetFilters(command.Query ?? new AddressQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _addressRepository.FindAsync(filter, includeAll: false);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateAddressCommand(
                            command.Context,
                            new Queries.Models.AddressQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.Address>();
            entity.AddDomainEvent(new AddressCreatedEvent(command.Context,entity));

            _addressRepository.UnitOfWork.ResolveAttaches(entity);
            var creationResult = await OnCreateAsync(entity);
            if (!creationResult.Success) return creationResult;
			_addressRepository.Add(entity);

            return await Commit(_addressRepository.UnitOfWork, entity.ProjectedAs<AddressDTO>());
        }

        public async Task<DomainResponse> Handle(DeleteAddressCommand command,CancellationToken cancellationToken) {
            var filter = AddressFilters.GetFilters(command.Query);
			var entity = await _addressRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(Address)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _addressRepository.Delete(entity);

            var deleteResult = await OnDeleteAsync(entity);
            if (!deleteResult.Success) return deleteResult;

            entity.AddDomainEvent(new AddressDeletedEvent(command.Context,entity));
            return await Commit(_addressRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(DeleteRangeAddressCommand command,CancellationToken cancellationToken) {
            var filter = AddressFilters.GetFilters(command.Query);
			var entities = await _addressRepository.FindAllAsync(filter);

			_addressRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_addressRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(UpdateAddressCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeAddressCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<DomainResponse> Handle(UpdateRangeAddressCommand command,CancellationToken cancellationToken) {
            var entities = new List<Address>();
            foreach (var item in command.Query)
            {
                var entity = command.Entity as Address ?? await _addressRepository.FindAsync(AddressFilters.GetFilters(item.Key));
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateAddressCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(Address)} not found with the request.");
                }
                var entityAfter = item.Value.ProjectedAs<Address>();
                _addressRepository.UnitOfWork.ResolveAttachesOnUpdate(entity, entityAfter);
                entity.Update(entityAfter,"Id");
                var updateResult = await OnUpdateAsync(entity, entityAfter);
                if (!updateResult.Success) return updateResult;
                entity.AddDomainEvent(new AddressUpdatedEvent(command.Context, entity));
            }
            
            PublishLog(command);

            return await Commit(_addressRepository.UnitOfWork, command.Entity.ProjectedAs<AddressDTO>());
        }
         
        public async Task<DomainResponse> Handle(ActiveAddressCommand command,CancellationToken cancellationToken) {
            var address = await _addressRepository.FindAsync(filter: AddressFilters.GetFilters(command.Query));
            //address.Disable();

            PublishLog(command);
            
            return await Commit(_addressRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(DeactiveAddressCommand command,CancellationToken cancellationToken) {
            var address = await _addressRepository.FindAsync(filter: AddressFilters.GetFilters(command.Query));
            //address.Enable();

            PublishLog(command);
            
            return await Commit(_addressRepository.UnitOfWork);
        }
    }
    public partial class AddressesAggSettingsCommandHandler : BaseAddressesAggCommandHandler<AddressesAggSettings>,
        IRequestHandler<CreateAddressesAggSettingsCommand,DomainResponse>,
        IRequestHandler<DeleteRangeAddressesAggSettingsCommand,DomainResponse>,
        IRequestHandler<DeleteAddressesAggSettingsCommand,DomainResponse>,
        IRequestHandler<UpdateRangeAddressesAggSettingsCommand,DomainResponse>,
        IRequestHandler<UpdateAddressesAggSettingsCommand,DomainResponse>,
        IRequestHandler<ActiveAddressesAggSettingsCommand,DomainResponse>,
        IRequestHandler<DeactiveAddressesAggSettingsCommand,DomainResponse>
    {
        IAddressesAggSettingsRepository _addressesAggSettingsRepository;

        public AddressesAggSettingsCommandHandler(IServiceProvider provider,IMediator mediator,IAddressesAggSettingsRepository addressesAggSettingsRepository ) : base(provider,mediator) { _addressesAggSettingsRepository = addressesAggSettingsRepository; }

        partial void OnCreate(AddressesAggSettings entity);
        partial void OnUpdate(AddressesAggSettings entity);

        public async Task<DomainResponse> Handle(CreateAddressesAggSettingsCommand command,CancellationToken cancellationToken) {

            AddressesAggSettings entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = AddressesAggSettingsFilters.GetFilters(command.Query ?? new AddressesAggSettingsQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _addressesAggSettingsRepository.FindAsync(filter, includeAll: false);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateAddressesAggSettingsCommand(
                            command.Context,
                            new Queries.Models.AddressesAggSettingsQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.AddressesAggSettings>();
            entity.AddDomainEvent(new AddressesAggSettingsCreatedEvent(command.Context,entity));

            _addressesAggSettingsRepository.UnitOfWork.ResolveAttaches(entity);
            var creationResult = await OnCreateAsync(entity);
            if (!creationResult.Success) return creationResult;
			_addressesAggSettingsRepository.Add(entity);

            return await Commit(_addressesAggSettingsRepository.UnitOfWork, entity.ProjectedAs<AddressesAggSettingsDTO>());
        }

        public async Task<DomainResponse> Handle(DeleteAddressesAggSettingsCommand command,CancellationToken cancellationToken) {
            var filter = AddressesAggSettingsFilters.GetFilters(command.Query);
			var entity = await _addressesAggSettingsRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(AddressesAggSettings)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _addressesAggSettingsRepository.Delete(entity);

            var deleteResult = await OnDeleteAsync(entity);
            if (!deleteResult.Success) return deleteResult;

            entity.AddDomainEvent(new AddressesAggSettingsDeletedEvent(command.Context,entity));
            return await Commit(_addressesAggSettingsRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(DeleteRangeAddressesAggSettingsCommand command,CancellationToken cancellationToken) {
            var filter = AddressesAggSettingsFilters.GetFilters(command.Query);
			var entities = await _addressesAggSettingsRepository.FindAllAsync(filter);

			_addressesAggSettingsRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_addressesAggSettingsRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(UpdateAddressesAggSettingsCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeAddressesAggSettingsCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<DomainResponse> Handle(UpdateRangeAddressesAggSettingsCommand command,CancellationToken cancellationToken) {
            var entities = new List<AddressesAggSettings>();
            foreach (var item in command.Query)
            {
                var entity = command.Entity as AddressesAggSettings ?? await _addressesAggSettingsRepository.FindAsync(AddressesAggSettingsFilters.GetFilters(item.Key));
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateAddressesAggSettingsCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(AddressesAggSettings)} not found with the request.");
                }
                var entityAfter = item.Value.ProjectedAs<AddressesAggSettings>();
                _addressesAggSettingsRepository.UnitOfWork.ResolveAttachesOnUpdate(entity, entityAfter);
                entity.Update(entityAfter,"Id");
                var updateResult = await OnUpdateAsync(entity, entityAfter);
                if (!updateResult.Success) return updateResult;
                entity.AddDomainEvent(new AddressesAggSettingsUpdatedEvent(command.Context, entity));
            }
            
            PublishLog(command);

            return await Commit(_addressesAggSettingsRepository.UnitOfWork, command.Entity.ProjectedAs<AddressesAggSettingsDTO>());
        }
         
        public async Task<DomainResponse> Handle(ActiveAddressesAggSettingsCommand command,CancellationToken cancellationToken) {
            var addressesaggsettings = await _addressesAggSettingsRepository.FindAsync(filter: AddressesAggSettingsFilters.GetFilters(command.Query));
            //addressesaggsettings.Disable();

            PublishLog(command);
            
            return await Commit(_addressesAggSettingsRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(DeactiveAddressesAggSettingsCommand command,CancellationToken cancellationToken) {
            var addressesaggsettings = await _addressesAggSettingsRepository.FindAsync(filter: AddressesAggSettingsFilters.GetFilters(command.Query));
            //addressesaggsettings.Enable();

            PublishLog(command);
            
            return await Commit(_addressesAggSettingsRepository.UnitOfWork);
        }
    }
}
