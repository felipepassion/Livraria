        
namespace Niu.Nutri.Chat.Domain.Aggregates.ChatAgg.CommandHandlers {
    using Entities;
    using Microsoft.AspNetCore.SignalR;
    using Microsoft.Extensions.DependencyInjection;
    using Niu.Nutri.Chat.Api.Hubs.Hubs;
    using Niu.Nutri.Chat.Application.DTO.Aggregates.ChatAgg.Requests;
    using Niu.Nutri.Chat.Domain.Aggregates.ChatAgg.Repositories;
    using Niu.Nutri.Core.Application.DTO.Extensions;
    using Niu.Nutri.Core.Domain.CrossCutting;
    using System.Threading.Tasks;

    public partial class ConversationMessageCommandHandler : BaseChatAggCommandHandler<ConversationMessage>
	{
        public async override Task<DomainResponse> OnCreateAsync(ConversationMessage entity)
        {
            entity.Status = Enumerations.MessageStatus.Sent;

            var hubContext = _serviceProvider.GetRequiredService<IHubContext<ChatHub>>();
            var conversationRepo = _serviceProvider.GetRequiredService<IConversationRepository>();
            var conversation = await conversationRepo.FindAsync(x=>x.Id == entity.ConversationId);

            //await hubContext.Clients.Group(conversation.ExternalId).SendAsync("ReceiveIndividualMessage", entity.ProjectedAs<ConversationMessageDTO>());

            return await base.OnCreateAsync(entity);
        }

        public override Task<DomainResponse> OnDeleteAsync(ConversationMessage entity)
        {
            entity.Status = Enumerations.MessageStatus.Deleted;
            return base.OnDeleteAsync(entity);
        }
    }
}
