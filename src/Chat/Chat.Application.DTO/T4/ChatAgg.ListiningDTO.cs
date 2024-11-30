using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
using Niu.Nutri.Core.Application.DTO.Attributes;
namespace Niu.Nutri.Chat.Application.DTO.Aggregates.ChatAgg.Requests 
{
	using Requests;
    public partial class ConversationListiningDTO : SteppableEntityDTO
	{
         [DisplayOnList,DisplayName("")] public  string? FromAvatar { get; set; }[DisplayOnList,DisplayName("Remetente")] public  string? FromName { get; set; }[DisplayOnList,DisplayName("Qtd Mensagens")] public  int? MessagesCount { get; set; }[DisplayOnList,DisplayName("Mensagens N�o Lidas")] public int? NotReadMessagesCount { get; set; }      }
    public partial class ChatAggSettingsListiningDTO : EntityDTO
	{
              }
    public partial class ConversationMessageListiningDTO : EntityDTO
	{
              }
}
namespace Niu.Nutri.Chat.Application.DTO.Aggregates.UsersAgg.Requests 
{
	using Requests;
    public partial class UserListiningDTO : EntityDTO
	{
            }
}
