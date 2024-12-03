
using MediatR;
using Niu.Nutri.Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;
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

    public partial class LivroCommandHandler : BaseLivrariaAggCommandHandler<Livro>,
        IRequestHandler<CreateLivroCommand,DomainResponse>,
        IRequestHandler<DeleteLivroCommand,DomainResponse>,
        IRequestHandler<UpdateLivroCommand,DomainResponse>
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

        public async Task<DomainResponse> Handle(UpdateLivroCommand command,CancellationToken cancellationToken) {
            var entities = new List<Livro>();
            var entity = command.Entity as Livro ?? await _livroRepository.FindAsync(LivroFilters.GetFilters(command.Query));
                
            if(entity == null) {
                if(command.CreateIfNotExists)
                    return await Handle(new CreateLivroCommand(command.Context,command.Request),cancellationToken);
                return AddError($"Entity {nameof(Livro)} not found with the request.");
            }

            var entityAfter = command.Request.ProjectedAs<Livro>();
            
            entity.Update(entityAfter,"Id");
            var updateResult = await OnUpdateAsync(entity, entityAfter);
            
            if (!updateResult.Success) return updateResult;
            entity.AddDomainEvent(new LivroUpdatedEvent(command.Context, entity));

            return await Commit(_livroRepository.UnitOfWork, command.Entity.ProjectedAs<LivroDTO>());
        }
    }
    