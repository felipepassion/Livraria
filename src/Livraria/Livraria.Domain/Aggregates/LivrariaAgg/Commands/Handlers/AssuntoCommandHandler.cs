﻿using MediatR;
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

    public partial class AssuntoCommandHandler : BaseLivrariaAggCommandHandler<Subject>,
        IRequestHandler<CreateAssuntoCommand,DomainResponse>,
        IRequestHandler<DeleteAssuntoCommand,DomainResponse>,
        IRequestHandler<UpdateAssuntoCommand,DomainResponse>
    {
        IAssuntoRepository _assuntoRepository;

        public AssuntoCommandHandler(IServiceProvider provider,IMediator mediator,IAssuntoRepository assuntoRepository ) : base(provider,mediator) { _assuntoRepository = assuntoRepository; }

        partial void OnCreate(Subject entity);
        partial void OnUpdate(Subject entity);

        public async Task<DomainResponse> Handle(CreateAssuntoCommand command,CancellationToken cancellationToken) {

            Subject entity;
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
            entity = command.Request.ProjectedAs<Entities.Subject>();
            entity.AddDomainEvent(new AssuntoCreatedEvent(command.Context,entity));

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
                return AddError($"Entity {nameof(Subject)} not found with the request.");
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

        public async Task<DomainResponse> Handle(UpdateAssuntoCommand command,CancellationToken cancellationToken) {
            var entities = new List<Subject>();
            var entity = command.Entity as Subject ?? await _assuntoRepository.FindAsync(AssuntoFilters.GetFilters(command.Query));
                
            if(entity == null) {
                if(command.CreateIfNotExists)
                    return await Handle(new CreateAssuntoCommand(command.Context,command.Request),cancellationToken);
                return AddError($"Entity {nameof(Subject)} not found with the request.");
            }

            var entityAfter = command.Request.ProjectedAs<Subject>();
            
            entity.Update(entityAfter,"Id");
            var updateResult = await OnUpdateAsync(entity, entityAfter);
            
            if (!updateResult.Success) return updateResult;
            entity.AddDomainEvent(new AssuntoUpdatedEvent(command.Context, entity));

            return await Commit(_assuntoRepository.UnitOfWork, command.Entity.ProjectedAs<AssuntoDTO>());
        }
    }
    