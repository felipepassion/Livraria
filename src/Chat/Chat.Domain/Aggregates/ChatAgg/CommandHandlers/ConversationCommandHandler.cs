        
namespace Niu.Nutri.Chat.Domain.Aggregates.ChatAgg.CommandHandlers {
    using Entities;
    using Microsoft.AspNetCore.SignalR;
    using Microsoft.Extensions.DependencyInjection;
    using Niu.Nutri.Chat.Api.Hubs.Hubs;
    using Niu.Nutri.Chat.Application.DTO.Aggregates.ChatAgg.Requests;
    using Niu.Nutri.Core.Application.DTO.Extensions;

    public partial class ConversationCommandHandler : BaseChatAggCommandHandler<Conversation>
	{
        partial void OnCreate(Conversation entity)
        {
            var hubContext = _serviceProvider.GetRequiredService<IHubContext<ChatHub>>();

            hubContext.Clients.Group(entity.ExternalId).SendAsync("ReceiveIndividualMessage", entity.ProjectedAs<ConversationDTO>());
        }
    }
}
