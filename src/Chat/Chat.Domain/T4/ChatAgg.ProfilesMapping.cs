using AutoMapper;
namespace Niu.Nutri.Chat.Domain.Aggregates.ChatAgg.Profiles
{
    public class ChatAggCoreProfile : Core.Domain.Aggregates.CommonAgg.Profiles.CoreAggProfile { }
}

namespace Niu.Nutri.Chat.Domain.Aggregates.ChatAgg.Profiles
{
	using Application.DTO.Aggregates.ChatAgg.Requests;
	using Entities;
	public partial class ChatAggProfile : Profile
	{
		public ChatAggProfile()
		{
			CreateMap<ConversationDTO, Conversation>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<Conversation, ConversationDTO>();
			CreateMap<ChatAggSettingsDTO, ChatAggSettings>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<ChatAggSettings, ChatAggSettingsDTO>();
			CreateMap<ConversationMessageDTO, ConversationMessage>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<ConversationMessage, ConversationMessageDTO>();
			ConfigureAdditionalProfiles();
		}
		partial void ConfigureAdditionalProfiles();
	}
}

namespace Niu.Nutri.Chat.Domain.Aggregates.UsersAgg.Profiles
{
	using Application.DTO.Aggregates.UsersAgg.Requests;
	using Entities;
	public partial class UsersAggProfile : Profile
	{
		public UsersAggProfile()
		{
			CreateMap<UserDTO, User>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<User, UserDTO>();
			ConfigureAdditionalProfiles();
		}
		partial void ConfigureAdditionalProfiles();
	}
}

