using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Events;
using Niu.Nutri.CrossCutting.Infra.Log.Contexts;

namespace Niu.Nutri.Chat.Domain.Aggregates.ChatAgg.ModelEvents
{
    using ModelEvents;
    using Entities;
    public partial class ConversationCreatedEvent : BaseEvent
    {
        public ConversationCreatedEvent(ILogRequestContext ctx, Conversation data) 
            : base(ctx, data) { }
    }
    public partial class ConversationDeletedEvent : BaseEvent
    {
        public ConversationDeletedEvent(ILogRequestContext ctx, Conversation data) 
            : base(ctx, data) { }
    }
    public partial class ConversationDeletedRangeEvent : BaseEvent
    {
        public ConversationDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<Conversation> data) 
            : base(ctx, data) { }
    }
    public partial class ConversationActivatedEvent : BaseEvent
    {
        public ConversationActivatedEvent(ILogRequestContext ctx, Conversation data) 
            : base(ctx, data) { }
    }
    public partial class ConversationUpdatedEvent : BaseEvent
    {
        public ConversationUpdatedEvent(ILogRequestContext ctx, Conversation data) 
            : base(ctx, data) { }
    }
    public partial class ConversationUpdatedRangeEvent : BaseEvent
    {
        public ConversationUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<Conversation> data) 
            : base(ctx, data) { }
    }
    public partial class ConversationDeactivatedEvent : BaseEvent
    {
        public ConversationDeactivatedEvent(ILogRequestContext ctx, Conversation data) 
            : base(ctx, data) { }
    }
    public partial class ChatAggSettingsCreatedEvent : BaseEvent
    {
        public ChatAggSettingsCreatedEvent(ILogRequestContext ctx, ChatAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class ChatAggSettingsDeletedEvent : BaseEvent
    {
        public ChatAggSettingsDeletedEvent(ILogRequestContext ctx, ChatAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class ChatAggSettingsDeletedRangeEvent : BaseEvent
    {
        public ChatAggSettingsDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<ChatAggSettings> data) 
            : base(ctx, data) { }
    }
    public partial class ChatAggSettingsActivatedEvent : BaseEvent
    {
        public ChatAggSettingsActivatedEvent(ILogRequestContext ctx, ChatAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class ChatAggSettingsUpdatedEvent : BaseEvent
    {
        public ChatAggSettingsUpdatedEvent(ILogRequestContext ctx, ChatAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class ChatAggSettingsUpdatedRangeEvent : BaseEvent
    {
        public ChatAggSettingsUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<ChatAggSettings> data) 
            : base(ctx, data) { }
    }
    public partial class ChatAggSettingsDeactivatedEvent : BaseEvent
    {
        public ChatAggSettingsDeactivatedEvent(ILogRequestContext ctx, ChatAggSettings data) 
            : base(ctx, data) { }
    }
    public partial class ConversationMessageCreatedEvent : BaseEvent
    {
        public ConversationMessageCreatedEvent(ILogRequestContext ctx, ConversationMessage data) 
            : base(ctx, data) { }
    }
    public partial class ConversationMessageDeletedEvent : BaseEvent
    {
        public ConversationMessageDeletedEvent(ILogRequestContext ctx, ConversationMessage data) 
            : base(ctx, data) { }
    }
    public partial class ConversationMessageDeletedRangeEvent : BaseEvent
    {
        public ConversationMessageDeletedRangeEvent(ILogRequestContext ctx, IEnumerable<ConversationMessage> data) 
            : base(ctx, data) { }
    }
    public partial class ConversationMessageActivatedEvent : BaseEvent
    {
        public ConversationMessageActivatedEvent(ILogRequestContext ctx, ConversationMessage data) 
            : base(ctx, data) { }
    }
    public partial class ConversationMessageUpdatedEvent : BaseEvent
    {
        public ConversationMessageUpdatedEvent(ILogRequestContext ctx, ConversationMessage data) 
            : base(ctx, data) { }
    }
    public partial class ConversationMessageUpdatedRangeEvent : BaseEvent
    {
        public ConversationMessageUpdatedRangeEvent(ILogRequestContext ctx, IEnumerable<ConversationMessage> data) 
            : base(ctx, data) { }
    }
    public partial class ConversationMessageDeactivatedEvent : BaseEvent
    {
        public ConversationMessageDeactivatedEvent(ILogRequestContext ctx, ConversationMessage data) 
            : base(ctx, data) { }
    }
}
