
using CsvHelper.Configuration;
namespace Niu.Nutri.Chat.Domain.Aggregates.ChatAgg.Profiles
{
	using Application.DTO.Aggregates.ChatAgg.Requests;
	using Entities;
	public partial class ConversationCsvMap : ClassMap<Conversation>
	{
		public ConversationCsvMap()
		{
			Map(x=>x.FromAvatar).Name("FromAvatar");Map(x=>x.FromName).Name("FromName");Map(x=>x.MessagesCount).Name("MessagesCount");Map(x=>x.NotReadMessagesCount).Name("NotReadMessagesCount");Map(x=>x.FromId).Name("FromId");Map(x=>x.ToId).Name("ToId");Map(x=>x.Messages).Name("Messages");
		}
	}
	public partial class ChatAggSettingsCsvMap : ClassMap<ChatAggSettings>
	{
		public ChatAggSettingsCsvMap()
		{
			Map(x=>x.UserId).Name("UserId");
		}
	}
	public partial class ConversationMessageCsvMap : ClassMap<ConversationMessage>
	{
		public ConversationMessageCsvMap()
		{
			Map(x=>x.Text).Name("Text");Map(x=>x.Status).Name("Status");Map(x=>x.ConversationId).Name("ConversationId");Map(x=>x.FromId).Name("FromId");
		}
	}
}
