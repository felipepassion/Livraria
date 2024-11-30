

using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Niu.Nutri.Core.Application.DTO.Attributes;

namespace Niu.Nutri.Chat.Application.DTO.Aggregates.ChatAgg.Requests 
{
public partial class ConversationDTO : SteppableEntityDTO
	{
	    [DisplayOnList,DisplayName("")] public  string? FromAvatar { get; set; }
	    [DisplayOnList,DisplayName("Remetente")] public  string? FromName { get; set; }
	    [DisplayOnList,DisplayName("Qtd Mensagens")] public  int? MessagesCount { get; set; }
	    [DisplayOnList,DisplayName("Mensagens N�o Lidas")] public int? NotReadMessagesCount { get; set; } 
	    public  int FromId { get; set; }
	    public  int ToId { get; set; }
	    public List<Niu.Nutri.Chat.Application.DTO.Aggregates.ChatAgg.Requests.ConversationMessageDTO>? Messages { get; set; } = new List<Niu.Nutri.Chat.Application.DTO.Aggregates.ChatAgg.Requests.ConversationMessageDTO>();
	}
public partial class ChatAggSettingsDTO : BaseAggregateSettingsDTO
	{
	    public  int UserId { get; set; }
	}
public partial class ConversationMessageDTO : EntityDTO
	{
	    public  string? Text { get; set; }
	    public  Niu.Nutri.Chat.Enumerations.MessageStatus? Status { get; set; }
	    public  int? ConversationId { get; set; }
	    public  int? FromId { get; set; }
	}
}
namespace Niu.Nutri.Chat.Application.DTO.Aggregates.UsersAgg.Requests 
{
public partial class UserDTO : EntityDTO
	{
	    public  string? Name { get; set; }
	    public  string? ProfilePicture { get; set; }
	}
}
