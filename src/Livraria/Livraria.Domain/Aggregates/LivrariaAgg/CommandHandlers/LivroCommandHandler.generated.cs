
using MediatR;
using Niu.Nutri.Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;
using Niu.Nutri.Core.Application.DTO.Extensions;
using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Commands.Handles;

namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.CommandHandlers;
    using Filters;
    using ModelEvents;
    using Repositories;
    using CommandModels;
    using Entities;
    using Queries.Models;
    using Application.DTO.Aggregates.LivrariaAgg.Requests;

    public partial class LivroCommandHandler : BaseLivrariaAggCommandHandler<Livro>,
        IRequestHandler<CreateLivroCommand,DomainResponse>,
        IRequestHandler<DeleteRangeLivroCommand,DomainResponse>,
        IRequestHandler<DeleteLivroCommand,DomainResponse>,
        IRequestHandler<UpdateRangeLivroCommand,DomainResponse>,
        IRequestHandler<UpdateLivroCommand,DomainResponse>,
        IRequestHandler<ActiveLivroCommand,DomainResponse>,
        IRequestHandler<DeactiveLivroCommand,DomainResponse>
    {
        ILivroRepository _livroRepository;

        public LivroCommandHandler(IServiceProvider provider,IMediator mediator,ILivroRepository livroRepository ) : base(provider,mediator) { _livroRepository = livroRepository; }

        partial void OnCreate(Livro entity);
        partial void OnUpdate(Livro entity);

        public async Task<DomainResponse> Handle(CreateLivroCommand command,CancellationToken cancellationToken) {

            Livro entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.IdExterno))
            {
                var filter = LivroFilters.GetFilters(command.Query ?? new LivroQueryModel { IdExternoEqual = command.Request.IdExterno });
                entity = await _livroRepository.FindAsync(filter, includeAll: false);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateLivroCommand(
                            command.Context,
                            new Queries.Models.LivroQueryModel { IdExternoEqual = command.Request.IdExterno },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.Livro>();
            entity.AddDomainEvent(new LivroCreatedEvent(command.Context,entity));

            _livroRepository.UnitOfWork.ResolveAttaches(entity);
            var creationResult = await OnCreateAsync(entity);
            if (!creationResult.Success) return creationResult;
			_livroRepository.Add(entity);

            var result = await Commit(_livroRepository.UnitOfWork);
            result.Data = entity.ProjectedAs<LivroDTO>();
            return result;
        }

        public async Task<DomainResponse> Handle(DeleteLivroCommand command,CancellationToken cancellationToken) {
            var filter = LivroFilters.GetFilters(command.Query);
			var entity = await _livroRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(Livro)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _livroRepository.Delete(entity);

            var deleteResult = await OnDeleteAsync(entity);
            if (!deleteResult.Success) return deleteResult;

            entity.AddDomainEvent(new LivroDeletedEvent(command.Context,entity));
            return await Commit(_livroRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(DeleteRangeLivroCommand command,CancellationToken cancellationToken) {
            var filter = LivroFilters.GetFilters(command.Query);
			var entities = await _livroRepository.FindAllAsync(filter);

			_livroRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_livroRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(UpdateLivroCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeLivroCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<DomainResponse> Handle(UpdateRangeLivroCommand command,CancellationToken cancellationToken) {
            var entities = new List<Livro>();
            foreach (var item in command.Query)
            {
                var entity = command.Entity as Livro ?? await _livroRepository.FindAsync(LivroFilters.GetFilters(item.Key));
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateLivroCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(Livro)} not found with the request.");
                }
                var entityAfter = item.Value.ProjectedAs<Livro>();
                _livroRepository.UnitOfWork.ResolveAttachesOnUpdate(entity, entityAfter);
                entity.Update(entityAfter,"Id");
                var updateResult = await OnUpdateAsync(entity, entityAfter);
                if (!updateResult.Success) return updateResult;
                entity.AddDomainEvent(new LivroUpdatedEvent(command.Context, entity));
            }
            
            PublishLog(command);

            return await Commit(_livroRepository.UnitOfWork, command.Entity.ProjectedAs<LivroDTO>());
        }
         
        public async Task<DomainResponse> Handle(ActiveLivroCommand command,CancellationToken cancellationToken) {
            var livro = await _livroRepository.FindAsync(filter: LivroFilters.GetFilters(command.Query));
            //livro.Disable();

            PublishLog(command);
            
            return await Commit(_livroRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(DeactiveLivroCommand command,CancellationToken cancellationToken) {
            var livro = await _livroRepository.FindAsync(filter: LivroFilters.GetFilters(command.Query));
            //livro.Enable();

            PublishLog(command);
            
            return await Commit(_livroRepository.UnitOfWork);
        }
    }
    