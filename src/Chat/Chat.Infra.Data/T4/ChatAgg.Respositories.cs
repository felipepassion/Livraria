using Microsoft.Extensions.Configuration;
using Niu.Nutri.Core.Infra.Data.Repositories;
using Niu.Nutri.Chat.Infra.Data.Context;

using Niu.Nutri.Chat.Domain.Aggregates.ChatAgg.Entities;

namespace Niu.Nutri.Chat.Infra.Data.Aggregates.ChatAgg.Repositories
{
	using Niu.Nutri.Chat.Domain.Aggregates.ChatAgg.Repositories;
	public partial class ConversationRepository : Repository<Conversation>, IConversationRepository { public ConversationRepository(ChatAggContext ctx) : base(ctx) { } }

	public partial class ChatAggSettingsRepository : Repository<ChatAggSettings>, IChatAggSettingsRepository { public ChatAggSettingsRepository(ChatAggContext ctx) : base(ctx) { } }

	public partial class ConversationMessageRepository : Repository<ConversationMessage>, IConversationMessageRepository { public ConversationMessageRepository(ChatAggContext ctx) : base(ctx) { } }

}
