        
namespace Niu.Nutri.Chat.Application.DTO.Aggregates.ChatAgg.Validators {
    using Requests;
    public partial class ConversationMessageStep1Validator : BaseChatAggValidator<ConversationMessageDTO>
	{
        partial void ConfigureAdditionalValidations() {}
    }
}
