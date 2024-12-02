
using MediatR;
using Niu.Nutri.Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;
using Niu.Nutri.Core.Application.DTO.Extensions;
using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Commands.Handles;

namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.CommandHandlers
{
    using Filters;
    using ModelEvents;
    using Repositories;
    using CommandModels;
    using Entities;
    using Queries.Models;
    using Application.DTO.Aggregates.LivrariaAgg.Requests;
    
    public class BaseLivrariaAggCommandHandler<T> : BaseCommandHandler<T> where T : IEntity {public BaseLivrariaAggCommandHandler(IServiceProvider provider,IMediator mediator):base(mediator, provider){}}
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

            return await Commit(_livroRepository.UnitOfWork, entity.ProjectedAs<LivroDTO>());
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

            return await Commit(_assuntoRepository.UnitOfWork, entity.ProjectedAs<AssuntoDTO>());
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
    public partial class AutorCommandHandler : BaseLivrariaAggCommandHandler<Autor>,
        IRequestHandler<CreateAutorCommand,DomainResponse>,
        IRequestHandler<DeleteRangeAutorCommand,DomainResponse>,
        IRequestHandler<DeleteAutorCommand,DomainResponse>,
        IRequestHandler<UpdateRangeAutorCommand,DomainResponse>,
        IRequestHandler<UpdateAutorCommand,DomainResponse>,
        IRequestHandler<ActiveAutorCommand,DomainResponse>,
        IRequestHandler<DeactiveAutorCommand,DomainResponse>
    {
        IAutorRepository _autorRepository;

        public AutorCommandHandler(IServiceProvider provider,IMediator mediator,IAutorRepository autorRepository ) : base(provider,mediator) { _autorRepository = autorRepository; }

        partial void OnCreate(Autor entity);
        partial void OnUpdate(Autor entity);

        public async Task<DomainResponse> Handle(CreateAutorCommand command,CancellationToken cancellationToken) {

            Autor entity;
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
            entity = command.Request.ProjectedAs<Entities.Autor>();
            entity.AddDomainEvent(new AutorCreatedEvent(command.Context,entity));

            _autorRepository.UnitOfWork.ResolveAttaches(entity);
            var creationResult = await OnCreateAsync(entity);
            if (!creationResult.Success) return creationResult;
			_autorRepository.Add(entity);

            return await Commit(_autorRepository.UnitOfWork, entity.ProjectedAs<AutorDTO>());
        }

        public async Task<DomainResponse> Handle(DeleteAutorCommand command,CancellationToken cancellationToken) {
            var filter = AutorFilters.GetFilters(command.Query);
			var entity = await _autorRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(Autor)} not found with the request.");
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

        public async Task<DomainResponse> Handle(DeleteRangeAutorCommand command,CancellationToken cancellationToken) {
            var filter = AutorFilters.GetFilters(command.Query);
			var entities = await _autorRepository.FindAllAsync(filter);

			_autorRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_autorRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(UpdateAutorCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeAutorCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<DomainResponse> Handle(UpdateRangeAutorCommand command,CancellationToken cancellationToken) {
            var entities = new List<Autor>();
            foreach (var item in command.Query)
            {
                var entity = command.Entity as Autor ?? await _autorRepository.FindAsync(AutorFilters.GetFilters(item.Key));
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateAutorCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(Autor)} not found with the request.");
                }
                var entityAfter = item.Value.ProjectedAs<Autor>();
                _autorRepository.UnitOfWork.ResolveAttachesOnUpdate(entity, entityAfter);
                entity.Update(entityAfter,"Id");
                var updateResult = await OnUpdateAsync(entity, entityAfter);
                if (!updateResult.Success) return updateResult;
                entity.AddDomainEvent(new AutorUpdatedEvent(command.Context, entity));
            }
            
            PublishLog(command);

            return await Commit(_autorRepository.UnitOfWork, command.Entity.ProjectedAs<AutorDTO>());
        }
         
        public async Task<DomainResponse> Handle(ActiveAutorCommand command,CancellationToken cancellationToken) {
            var autor = await _autorRepository.FindAsync(filter: AutorFilters.GetFilters(command.Query));
            //autor.Disable();

            PublishLog(command);
            
            return await Commit(_autorRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(DeactiveAutorCommand command,CancellationToken cancellationToken) {
            var autor = await _autorRepository.FindAsync(filter: AutorFilters.GetFilters(command.Query));
            //autor.Enable();

            PublishLog(command);
            
            return await Commit(_autorRepository.UnitOfWork);
        }
    }
    public partial class LivrariaAggSettingsCommandHandler : BaseLivrariaAggCommandHandler<LivrariaAggSettings>,
        IRequestHandler<CreateLivrariaAggSettingsCommand,DomainResponse>,
        IRequestHandler<DeleteRangeLivrariaAggSettingsCommand,DomainResponse>,
        IRequestHandler<DeleteLivrariaAggSettingsCommand,DomainResponse>,
        IRequestHandler<UpdateRangeLivrariaAggSettingsCommand,DomainResponse>,
        IRequestHandler<UpdateLivrariaAggSettingsCommand,DomainResponse>,
        IRequestHandler<ActiveLivrariaAggSettingsCommand,DomainResponse>,
        IRequestHandler<DeactiveLivrariaAggSettingsCommand,DomainResponse>
    {
        ILivrariaAggSettingsRepository _livrariaAggSettingsRepository;

        public LivrariaAggSettingsCommandHandler(IServiceProvider provider,IMediator mediator,ILivrariaAggSettingsRepository livrariaAggSettingsRepository ) : base(provider,mediator) { _livrariaAggSettingsRepository = livrariaAggSettingsRepository; }

        partial void OnCreate(LivrariaAggSettings entity);
        partial void OnUpdate(LivrariaAggSettings entity);

        public async Task<DomainResponse> Handle(CreateLivrariaAggSettingsCommand command,CancellationToken cancellationToken) {

            LivrariaAggSettings entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.IdExterno))
            {
                var filter = LivrariaAggSettingsFilters.GetFilters(command.Query ?? new LivrariaAggSettingsQueryModel { IdExternoEqual = command.Request.IdExterno });
                entity = await _livrariaAggSettingsRepository.FindAsync(filter, includeAll: false);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateLivrariaAggSettingsCommand(
                            command.Context,
                            new Queries.Models.LivrariaAggSettingsQueryModel { IdExternoEqual = command.Request.IdExterno },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.LivrariaAggSettings>();
            entity.AddDomainEvent(new LivrariaAggSettingsCreatedEvent(command.Context,entity));

            _livrariaAggSettingsRepository.UnitOfWork.ResolveAttaches(entity);
            var creationResult = await OnCreateAsync(entity);
            if (!creationResult.Success) return creationResult;
			_livrariaAggSettingsRepository.Add(entity);

            return await Commit(_livrariaAggSettingsRepository.UnitOfWork, entity.ProjectedAs<LivrariaAggSettingsDTO>());
        }

        public async Task<DomainResponse> Handle(DeleteLivrariaAggSettingsCommand command,CancellationToken cancellationToken) {
            var filter = LivrariaAggSettingsFilters.GetFilters(command.Query);
			var entity = await _livrariaAggSettingsRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(LivrariaAggSettings)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _livrariaAggSettingsRepository.Delete(entity);

            var deleteResult = await OnDeleteAsync(entity);
            if (!deleteResult.Success) return deleteResult;

            entity.AddDomainEvent(new LivrariaAggSettingsDeletedEvent(command.Context,entity));
            return await Commit(_livrariaAggSettingsRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(DeleteRangeLivrariaAggSettingsCommand command,CancellationToken cancellationToken) {
            var filter = LivrariaAggSettingsFilters.GetFilters(command.Query);
			var entities = await _livrariaAggSettingsRepository.FindAllAsync(filter);

			_livrariaAggSettingsRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_livrariaAggSettingsRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(UpdateLivrariaAggSettingsCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeLivrariaAggSettingsCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<DomainResponse> Handle(UpdateRangeLivrariaAggSettingsCommand command,CancellationToken cancellationToken) {
            var entities = new List<LivrariaAggSettings>();
            foreach (var item in command.Query)
            {
                var entity = command.Entity as LivrariaAggSettings ?? await _livrariaAggSettingsRepository.FindAsync(LivrariaAggSettingsFilters.GetFilters(item.Key));
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateLivrariaAggSettingsCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(LivrariaAggSettings)} not found with the request.");
                }
                var entityAfter = item.Value.ProjectedAs<LivrariaAggSettings>();
                _livrariaAggSettingsRepository.UnitOfWork.ResolveAttachesOnUpdate(entity, entityAfter);
                entity.Update(entityAfter,"Id");
                var updateResult = await OnUpdateAsync(entity, entityAfter);
                if (!updateResult.Success) return updateResult;
                entity.AddDomainEvent(new LivrariaAggSettingsUpdatedEvent(command.Context, entity));
            }
            
            PublishLog(command);

            return await Commit(_livrariaAggSettingsRepository.UnitOfWork, command.Entity.ProjectedAs<LivrariaAggSettingsDTO>());
        }
         
        public async Task<DomainResponse> Handle(ActiveLivrariaAggSettingsCommand command,CancellationToken cancellationToken) {
            var livrariaaggsettings = await _livrariaAggSettingsRepository.FindAsync(filter: LivrariaAggSettingsFilters.GetFilters(command.Query));
            //livrariaaggsettings.Disable();

            PublishLog(command);
            
            return await Commit(_livrariaAggSettingsRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(DeactiveLivrariaAggSettingsCommand command,CancellationToken cancellationToken) {
            var livrariaaggsettings = await _livrariaAggSettingsRepository.FindAsync(filter: LivrariaAggSettingsFilters.GetFilters(command.Query));
            //livrariaaggsettings.Enable();

            PublishLog(command);
            
            return await Commit(_livrariaAggSettingsRepository.UnitOfWork);
        }
    }
}
