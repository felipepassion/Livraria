using Niu.Nutri.Chat.Enumerations;
using Niu.Nutri.Core.Domain.CrossCutting;
using Niu.Nutri.Core.Domain.Seedwork;

namespace Niu.Nutri.Chat.Application.Aggregates.ChatAgg.AppServices
{
    public partial class ConversationAppService : IConversationAppService
    {
        public async Task<DomainResponse> SetMessagesToRead(int conversationId, int userId)
        {
            var conversation = await _conversationRepository.FindAsync(c => c.Id == conversationId);

            var notReadMessages = conversation.Messages
                .Where(m => m.Status != MessageStatus.Read &&
                       m.Status != MessageStatus.Deleted &&
                       m.FromId != userId)
                .ToList();

            foreach (var message in notReadMessages)
            {
                message.Status = MessageStatus.Read;
            }

            _conversationRepository.Update(conversation);
            await _conversationRepository.UnitOfWork.CommitAsync();

            return DomainResponse.Ok();
        }
    }
}
