using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FluentValidation;
using AutoMapper;
using Niu.Nutri.Core.Application.DTO.Attributes;
namespace Niu.Nutri.Chat.Domain.Aggregates.ChatAgg.Profiles
{
	using Application.DTO.Aggregates.ChatAgg.Requests;
	using Entities;
	public partial class ConversationListiningProfile : Profile
	{
		public ConversationListiningProfile()
		{
			 CreateMap<Conversation, ConversationListiningDTO>().ForMember(x=>x.FromAvatar, opt => opt.MapFrom(x=>x.FromAvatar)).ForMember(x=>x.FromName, opt => opt.MapFrom(x=>x.FromName)).ForMember(x=>x.MessagesCount, opt => opt.MapFrom(x=>x.MessagesCount)).ForMember(x=>x.NotReadMessagesCount, opt => opt.MapFrom(x=>x.NotReadMessagesCount));
		}
	}
	public partial class ChatAggSettingsListiningProfile : Profile
	{
		public ChatAggSettingsListiningProfile()
		{
			 CreateMap<ChatAggSettings, ChatAggSettingsListiningDTO>();
		}
	}
	public partial class ConversationMessageListiningProfile : Profile
	{
		public ConversationMessageListiningProfile()
		{
			 CreateMap<ConversationMessage, ConversationMessageListiningDTO>();
		}
	}
}
