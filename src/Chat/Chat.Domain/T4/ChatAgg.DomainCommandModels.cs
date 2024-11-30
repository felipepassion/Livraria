using Niu.Nutri.CrossCutting.Infra.Log.Contexts;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Commands;
namespace Niu.Nutri.Chat.Domain.Aggregates.ChatAgg.CommandModels
{
    using Queries.Models; 
    using Niu.Nutri.Chat.Application.DTO.Aggregates.ChatAgg.Requests; 
    public partial class CreateConversationCommand : BaseRequestableCommand<ConversationQueryModel, ConversationDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreateConversationCommand(ILogRequestContext ctx, ConversationDTO data, bool updateIfExists = true, ConversationQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeleteConversationCommand : BaseDeletionCommand<ConversationQueryModel>
    {
        public DeleteConversationCommand(ILogRequestContext ctx, ConversationQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangeConversationCommand : BaseDeletionCommand<ConversationQueryModel>
    {
        public DeleteRangeConversationCommand(ILogRequestContext ctx, ConversationQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangeConversationCommand : BaseRequestableRangeCommand<ConversationQueryModel, ConversationDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangeConversationCommand(ILogRequestContext ctx, Dictionary<ConversationQueryModel, ConversationDTO> query)
            : base(ctx, query) { }
        public UpdateRangeConversationCommand(ILogRequestContext ctx, ConversationQueryModel query, ConversationDTO data)
            : base(ctx, new Dictionary<ConversationQueryModel, ConversationDTO> { { query, data } }) { }
    }
    
    public partial class UpdateConversationCommand : BaseRequestableCommand<ConversationQueryModel, ConversationDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateConversationCommand(ILogRequestContext ctx, ConversationQueryModel query, ConversationDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActiveConversationCommand : ConversationSearchableCommand
    {
        public ActiveConversationCommand(ILogRequestContext ctx, ConversationQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactiveConversationCommand : ConversationSearchableCommand
    {
        public DeactiveConversationCommand(ILogRequestContext ctx, ConversationQueryModel query)
            : base(ctx, query) { }
    }
    public class ConversationSearchableCommand : BaseSearchableCommand<ConversationQueryModel> {
        public ConversationSearchableCommand(ILogRequestContext ctx, ConversationQueryModel query)
            : base(ctx, query) { }
    }

    public partial class CreateChatAggSettingsCommand : BaseRequestableCommand<ChatAggSettingsQueryModel, ChatAggSettingsDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreateChatAggSettingsCommand(ILogRequestContext ctx, ChatAggSettingsDTO data, bool updateIfExists = true, ChatAggSettingsQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeleteChatAggSettingsCommand : BaseDeletionCommand<ChatAggSettingsQueryModel>
    {
        public DeleteChatAggSettingsCommand(ILogRequestContext ctx, ChatAggSettingsQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangeChatAggSettingsCommand : BaseDeletionCommand<ChatAggSettingsQueryModel>
    {
        public DeleteRangeChatAggSettingsCommand(ILogRequestContext ctx, ChatAggSettingsQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangeChatAggSettingsCommand : BaseRequestableRangeCommand<ChatAggSettingsQueryModel, ChatAggSettingsDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangeChatAggSettingsCommand(ILogRequestContext ctx, Dictionary<ChatAggSettingsQueryModel, ChatAggSettingsDTO> query)
            : base(ctx, query) { }
        public UpdateRangeChatAggSettingsCommand(ILogRequestContext ctx, ChatAggSettingsQueryModel query, ChatAggSettingsDTO data)
            : base(ctx, new Dictionary<ChatAggSettingsQueryModel, ChatAggSettingsDTO> { { query, data } }) { }
    }
    
    public partial class UpdateChatAggSettingsCommand : BaseRequestableCommand<ChatAggSettingsQueryModel, ChatAggSettingsDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateChatAggSettingsCommand(ILogRequestContext ctx, ChatAggSettingsQueryModel query, ChatAggSettingsDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActiveChatAggSettingsCommand : ChatAggSettingsSearchableCommand
    {
        public ActiveChatAggSettingsCommand(ILogRequestContext ctx, ChatAggSettingsQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactiveChatAggSettingsCommand : ChatAggSettingsSearchableCommand
    {
        public DeactiveChatAggSettingsCommand(ILogRequestContext ctx, ChatAggSettingsQueryModel query)
            : base(ctx, query) { }
    }
    public class ChatAggSettingsSearchableCommand : BaseSearchableCommand<ChatAggSettingsQueryModel> {
        public ChatAggSettingsSearchableCommand(ILogRequestContext ctx, ChatAggSettingsQueryModel query)
            : base(ctx, query) { }
    }

    public partial class CreateConversationMessageCommand : BaseRequestableCommand<ConversationMessageQueryModel, ConversationMessageDTO>
    {
        public bool UpdateIfExists { get; set; }
        public CreateConversationMessageCommand(ILogRequestContext ctx, ConversationMessageDTO data, bool updateIfExists = true, ConversationMessageQueryModel query = null) 
            : base(ctx, query, data) { this.UpdateIfExists = updateIfExists; }
    }
    public partial class DeleteConversationMessageCommand : BaseDeletionCommand<ConversationMessageQueryModel>
    {
        public DeleteConversationMessageCommand(ILogRequestContext ctx, ConversationMessageQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
      public partial class DeleteRangeConversationMessageCommand : BaseDeletionCommand<ConversationMessageQueryModel>
    {
        public DeleteRangeConversationMessageCommand(ILogRequestContext ctx, ConversationMessageQueryModel query, bool isLogicalDeletion = true)
            : base(ctx, query, isLogicalDeletion) { }
    }
    public partial class UpdateRangeConversationMessageCommand : BaseRequestableRangeCommand<ConversationMessageQueryModel, ConversationMessageDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateRangeConversationMessageCommand(ILogRequestContext ctx, Dictionary<ConversationMessageQueryModel, ConversationMessageDTO> query)
            : base(ctx, query) { }
        public UpdateRangeConversationMessageCommand(ILogRequestContext ctx, ConversationMessageQueryModel query, ConversationMessageDTO data)
            : base(ctx, new Dictionary<ConversationMessageQueryModel, ConversationMessageDTO> { { query, data } }) { }
    }
    
    public partial class UpdateConversationMessageCommand : BaseRequestableCommand<ConversationMessageQueryModel, ConversationMessageDTO>
    {
        public bool CreateIfNotExists { get; set; } = true;
        public UpdateConversationMessageCommand(ILogRequestContext ctx, ConversationMessageQueryModel query, ConversationMessageDTO data, bool createIfNotExists = true)
            : base(ctx, query, data) { this.CreateIfNotExists = createIfNotExists; }
    }
    public partial class ActiveConversationMessageCommand : ConversationMessageSearchableCommand
    {
        public ActiveConversationMessageCommand(ILogRequestContext ctx, ConversationMessageQueryModel query)
            : base(ctx, query) { }
    }
    public partial class DeactiveConversationMessageCommand : ConversationMessageSearchableCommand
    {
        public DeactiveConversationMessageCommand(ILogRequestContext ctx, ConversationMessageQueryModel query)
            : base(ctx, query) { }
    }
    public class ConversationMessageSearchableCommand : BaseSearchableCommand<ConversationMessageQueryModel> {
        public ConversationMessageSearchableCommand(ILogRequestContext ctx, ConversationMessageQueryModel query)
            : base(ctx, query) { }
    }

}
