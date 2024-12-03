using MediatR;
using Niu.Nutri.Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;
using Niu.Nutri.Core.Application.DTO.Extensions;
using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Commands.Handles;

namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Commands.Handlers;
    using Filters;
    using Events;
    using Repositories;
    using Commands;
    using Entities;
    using Queries.Models;
    using Application.DTO.Aggregates.LivrariaAgg.Requests;

    public partial class AssuntoCommandHandler : BaseLivrariaAggCommandHandler<Assunto>,
        IRequestHandler<CreateAssuntoCommand,DomainResponse>,
        IRequestHandler<DeleteRangeAssuntoCommand,DomainResponse>,
        IRequestHandler<DeleteAssuntoCommand,DomainResponse>,
        IRequestHandler<UpdateRangeAssuntoCommand,DomainResponse>,
        IRequestHandler<UpdateAssuntoCommand,DomainResponse>,
        IRequestHandler<ActiveAssuntoCommand,DomainResponse>,
        IRequestHandler<DeactiveAssuntoCommand,DomainResponse>
    {
        IAssuntoRepository _assuntoRepository;

        public AssuntoCommandHandler(IServiceProvider provider,IMediator mediator,IAssuntoRepository assuntoRepository ) : base(provider,mediator) { _assuntoRepository = assuntoRepository; }

        partial void OnCreate(Assunto entity);
        partial void OnUpdate(Assunto entity);

        public async Task<DomainResponse> Handle(CreateAssuntoCommand command,CancellationToken cancellationToken) {

            Assunto entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.IdExterno))
            {
                var filter = AssuntoFilters.GetFilters(command.Query ?? new AssuntoQueryModel { IdExternoEqual = command.Request.IdExterno });
                entity = await _assuntoRepository.FindAsync(filter, includeAll: false);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateAssuntoCommand(
                            command.Context,
                            new Queries.Models.AssuntoQueryModel { IdExternoEqual = command.Request.IdExterno },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.Assunto>();
            entity.AddDomainEvent(new AssuntoCreatedEvent(command.Context,entity));

            _assuntoRepository.UnitOfWork.ResolveAttaches(entity);
            var creationResult = await OnCreateAsync(entity);
            if (!creationResult.Success) return creationResult;
			_assuntoRepository.Add(entity);

            var result = await Commit(_assuntoRepository.UnitOfWork);
            result.Data = entity.ProjectedAs<AssuntoDTO>();
            return result;
        }

        public async Task<DomainResponse> Handle(DeleteAssuntoCommand command,CancellationToken cancellationToken) {
            var filter = AssuntoFilters.GetFilters(command.Query);
			var entity = await _assuntoRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(Assunto)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _assuntoRepository.Delete(entity);

            var deleteResult = await OnDeleteAsync(entity);
            if (!deleteResult.Success) return deleteResult;

            entity.AddDomainEvent(new AssuntoDeletedEvent(command.Context,entity));
            return await Commit(_assuntoRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(DeleteRangeAssuntoCommand command,CancellationToken cancellationToken) {
            var filter = AssuntoFilters.GetFilters(command.Query);
			var entities = await _assuntoRepository.FindAllAsync(filter);

			_assuntoRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_assuntoRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(UpdateAssuntoCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeAssuntoCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<DomainResponse> Handle(UpdateRangeAssuntoCommand command,CancellationToken cancellationToken) {
            var entities = new List<Assunto>();
            foreach (var item in command.Query)
            {
                var entity = command.Entity as Assunto ?? await _assuntoRepository.FindAsync(AssuntoFilters.GetFilters(item.Key));
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateAssuntoCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(Assunto)} not found with the request.");
                }
                var entityAfter = item.Value.ProjectedAs<Assunto>();
                _assuntoRepository.UnitOfWork.ResolveAttachesOnUpdate(entity, entityAfter);
                entity.Update(entityAfter,"Id");
                var updateResult = await OnUpdateAsync(entity, entityAfter);
                if (!updateResult.Success) return updateResult;
                entity.AddDomainEvent(new AssuntoUpdatedEvent(command.Context, entity));
            }
            
            PublishLog(command);

            return await Commit(_assuntoRepository.UnitOfWork, command.Entity.ProjectedAs<AssuntoDTO>());
        }
         
        public async Task<DomainResponse> Handle(ActiveAssuntoCommand command,CancellationToken cancellationToken) {
            var assunto = await _assuntoRepository.FindAsync(filter: AssuntoFilters.GetFilters(command.Query));
            //assunto.Disable();

            PublishLog(command);
            
            return await Commit(_assuntoRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(DeactiveAssuntoCommand command,CancellationToken cancellationToken) {
            var assunto = await _assuntoRepository.FindAsync(filter: AssuntoFilters.GetFilters(command.Query));
            //assunto.Enable();

            PublishLog(command);
            
            return await Commit(_assuntoRepository.UnitOfWork);
        }
    }
    