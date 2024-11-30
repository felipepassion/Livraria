using MediatR;
using Niu.Nutri.Core.Domain.CrossCutting;
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
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = LivrariaAggSettingsFilters.GetFilters(command.Query ?? new LivrariaAggSettingsQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _livrariaAggSettingsRepository.FindAsync(filter, includeAll: false);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateLivrariaAggSettingsCommand(
                            command.Context,
                            new Queries.Models.LivrariaAggSettingsQueryModel { ExternalIdEqual = command.Request.ExternalId },
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
    public partial class Livro_AutorCommandHandler : BaseLivrariaAggCommandHandler<Livro_Autor>,
        IRequestHandler<CreateLivro_AutorCommand,DomainResponse>,
        IRequestHandler<DeleteRangeLivro_AutorCommand,DomainResponse>,
        IRequestHandler<DeleteLivro_AutorCommand,DomainResponse>,
        IRequestHandler<UpdateRangeLivro_AutorCommand,DomainResponse>,
        IRequestHandler<UpdateLivro_AutorCommand,DomainResponse>,
        IRequestHandler<ActiveLivro_AutorCommand,DomainResponse>,
        IRequestHandler<DeactiveLivro_AutorCommand,DomainResponse>
    {
        ILivro_AutorRepository _livro_AutorRepository;

        public Livro_AutorCommandHandler(IServiceProvider provider,IMediator mediator,ILivro_AutorRepository livro_AutorRepository ) : base(provider,mediator) { _livro_AutorRepository = livro_AutorRepository; }

        partial void OnCreate(Livro_Autor entity);
        partial void OnUpdate(Livro_Autor entity);

        public async Task<DomainResponse> Handle(CreateLivro_AutorCommand command,CancellationToken cancellationToken) {

            Livro_Autor entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = Livro_AutorFilters.GetFilters(command.Query ?? new Livro_AutorQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _livro_AutorRepository.FindAsync(filter, includeAll: false);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateLivro_AutorCommand(
                            command.Context,
                            new Queries.Models.Livro_AutorQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.Livro_Autor>();
            entity.AddDomainEvent(new Livro_AutorCreatedEvent(command.Context,entity));

            _livro_AutorRepository.UnitOfWork.ResolveAttaches(entity);
            var creationResult = await OnCreateAsync(entity);
            if (!creationResult.Success) return creationResult;
			_livro_AutorRepository.Add(entity);

            return await Commit(_livro_AutorRepository.UnitOfWork, entity.ProjectedAs<Livro_AutorDTO>());
        }

        public async Task<DomainResponse> Handle(DeleteLivro_AutorCommand command,CancellationToken cancellationToken) {
            var filter = Livro_AutorFilters.GetFilters(command.Query);
			var entity = await _livro_AutorRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(Livro_Autor)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _livro_AutorRepository.Delete(entity);

            var deleteResult = await OnDeleteAsync(entity);
            if (!deleteResult.Success) return deleteResult;

            entity.AddDomainEvent(new Livro_AutorDeletedEvent(command.Context,entity));
            return await Commit(_livro_AutorRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(DeleteRangeLivro_AutorCommand command,CancellationToken cancellationToken) {
            var filter = Livro_AutorFilters.GetFilters(command.Query);
			var entities = await _livro_AutorRepository.FindAllAsync(filter);

			_livro_AutorRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_livro_AutorRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(UpdateLivro_AutorCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeLivro_AutorCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<DomainResponse> Handle(UpdateRangeLivro_AutorCommand command,CancellationToken cancellationToken) {
            var entities = new List<Livro_Autor>();
            foreach (var item in command.Query)
            {
                var entity = command.Entity as Livro_Autor ?? await _livro_AutorRepository.FindAsync(Livro_AutorFilters.GetFilters(item.Key));
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateLivro_AutorCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(Livro_Autor)} not found with the request.");
                }
                var entityAfter = item.Value.ProjectedAs<Livro_Autor>();
                _livro_AutorRepository.UnitOfWork.ResolveAttachesOnUpdate(entity, entityAfter);
                entity.Update(entityAfter,"Id");
                var updateResult = await OnUpdateAsync(entity, entityAfter);
                if (!updateResult.Success) return updateResult;
                entity.AddDomainEvent(new Livro_AutorUpdatedEvent(command.Context, entity));
            }
            
            PublishLog(command);

            return await Commit(_livro_AutorRepository.UnitOfWork, command.Entity.ProjectedAs<Livro_AutorDTO>());
        }
         
        public async Task<DomainResponse> Handle(ActiveLivro_AutorCommand command,CancellationToken cancellationToken) {
            var livro_autor = await _livro_AutorRepository.FindAsync(filter: Livro_AutorFilters.GetFilters(command.Query));
            //livro_autor.Disable();

            PublishLog(command);
            
            return await Commit(_livro_AutorRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(DeactiveLivro_AutorCommand command,CancellationToken cancellationToken) {
            var livro_autor = await _livro_AutorRepository.FindAsync(filter: Livro_AutorFilters.GetFilters(command.Query));
            //livro_autor.Enable();

            PublishLog(command);
            
            return await Commit(_livro_AutorRepository.UnitOfWork);
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
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = AutorFilters.GetFilters(command.Query ?? new AutorQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _autorRepository.FindAsync(filter, includeAll: false);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateAutorCommand(
                            command.Context,
                            new Queries.Models.AutorQueryModel { ExternalIdEqual = command.Request.ExternalId },
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
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = AssuntoFilters.GetFilters(command.Query ?? new AssuntoQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _assuntoRepository.FindAsync(filter, includeAll: false);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateAssuntoCommand(
                            command.Context,
                            new Queries.Models.AssuntoQueryModel { ExternalIdEqual = command.Request.ExternalId },
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
    public partial class Livro_AssuntoCommandHandler : BaseLivrariaAggCommandHandler<Livro_Assunto>,
        IRequestHandler<CreateLivro_AssuntoCommand,DomainResponse>,
        IRequestHandler<DeleteRangeLivro_AssuntoCommand,DomainResponse>,
        IRequestHandler<DeleteLivro_AssuntoCommand,DomainResponse>,
        IRequestHandler<UpdateRangeLivro_AssuntoCommand,DomainResponse>,
        IRequestHandler<UpdateLivro_AssuntoCommand,DomainResponse>,
        IRequestHandler<ActiveLivro_AssuntoCommand,DomainResponse>,
        IRequestHandler<DeactiveLivro_AssuntoCommand,DomainResponse>
    {
        ILivro_AssuntoRepository _livro_AssuntoRepository;

        public Livro_AssuntoCommandHandler(IServiceProvider provider,IMediator mediator,ILivro_AssuntoRepository livro_AssuntoRepository ) : base(provider,mediator) { _livro_AssuntoRepository = livro_AssuntoRepository; }

        partial void OnCreate(Livro_Assunto entity);
        partial void OnUpdate(Livro_Assunto entity);

        public async Task<DomainResponse> Handle(CreateLivro_AssuntoCommand command,CancellationToken cancellationToken) {

            Livro_Assunto entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = Livro_AssuntoFilters.GetFilters(command.Query ?? new Livro_AssuntoQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _livro_AssuntoRepository.FindAsync(filter, includeAll: false);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateLivro_AssuntoCommand(
                            command.Context,
                            new Queries.Models.Livro_AssuntoQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.Livro_Assunto>();
            entity.AddDomainEvent(new Livro_AssuntoCreatedEvent(command.Context,entity));

            _livro_AssuntoRepository.UnitOfWork.ResolveAttaches(entity);
            var creationResult = await OnCreateAsync(entity);
            if (!creationResult.Success) return creationResult;
			_livro_AssuntoRepository.Add(entity);

            return await Commit(_livro_AssuntoRepository.UnitOfWork, entity.ProjectedAs<Livro_AssuntoDTO>());
        }

        public async Task<DomainResponse> Handle(DeleteLivro_AssuntoCommand command,CancellationToken cancellationToken) {
            var filter = Livro_AssuntoFilters.GetFilters(command.Query);
			var entity = await _livro_AssuntoRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(Livro_Assunto)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _livro_AssuntoRepository.Delete(entity);

            var deleteResult = await OnDeleteAsync(entity);
            if (!deleteResult.Success) return deleteResult;

            entity.AddDomainEvent(new Livro_AssuntoDeletedEvent(command.Context,entity));
            return await Commit(_livro_AssuntoRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(DeleteRangeLivro_AssuntoCommand command,CancellationToken cancellationToken) {
            var filter = Livro_AssuntoFilters.GetFilters(command.Query);
			var entities = await _livro_AssuntoRepository.FindAllAsync(filter);

			_livro_AssuntoRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_livro_AssuntoRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(UpdateLivro_AssuntoCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeLivro_AssuntoCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<DomainResponse> Handle(UpdateRangeLivro_AssuntoCommand command,CancellationToken cancellationToken) {
            var entities = new List<Livro_Assunto>();
            foreach (var item in command.Query)
            {
                var entity = command.Entity as Livro_Assunto ?? await _livro_AssuntoRepository.FindAsync(Livro_AssuntoFilters.GetFilters(item.Key));
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateLivro_AssuntoCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(Livro_Assunto)} not found with the request.");
                }
                var entityAfter = item.Value.ProjectedAs<Livro_Assunto>();
                _livro_AssuntoRepository.UnitOfWork.ResolveAttachesOnUpdate(entity, entityAfter);
                entity.Update(entityAfter,"Id");
                var updateResult = await OnUpdateAsync(entity, entityAfter);
                if (!updateResult.Success) return updateResult;
                entity.AddDomainEvent(new Livro_AssuntoUpdatedEvent(command.Context, entity));
            }
            
            PublishLog(command);

            return await Commit(_livro_AssuntoRepository.UnitOfWork, command.Entity.ProjectedAs<Livro_AssuntoDTO>());
        }
         
        public async Task<DomainResponse> Handle(ActiveLivro_AssuntoCommand command,CancellationToken cancellationToken) {
            var livro_assunto = await _livro_AssuntoRepository.FindAsync(filter: Livro_AssuntoFilters.GetFilters(command.Query));
            //livro_assunto.Disable();

            PublishLog(command);
            
            return await Commit(_livro_AssuntoRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(DeactiveLivro_AssuntoCommand command,CancellationToken cancellationToken) {
            var livro_assunto = await _livro_AssuntoRepository.FindAsync(filter: Livro_AssuntoFilters.GetFilters(command.Query));
            //livro_assunto.Enable();

            PublishLog(command);
            
            return await Commit(_livro_AssuntoRepository.UnitOfWork);
        }
    }
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
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = LivroFilters.GetFilters(command.Query ?? new LivroQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _livroRepository.FindAsync(filter, includeAll: false);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateLivroCommand(
                            command.Context,
                            new Queries.Models.LivroQueryModel { ExternalIdEqual = command.Request.ExternalId },
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
}
