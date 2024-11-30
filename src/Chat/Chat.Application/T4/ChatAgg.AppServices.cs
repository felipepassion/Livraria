
using MediatR;
using System.Linq.Expressions;
using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;
using Niu.Nutri.Core.Application.DTO.Extensions;
using Niu.Nutri.Core.Application.Aggregates.Common;
using Niu.Nutri.Core.Domain.CrossCutting;

namespace Niu.Nutri.Chat.Application.Aggregates.ChatAgg.AppServices {
	using Application.DTO.Aggregates.ChatAgg.Requests;
	using Domain.Aggregates.ChatAgg.Queries.Models;
	using Domain.Aggregates.ChatAgg.Repositories;
	using Domain.Aggregates.ChatAgg.Filters;
	using Domain.Aggregates.ChatAgg.Entities;
	using Domain.Aggregates.ChatAgg.CommandModels;
	public partial class ConversationAppService : BaseAppService, IConversationAppService {	
		public IConversationRepository _conversationRepository;
		public ConversationAppService(IMediator mediator, Niu.Nutri.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IConversationRepository conversationRepository) : base(ctx, mediator) { _conversationRepository = conversationRepository; }	
		public async Task<ConversationDTO> Get(ConversationQueryModel request) {
            return (await _conversationRepository.FindAsync(filter: ConversationFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification), selector: x => x.ProjectedAs<ConversationDTO>()));
        }
		public void Dispose()
        {
			_conversationRepository = null;
        }
		public async Task<IEnumerable<T>> GetAll<T>(ConversationQueryModel request, int? page = null, int? size = null, Expression<Func<Conversation, T>> selector = null) {
			return await _conversationRepository.SelectAllAsync(
                filter: ConversationFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Conversation>(),
                selector: selector);
		}
		public async Task<T> Select<T>(ConversationQueryModel request, Expression<Func<Conversation, T>> selector = null)
        {
            return (await _conversationRepository.FindAsync(filter: ConversationFilters.GetFilters(request, isOrSpecification: true), selector: selector));
        }
        public async Task<IEnumerable<ConversationDTO>> GetAll(ConversationQueryModel request, int? page = null, int? size = null) {
            return await _conversationRepository.FindAllAsync(
                filter: ConversationFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Conversation>(),
                selector: x => x.ProjectedAs<ConversationDTO>());
        }
		public async Task<IEnumerable<ConversationListiningDTO>> GetAllSummary(ConversationQueryModel request, int? page = null, int? size = null)
        {
            return await _conversationRepository.FindAllAsync(
                filter: ConversationFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<Conversation>(),
                selector: x => x.ProjectedAs<ConversationListiningDTO>());
        }

		public Task<DomainResponse> Create(ConversationDTO request, bool updateIfExists = true, ConversationQueryModel searchQuery = null) { return _mediator.Send(new CreateConversationCommand(_logRequestContext, request)); }
		public async Task<int> CountAsync(ConversationQueryModel request) { return await _conversationRepository.CountAsync(filter: ConversationFilters.GetFilters(request, isOrSpecification: true)); }
		public Task Update(ConversationQueryModel searchQuery, ConversationDTO request, bool createIfNotExists = true) { return _mediator.Send(new UpdateConversationCommand(_logRequestContext, searchQuery, request)); }
		public Task<DomainResponse> DeleteRange(ConversationQueryModel request){ return _mediator.Send(new DeleteRangeConversationCommand(_logRequestContext, request)); }
		public Task<DomainResponse> Delete(ConversationQueryModel request){ return _mediator.Send(new DeleteConversationCommand(_logRequestContext, request)); }
	}
	public partial class ChatAggSettingsAppService : BaseAppService, IChatAggSettingsAppService {	
		public IChatAggSettingsRepository _chatAggSettingsRepository;
		public ChatAggSettingsAppService(IMediator mediator, Niu.Nutri.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IChatAggSettingsRepository chatAggSettingsRepository) : base(ctx, mediator) { _chatAggSettingsRepository = chatAggSettingsRepository; }	
		public async Task<ChatAggSettingsDTO> Get(ChatAggSettingsQueryModel request) {
            return (await _chatAggSettingsRepository.FindAsync(filter: ChatAggSettingsFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification), selector: x => x.ProjectedAs<ChatAggSettingsDTO>()));
        }
		public void Dispose()
        {
			_chatAggSettingsRepository = null;
        }
		public async Task<IEnumerable<T>> GetAll<T>(ChatAggSettingsQueryModel request, int? page = null, int? size = null, Expression<Func<ChatAggSettings, T>> selector = null) {
			return await _chatAggSettingsRepository.SelectAllAsync(
                filter: ChatAggSettingsFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<ChatAggSettings>(),
                selector: selector);
		}
		public async Task<T> Select<T>(ChatAggSettingsQueryModel request, Expression<Func<ChatAggSettings, T>> selector = null)
        {
            return (await _chatAggSettingsRepository.FindAsync(filter: ChatAggSettingsFilters.GetFilters(request, isOrSpecification: true), selector: selector));
        }
        public async Task<IEnumerable<ChatAggSettingsDTO>> GetAll(ChatAggSettingsQueryModel request, int? page = null, int? size = null) {
            return await _chatAggSettingsRepository.FindAllAsync(
                filter: ChatAggSettingsFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<ChatAggSettings>(),
                selector: x => x.ProjectedAs<ChatAggSettingsDTO>());
        }
		public async Task<IEnumerable<ChatAggSettingsListiningDTO>> GetAllSummary(ChatAggSettingsQueryModel request, int? page = null, int? size = null)
        {
            return await _chatAggSettingsRepository.FindAllAsync(
                filter: ChatAggSettingsFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<ChatAggSettings>(),
                selector: x => x.ProjectedAs<ChatAggSettingsListiningDTO>());
        }

		public Task<DomainResponse> Create(ChatAggSettingsDTO request, bool updateIfExists = true, ChatAggSettingsQueryModel searchQuery = null) { return _mediator.Send(new CreateChatAggSettingsCommand(_logRequestContext, request)); }
		public async Task<int> CountAsync(ChatAggSettingsQueryModel request) { return await _chatAggSettingsRepository.CountAsync(filter: ChatAggSettingsFilters.GetFilters(request, isOrSpecification: true)); }
		public Task Update(ChatAggSettingsQueryModel searchQuery, ChatAggSettingsDTO request, bool createIfNotExists = true) { return _mediator.Send(new UpdateChatAggSettingsCommand(_logRequestContext, searchQuery, request)); }
		public Task<DomainResponse> DeleteRange(ChatAggSettingsQueryModel request){ return _mediator.Send(new DeleteRangeChatAggSettingsCommand(_logRequestContext, request)); }
		public Task<DomainResponse> Delete(ChatAggSettingsQueryModel request){ return _mediator.Send(new DeleteChatAggSettingsCommand(_logRequestContext, request)); }
	}
	public partial class ConversationMessageAppService : BaseAppService, IConversationMessageAppService {	
		public IConversationMessageRepository _conversationMessageRepository;
		public ConversationMessageAppService(IMediator mediator, Niu.Nutri.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IConversationMessageRepository conversationMessageRepository) : base(ctx, mediator) { _conversationMessageRepository = conversationMessageRepository; }	
		public async Task<ConversationMessageDTO> Get(ConversationMessageQueryModel request) {
            return (await _conversationMessageRepository.FindAsync(filter: ConversationMessageFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification), selector: x => x.ProjectedAs<ConversationMessageDTO>()));
        }
		public void Dispose()
        {
			_conversationMessageRepository = null;
        }
		public async Task<IEnumerable<T>> GetAll<T>(ConversationMessageQueryModel request, int? page = null, int? size = null, Expression<Func<ConversationMessage, T>> selector = null) {
			return await _conversationMessageRepository.SelectAllAsync(
                filter: ConversationMessageFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<ConversationMessage>(),
                selector: selector);
		}
		public async Task<T> Select<T>(ConversationMessageQueryModel request, Expression<Func<ConversationMessage, T>> selector = null)
        {
            return (await _conversationMessageRepository.FindAsync(filter: ConversationMessageFilters.GetFilters(request, isOrSpecification: true), selector: selector));
        }
        public async Task<IEnumerable<ConversationMessageDTO>> GetAll(ConversationMessageQueryModel request, int? page = null, int? size = null) {
            return await _conversationMessageRepository.FindAllAsync(
                filter: ConversationMessageFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<ConversationMessage>(),
                selector: x => x.ProjectedAs<ConversationMessageDTO>());
        }
		public async Task<IEnumerable<ConversationMessageListiningDTO>> GetAllSummary(ConversationMessageQueryModel request, int? page = null, int? size = null)
        {
            return await _conversationMessageRepository.FindAllAsync(
                filter: ConversationMessageFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<ConversationMessage>(),
                selector: x => x.ProjectedAs<ConversationMessageListiningDTO>());
        }

		public Task<DomainResponse> Create(ConversationMessageDTO request, bool updateIfExists = true, ConversationMessageQueryModel searchQuery = null) { return _mediator.Send(new CreateConversationMessageCommand(_logRequestContext, request)); }
		public async Task<int> CountAsync(ConversationMessageQueryModel request) { return await _conversationMessageRepository.CountAsync(filter: ConversationMessageFilters.GetFilters(request, isOrSpecification: true)); }
		public Task Update(ConversationMessageQueryModel searchQuery, ConversationMessageDTO request, bool createIfNotExists = true) { return _mediator.Send(new UpdateConversationMessageCommand(_logRequestContext, searchQuery, request)); }
		public Task<DomainResponse> DeleteRange(ConversationMessageQueryModel request){ return _mediator.Send(new DeleteRangeConversationMessageCommand(_logRequestContext, request)); }
		public Task<DomainResponse> Delete(ConversationMessageQueryModel request){ return _mediator.Send(new DeleteConversationMessageCommand(_logRequestContext, request)); }
	}
}
