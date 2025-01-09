using MediatR;
using Niu.Nutri.Core.Application.DTO.Http.Models.Responses;
using Niu.Nutri.Core.Application.DTO.Extensions;
using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;

namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Commands.Handlers;
    using Filters;
    using Events;
    using Repositories;
    using Commands;
    using Entities;
    using Queries.Models;
    using Application.DTO.Aggregates.LivrariaAgg.Requests;

    public partial class AutorCommandHandler : BaseLivrariaAggCommandHandler<Author>,
        IRequestHandler<CreateAutorCommand,DomainResponse>,
        IRequestHandler<DeleteAutorCommand,DomainResponse>,
        IRequestHandler<UpdateAutorCommand,DomainResponse>
    {
        IAutorRepository _autorRepository;

        public AutorCommandHandler(IServiceProvider provider,IMediator mediator,IAutorRepository autorRepository ) : base(provider,mediator) { _autorRepository = autorRepository; }

        partial void OnCreate(Author entity);
        partial void OnUpdate(Author entity);

        public async Task<DomainResponse> Handle(CreateAutorCommand command,CancellationToken cancellationToken) {

            Author entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.IdExterno))
            {
                var filter = AutorFilters.GetFilters(command.Query ?? new AutorQueryModel { IdExternoEqual = command.Request.IdExterno });
                entity = await _autorRepository.FindAsync(filter, includeAll: false);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateAutorCommand(
                            command.Context,
                            new Queries.Models.AutorQueryModel { IdExternoEqual = command.Request.IdExterno },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.Author>();
            entity.AddDomainEvent(new AutorCreatedEvent(command.Context,entity));

            var creationResult = await OnCreateAsync(entity);
            if (!creationResult.Success) return creationResult;
			
            _autorRepository.Add(entity);

            var result = await Commit(_autorRepository.UnitOfWork);
            result.Data = entity.ProjectedAs<AutorDTO>();
            return result;
        }

        public async Task<DomainResponse> Handle(DeleteAutorCommand command,CancellationToken cancellationToken) {
            var filter = AutorFilters.GetFilters(command.Query);
			var entity = await _autorRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(Author)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _autorRepository.Delete(entity);

            var deleteResult = await OnDeleteAsync(entity);
            if (!deleteResult.Success) return deleteResult;

            entity.AddDomainEvent(new AutorDeletedEvent(command.Context,entity));
            return await Commit(_autorRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(UpdateAutorCommand command,CancellationToken cancellationToken) {
            var entities = new List<Author>();
            var entity = command.Entity as Author ?? await _autorRepository.FindAsync(AutorFilters.GetFilters(command.Query));
                
            if(entity == null) {
                if(command.CreateIfNotExists)
                    return await Handle(new CreateAutorCommand(command.Context,command.Request),cancellationToken);
                return AddError($"Entity {nameof(Author)} not found with the request.");
            }

            var entityAfter = command.Request.ProjectedAs<Author>();
            
            entity.Update(entityAfter,"Id");
            var updateResult = await OnUpdateAsync(entity, entityAfter);
            
            if (!updateResult.Success) return updateResult;
            entity.AddDomainEvent(new AutorUpdatedEvent(command.Context, entity));

            return await Commit(_autorRepository.UnitOfWork, command.Entity.ProjectedAs<AutorDTO>());
        }
    }
    