using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
namespace Niu.Nutri.Chat.Application.DTO.Aggregates.ChatAgg.Validators {
    public class BaseChatAggValidator<T> : BaseValidator<T>
        where T : EntityDTO
    {
            public BaseChatAggValidator() : base(){ }
            public BaseChatAggValidator(HttpClient db) : base(db){ }
    }
}
namespace Niu.Nutri.Chat.Application.DTO.Aggregates.ChatAgg.Validators 
{
	using Requests;
    public partial class ConversationStep1Validator : BaseChatAggValidator<ConversationDTO>
	{
        public ConversationStep1Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(Q => Q.FromId).NotEmpty();RuleFor(Q => Q.ToId).NotEmpty();
            ConfigureAdditionalValidations();
        }
        partial void ConfigureAdditionalValidations();
    }
    public partial class ChatAggSettingsStep1Validator : BaseChatAggValidator<ChatAggSettingsDTO>
	{
        public ChatAggSettingsStep1Validator(HttpClient db)
                    : base(db)
        {
            RuleFor(Q => Q.UserId).NotEmpty();
            ConfigureAdditionalValidations();
        }
        partial void ConfigureAdditionalValidations();
    }
    public partial class ConversationMessageStep1Validator : BaseChatAggValidator<ConversationMessageDTO>
	{
        public ConversationMessageStep1Validator(HttpClient db)
                    : base(db)
        {
            
            ConfigureAdditionalValidations();
        }
        partial void ConfigureAdditionalValidations();
    }
}
