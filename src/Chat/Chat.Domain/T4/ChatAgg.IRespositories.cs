using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Repositories;
using Niu.Nutri.Chat.Domain.Aggregates.ChatAgg.Entities;
using Niu.Nutri.Chat.Domain.Aggregates.UsersAgg.Entities;

namespace Niu.Nutri.Chat.Domain.Aggregates.ChatAgg.Repositories 
{
	public partial interface IConversationRepository : IRepository<Conversation> { }
	public partial interface IConversationMongoRepository : IMongoRepository<Conversation> { }

	public partial interface IChatAggSettingsRepository : IRepository<ChatAggSettings> { }
	public partial interface IChatAggSettingsMongoRepository : IMongoRepository<ChatAggSettings> { }

	public partial interface IConversationMessageRepository : IRepository<ConversationMessage> { }
	public partial interface IConversationMessageMongoRepository : IMongoRepository<ConversationMessage> { }

}
namespace Niu.Nutri.Chat.Domain.Aggregates.UsersAgg.Repositories 
{
	public partial interface IUserRepository : IRepository<User> { }
	public partial interface IUserMongoRepository : IMongoRepository<User> { }

}
