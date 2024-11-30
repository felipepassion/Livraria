using MediatR;
using Niu.Nutri.Core.Domain.Extensions;
using Niu.Nutri.CrossCutting.Infra.Log.Providers;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Events.Handles;
using Niu.Nutri.Chat.Domain.Aggregates.ChatAgg.ModelEvents;

namespace Niu.Nutri.Chat.Domain.Aggregates.ChatAgg.EventHandlers
{
    public partial class ConversationEventHandler : BaseEventHandler,
        INotificationHandler<ConversationCreatedEvent>,
        INotificationHandler<ConversationDeletedEvent>,
        INotificationHandler<ConversationUpdatedEvent>,
        INotificationHandler<ConversationActivatedEvent>,
        INotificationHandler<ConversationDeactivatedEvent>{
        public ConversationEventHandler(ILogProvider logProvider, IServiceProvider serviceProvider):base(logProvider, serviceProvider){}
        public async Task Handle(ConversationCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ConversationDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ConversationActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ConversationUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ConversationDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    }
    public partial class ChatAggSettingsEventHandler : BaseEventHandler,
        INotificationHandler<ChatAggSettingsCreatedEvent>,
        INotificationHandler<ChatAggSettingsDeletedEvent>,
        INotificationHandler<ChatAggSettingsUpdatedEvent>,
        INotificationHandler<ChatAggSettingsActivatedEvent>,
        INotificationHandler<ChatAggSettingsDeactivatedEvent>{
        public ChatAggSettingsEventHandler(ILogProvider logProvider, IServiceProvider serviceProvider):base(logProvider, serviceProvider){}
        public async Task Handle(ChatAggSettingsCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ChatAggSettingsDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ChatAggSettingsActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ChatAggSettingsUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ChatAggSettingsDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    }
    public partial class ConversationMessageEventHandler : BaseEventHandler,
        INotificationHandler<ConversationMessageCreatedEvent>,
        INotificationHandler<ConversationMessageDeletedEvent>,
        INotificationHandler<ConversationMessageUpdatedEvent>,
        INotificationHandler<ConversationMessageActivatedEvent>,
        INotificationHandler<ConversationMessageDeactivatedEvent>{
        public ConversationMessageEventHandler(ILogProvider logProvider, IServiceProvider serviceProvider):base(logProvider, serviceProvider){}
        public async Task Handle(ConversationMessageCreatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ConversationMessageDeletedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ConversationMessageActivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ConversationMessageUpdatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
        public async Task Handle(ConversationMessageDeactivatedEvent notification, CancellationToken cancellationToken){PublishLog(notification);}
    }
}
