using MediatR;
using Niu.Nutri.Core.Domain.CrossCutting;
using Niu.Nutri.Core.Application.DTO.Extensions;
using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Commands.Handles;

namespace Niu.Nutri.Chat.Domain.Aggregates.ChatAgg.CommandHandlers
{
    using Filters;
    using ModelEvents;
    using Repositories;
    using CommandModels;
    using Entities;
    using Queries.Models;
    using Application.DTO.Aggregates.ChatAgg.Requests;
    
    public class BaseChatAggCommandHandler<T> : BaseCommandHandler<T> where T : IEntity {public BaseChatAggCommandHandler(IServiceProvider provider,IMediator mediator):base(mediator, provider){}}
    public partial class ConversationCommandHandler : BaseChatAggCommandHandler<Conversation>,
        IRequestHandler<CreateConversationCommand,DomainResponse>,
        IRequestHandler<DeleteRangeConversationCommand,DomainResponse>,
        IRequestHandler<DeleteConversationCommand,DomainResponse>,
        IRequestHandler<UpdateRangeConversationCommand,DomainResponse>,
        IRequestHandler<UpdateConversationCommand,DomainResponse>,
        IRequestHandler<ActiveConversationCommand,DomainResponse>,
        IRequestHandler<DeactiveConversationCommand,DomainResponse>
    {
        IConversationRepository _conversationRepository;

        public ConversationCommandHandler(IServiceProvider provider,IMediator mediator,IConversationRepository conversationRepository ) : base(provider,mediator) { _conversationRepository = conversationRepository; }

        partial void OnCreate(Conversation entity);
        partial void OnUpdate(Conversation entity);

        public async Task<DomainResponse> Handle(CreateConversationCommand command,CancellationToken cancellationToken) {

            Conversation entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = ConversationFilters.GetFilters(command.Query ?? new ConversationQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _conversationRepository.FindAsync(filter, includeAll: false);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateConversationCommand(
                            command.Context,
                            new Queries.Models.ConversationQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.Conversation>();
            entity.AddDomainEvent(new ConversationCreatedEvent(command.Context,entity));

            _conversationRepository.UnitOfWork.ResolveAttaches(entity);
            var creationResult = await OnCreateAsync(entity);
            if (!creationResult.Success) return creationResult;
			_conversationRepository.Add(entity);

            return await Commit(_conversationRepository.UnitOfWork, entity.ProjectedAs<ConversationDTO>());
        }

        public async Task<DomainResponse> Handle(DeleteConversationCommand command,CancellationToken cancellationToken) {
            var filter = ConversationFilters.GetFilters(command.Query);
			var entity = await _conversationRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(Conversation)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _conversationRepository.Delete(entity);

            var deleteResult = await OnDeleteAsync(entity);
            if (!deleteResult.Success) return deleteResult;

            entity.AddDomainEvent(new ConversationDeletedEvent(command.Context,entity));
            return await Commit(_conversationRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(DeleteRangeConversationCommand command,CancellationToken cancellationToken) {
            var filter = ConversationFilters.GetFilters(command.Query);
			var entities = await _conversationRepository.FindAllAsync(filter);

			_conversationRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_conversationRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(UpdateConversationCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeConversationCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<DomainResponse> Handle(UpdateRangeConversationCommand command,CancellationToken cancellationToken) {
            var entities = new List<Conversation>();
            foreach (var item in command.Query)
            {
                var entity = command.Entity as Conversation ?? await _conversationRepository.FindAsync(ConversationFilters.GetFilters(item.Key));
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateConversationCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(Conversation)} not found with the request.");
                }
                var entityAfter = item.Value.ProjectedAs<Conversation>();
                _conversationRepository.UnitOfWork.ResolveAttachesOnUpdate(entity, entityAfter);
                entity.Update(entityAfter,"Id");
                var updateResult = await OnUpdateAsync(entity, entityAfter);
                if (!updateResult.Success) return updateResult;
                entity.AddDomainEvent(new ConversationUpdatedEvent(command.Context, entity));
            }
            
            PublishLog(command);

            return await Commit(_conversationRepository.UnitOfWork, command.Entity.ProjectedAs<ConversationDTO>());
        }
         
        public async Task<DomainResponse> Handle(ActiveConversationCommand command,CancellationToken cancellationToken) {
            var conversation = await _conversationRepository.FindAsync(filter: ConversationFilters.GetFilters(command.Query));
            //conversation.Disable();

            PublishLog(command);
            
            return await Commit(_conversationRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(DeactiveConversationCommand command,CancellationToken cancellationToken) {
            var conversation = await _conversationRepository.FindAsync(filter: ConversationFilters.GetFilters(command.Query));
            //conversation.Enable();

            PublishLog(command);
            
            return await Commit(_conversationRepository.UnitOfWork);
        }
    }
    public partial class ChatAggSettingsCommandHandler : BaseChatAggCommandHandler<ChatAggSettings>,
        IRequestHandler<CreateChatAggSettingsCommand,DomainResponse>,
        IRequestHandler<DeleteRangeChatAggSettingsCommand,DomainResponse>,
        IRequestHandler<DeleteChatAggSettingsCommand,DomainResponse>,
        IRequestHandler<UpdateRangeChatAggSettingsCommand,DomainResponse>,
        IRequestHandler<UpdateChatAggSettingsCommand,DomainResponse>,
        IRequestHandler<ActiveChatAggSettingsCommand,DomainResponse>,
        IRequestHandler<DeactiveChatAggSettingsCommand,DomainResponse>
    {
        IChatAggSettingsRepository _chatAggSettingsRepository;

        public ChatAggSettingsCommandHandler(IServiceProvider provider,IMediator mediator,IChatAggSettingsRepository chatAggSettingsRepository ) : base(provider,mediator) { _chatAggSettingsRepository = chatAggSettingsRepository; }

        partial void OnCreate(ChatAggSettings entity);
        partial void OnUpdate(ChatAggSettings entity);

        public async Task<DomainResponse> Handle(CreateChatAggSettingsCommand command,CancellationToken cancellationToken) {

            ChatAggSettings entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = ChatAggSettingsFilters.GetFilters(command.Query ?? new ChatAggSettingsQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _chatAggSettingsRepository.FindAsync(filter, includeAll: false);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateChatAggSettingsCommand(
                            command.Context,
                            new Queries.Models.ChatAggSettingsQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.ChatAggSettings>();
            entity.AddDomainEvent(new ChatAggSettingsCreatedEvent(command.Context,entity));

            _chatAggSettingsRepository.UnitOfWork.ResolveAttaches(entity);
            var creationResult = await OnCreateAsync(entity);
            if (!creationResult.Success) return creationResult;
			_chatAggSettingsRepository.Add(entity);

            return await Commit(_chatAggSettingsRepository.UnitOfWork, entity.ProjectedAs<ChatAggSettingsDTO>());
        }

        public async Task<DomainResponse> Handle(DeleteChatAggSettingsCommand command,CancellationToken cancellationToken) {
            var filter = ChatAggSettingsFilters.GetFilters(command.Query);
			var entity = await _chatAggSettingsRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(ChatAggSettings)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _chatAggSettingsRepository.Delete(entity);

            var deleteResult = await OnDeleteAsync(entity);
            if (!deleteResult.Success) return deleteResult;

            entity.AddDomainEvent(new ChatAggSettingsDeletedEvent(command.Context,entity));
            return await Commit(_chatAggSettingsRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(DeleteRangeChatAggSettingsCommand command,CancellationToken cancellationToken) {
            var filter = ChatAggSettingsFilters.GetFilters(command.Query);
			var entities = await _chatAggSettingsRepository.FindAllAsync(filter);

			_chatAggSettingsRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_chatAggSettingsRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(UpdateChatAggSettingsCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeChatAggSettingsCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<DomainResponse> Handle(UpdateRangeChatAggSettingsCommand command,CancellationToken cancellationToken) {
            var entities = new List<ChatAggSettings>();
            foreach (var item in command.Query)
            {
                var entity = command.Entity as ChatAggSettings ?? await _chatAggSettingsRepository.FindAsync(ChatAggSettingsFilters.GetFilters(item.Key));
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateChatAggSettingsCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(ChatAggSettings)} not found with the request.");
                }
                var entityAfter = item.Value.ProjectedAs<ChatAggSettings>();
                _chatAggSettingsRepository.UnitOfWork.ResolveAttachesOnUpdate(entity, entityAfter);
                entity.Update(entityAfter,"Id");
                var updateResult = await OnUpdateAsync(entity, entityAfter);
                if (!updateResult.Success) return updateResult;
                entity.AddDomainEvent(new ChatAggSettingsUpdatedEvent(command.Context, entity));
            }
            
            PublishLog(command);

            return await Commit(_chatAggSettingsRepository.UnitOfWork, command.Entity.ProjectedAs<ChatAggSettingsDTO>());
        }
         
        public async Task<DomainResponse> Handle(ActiveChatAggSettingsCommand command,CancellationToken cancellationToken) {
            var chataggsettings = await _chatAggSettingsRepository.FindAsync(filter: ChatAggSettingsFilters.GetFilters(command.Query));
            //chataggsettings.Disable();

            PublishLog(command);
            
            return await Commit(_chatAggSettingsRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(DeactiveChatAggSettingsCommand command,CancellationToken cancellationToken) {
            var chataggsettings = await _chatAggSettingsRepository.FindAsync(filter: ChatAggSettingsFilters.GetFilters(command.Query));
            //chataggsettings.Enable();

            PublishLog(command);
            
            return await Commit(_chatAggSettingsRepository.UnitOfWork);
        }
    }
    public partial class ConversationMessageCommandHandler : BaseChatAggCommandHandler<ConversationMessage>,
        IRequestHandler<CreateConversationMessageCommand,DomainResponse>,
        IRequestHandler<DeleteRangeConversationMessageCommand,DomainResponse>,
        IRequestHandler<DeleteConversationMessageCommand,DomainResponse>,
        IRequestHandler<UpdateRangeConversationMessageCommand,DomainResponse>,
        IRequestHandler<UpdateConversationMessageCommand,DomainResponse>,
        IRequestHandler<ActiveConversationMessageCommand,DomainResponse>,
        IRequestHandler<DeactiveConversationMessageCommand,DomainResponse>
    {
        IConversationMessageRepository _conversationMessageRepository;

        public ConversationMessageCommandHandler(IServiceProvider provider,IMediator mediator,IConversationMessageRepository conversationMessageRepository ) : base(provider,mediator) { _conversationMessageRepository = conversationMessageRepository; }

        partial void OnCreate(ConversationMessage entity);
        partial void OnUpdate(ConversationMessage entity);

        public async Task<DomainResponse> Handle(CreateConversationMessageCommand command,CancellationToken cancellationToken) {

            ConversationMessage entity;
            if (command.Query != null || !string.IsNullOrWhiteSpace(command.Request.ExternalId))
            {
                var filter = ConversationMessageFilters.GetFilters(command.Query ?? new ConversationMessageQueryModel { ExternalIdEqual = command.Request.ExternalId });
                entity = await _conversationMessageRepository.FindAsync(filter, includeAll: false);
                if (entity != null)
                {
                    if (command.UpdateIfExists)
                        return await Handle(new UpdateConversationMessageCommand(
                            command.Context,
                            new Queries.Models.ConversationMessageQueryModel { ExternalIdEqual = command.Request.ExternalId },
                            command.Request),
                        cancellationToken);
                }
            }
            entity = command.Request.ProjectedAs<Entities.ConversationMessage>();
            entity.AddDomainEvent(new ConversationMessageCreatedEvent(command.Context,entity));

            _conversationMessageRepository.UnitOfWork.ResolveAttaches(entity);
            var creationResult = await OnCreateAsync(entity);
            if (!creationResult.Success) return creationResult;
			_conversationMessageRepository.Add(entity);

            return await Commit(_conversationMessageRepository.UnitOfWork, entity.ProjectedAs<ConversationMessageDTO>());
        }

        public async Task<DomainResponse> Handle(DeleteConversationMessageCommand command,CancellationToken cancellationToken) {
            var filter = ConversationMessageFilters.GetFilters(command.Query);
			var entity = await _conversationMessageRepository.FindAsync(filter);

            if(entity is null) {
                return AddError($"Entity {nameof(ConversationMessage)} not found with the request.");
            }
            
            if (command.IsLogicalDeletion)
                entity.Delete();
            else
			    _conversationMessageRepository.Delete(entity);

            var deleteResult = await OnDeleteAsync(entity);
            if (!deleteResult.Success) return deleteResult;

            entity.AddDomainEvent(new ConversationMessageDeletedEvent(command.Context,entity));
            return await Commit(_conversationMessageRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(DeleteRangeConversationMessageCommand command,CancellationToken cancellationToken) {
            var filter = ConversationMessageFilters.GetFilters(command.Query);
			var entities = await _conversationMessageRepository.FindAllAsync(filter);

			_conversationMessageRepository.DeleteRange(entities);

            PublishLog(command);
            
            return await Commit(_conversationMessageRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(UpdateConversationMessageCommand command,CancellationToken cancellationToken) {
            return await Handle(new UpdateRangeConversationMessageCommand(command.Context,command.Query,command.Request),cancellationToken);
        }

        public async Task<DomainResponse> Handle(UpdateRangeConversationMessageCommand command,CancellationToken cancellationToken) {
            var entities = new List<ConversationMessage>();
            foreach (var item in command.Query)
            {
                var entity = command.Entity as ConversationMessage ?? await _conversationMessageRepository.FindAsync(ConversationMessageFilters.GetFilters(item.Key));
                
                if(entity == null) {
                    if(command.CreateIfNotExists)
                        return await Handle(new CreateConversationMessageCommand(command.Context,item.Value),cancellationToken);
                    return AddError($"Entity {nameof(ConversationMessage)} not found with the request.");
                }
                var entityAfter = item.Value.ProjectedAs<ConversationMessage>();
                _conversationMessageRepository.UnitOfWork.ResolveAttachesOnUpdate(entity, entityAfter);
                entity.Update(entityAfter,"Id");
                var updateResult = await OnUpdateAsync(entity, entityAfter);
                if (!updateResult.Success) return updateResult;
                entity.AddDomainEvent(new ConversationMessageUpdatedEvent(command.Context, entity));
            }
            
            PublishLog(command);

            return await Commit(_conversationMessageRepository.UnitOfWork, command.Entity.ProjectedAs<ConversationMessageDTO>());
        }
         
        public async Task<DomainResponse> Handle(ActiveConversationMessageCommand command,CancellationToken cancellationToken) {
            var conversationmessage = await _conversationMessageRepository.FindAsync(filter: ConversationMessageFilters.GetFilters(command.Query));
            //conversationmessage.Disable();

            PublishLog(command);
            
            return await Commit(_conversationMessageRepository.UnitOfWork);
        }

        public async Task<DomainResponse> Handle(DeactiveConversationMessageCommand command,CancellationToken cancellationToken) {
            var conversationmessage = await _conversationMessageRepository.FindAsync(filter: ConversationMessageFilters.GetFilters(command.Query));
            //conversationmessage.Enable();

            PublishLog(command);
            
            return await Commit(_conversationMessageRepository.UnitOfWork);
        }
    }
}
