using Niu.Nutri.Core.Domain.CrossCutting;

namespace Niu.Nutri.Chat.Application.Aggregates.ChatAgg.AppServices
{
    public partial interface IConversationAppService
    {
        Task<DomainResponse> SetMessagesToRead(int conversationId, int userId);
    }
}
