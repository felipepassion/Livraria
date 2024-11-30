using System.Linq.Expressions;
using Niu.Nutri.Core.Domain.CrossCutting;
using Niu.Nutri.Core.Application.Aggregates.Common;

namespace Niu.Nutri.Chat.Application.Aggregates.ChatAgg.AppServices {
	using Application.DTO.Aggregates.ChatAgg.Requests;
    using Domain.Aggregates.ChatAgg.Queries.Models;
	public partial interface IConversationAppService : IBaseAppService {	
		public Task<ConversationDTO> Get(ConversationQueryModel request);
		public Task<int> CountAsync(ConversationQueryModel request);
		public Task<IEnumerable<ConversationDTO>> GetAll(ConversationQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(ConversationQueryModel request, Expression<Func<Domain.Aggregates.ChatAgg.Entities.Conversation, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(ConversationQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.ChatAgg.Entities.Conversation, T>> selector = null);
		public Task<IEnumerable<ConversationListiningDTO>> GetAllSummary(ConversationQueryModel request, int? page = null, int? size = null);

		public Task<DomainResponse> Create(ConversationDTO request, bool updateIfExists = true, ConversationQueryModel searchQuery = null);
		public Task<DomainResponse> Delete(ConversationQueryModel request);
		public Task<DomainResponse> DeleteRange(ConversationQueryModel request);
		public Task Update(ConversationQueryModel searchQuery, ConversationDTO request, bool createIfNotExists = true);
	}
	public partial interface IChatAggSettingsAppService : IBaseAppService {	
		public Task<ChatAggSettingsDTO> Get(ChatAggSettingsQueryModel request);
		public Task<int> CountAsync(ChatAggSettingsQueryModel request);
		public Task<IEnumerable<ChatAggSettingsDTO>> GetAll(ChatAggSettingsQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(ChatAggSettingsQueryModel request, Expression<Func<Domain.Aggregates.ChatAgg.Entities.ChatAggSettings, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(ChatAggSettingsQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.ChatAgg.Entities.ChatAggSettings, T>> selector = null);
		public Task<IEnumerable<ChatAggSettingsListiningDTO>> GetAllSummary(ChatAggSettingsQueryModel request, int? page = null, int? size = null);

		public Task<DomainResponse> Create(ChatAggSettingsDTO request, bool updateIfExists = true, ChatAggSettingsQueryModel searchQuery = null);
		public Task<DomainResponse> Delete(ChatAggSettingsQueryModel request);
		public Task<DomainResponse> DeleteRange(ChatAggSettingsQueryModel request);
		public Task Update(ChatAggSettingsQueryModel searchQuery, ChatAggSettingsDTO request, bool createIfNotExists = true);
	}
	public partial interface IConversationMessageAppService : IBaseAppService {	
		public Task<ConversationMessageDTO> Get(ConversationMessageQueryModel request);
		public Task<int> CountAsync(ConversationMessageQueryModel request);
		public Task<IEnumerable<ConversationMessageDTO>> GetAll(ConversationMessageQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(ConversationMessageQueryModel request, Expression<Func<Domain.Aggregates.ChatAgg.Entities.ConversationMessage, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(ConversationMessageQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.ChatAgg.Entities.ConversationMessage, T>> selector = null);
		public Task<IEnumerable<ConversationMessageListiningDTO>> GetAllSummary(ConversationMessageQueryModel request, int? page = null, int? size = null);

		public Task<DomainResponse> Create(ConversationMessageDTO request, bool updateIfExists = true, ConversationMessageQueryModel searchQuery = null);
		public Task<DomainResponse> Delete(ConversationMessageQueryModel request);
		public Task<DomainResponse> DeleteRange(ConversationMessageQueryModel request);
		public Task Update(ConversationMessageQueryModel searchQuery, ConversationMessageDTO request, bool createIfNotExists = true);
	}
}
