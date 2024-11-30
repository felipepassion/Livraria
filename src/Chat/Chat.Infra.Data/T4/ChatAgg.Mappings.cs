using Niu.Nutri.Chat.Domain.Aggregates.ChatAgg.Entities;
using Niu.Nutri.Chat.Domain.Aggregates.UsersAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Niu.Nutri.Chat.Infra.Data.Aggregates.ChatAgg.Mappings 
{
    public partial class ConversationMapping : IEntityTypeConfiguration<Conversation>
    {
        public void Configure(EntityTypeBuilder<Conversation> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<Conversation> builder);
    }
    public partial class ChatAggSettingsMapping : IEntityTypeConfiguration<ChatAggSettings>
    {
        public void Configure(EntityTypeBuilder<ChatAggSettings> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<ChatAggSettings> builder);
    }
    public partial class ConversationMessageMapping : IEntityTypeConfiguration<ConversationMessage>
    {
        public void Configure(EntityTypeBuilder<ConversationMessage> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<ConversationMessage> builder);
    }
}
namespace Niu.Nutri.Chat.Infra.Data.Aggregates.UsersAgg.Mappings 
{
    public partial class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Metadata.SetIsTableExcludedFromMigrations(true);
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<User> builder);
    }
}
