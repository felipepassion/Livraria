
using Niu.Nutri.Chat.Domain.Aggregates.ChatAgg.Entities; 
using Niu.Nutri.Chat.Infra.Data.Aggregates.ChatAgg.Mappings; 
using Niu.Nutri.Chat.Domain.Aggregates.UsersAgg.Entities; 
using Niu.Nutri.Chat.Infra.Data.Aggregates.UsersAgg.Mappings; 
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Niu.Nutri.Core.Infra.Data.Contexts;

namespace Niu.Nutri.Chat.Infra.Data.Context
{
	public partial class ChatAggContext : BaseContext
	{
		public DbSet<Conversation> Conversation { get; set; }
		public DbSet<ChatAggSettings> ChatAggSettings { get; set; }
		public DbSet<ConversationMessage> ConversationMessage { get; set; }
		public DbSet<User> User { get; set; }

		public ChatAggContext (MediatR.IMediator mediator, DbContextOptions<ChatAggContext> options, IServiceProvider scope)
            : base(mediator, options, scope)
        {
        }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new ConversationMapping());
			builder.ApplyConfiguration(new ChatAggSettingsMapping());
			builder.ApplyConfiguration(new ConversationMessageMapping());
			builder.ApplyConfiguration(new UserMapping());
		
			ApplyAdditionalMappings(builder);
			base.OnModelCreating(builder);
		}
		partial void ApplyAdditionalMappings(ModelBuilder modelBuilder);
	}
}
