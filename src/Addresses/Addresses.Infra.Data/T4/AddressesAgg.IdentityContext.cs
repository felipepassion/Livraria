
using Niu.Nutri.Addresses.Domain.Aggregates.AddressesAgg.Entities; 
using Niu.Nutri.Addresses.Infra.Data.Aggregates.AddressesAgg.Mappings; 
using Niu.Nutri.Addresses.Domain.Aggregates.UsersAgg.Entities; 
using Niu.Nutri.Addresses.Infra.Data.Aggregates.UsersAgg.Mappings; 
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Niu.Nutri.Core.Infra.Data.Contexts;

namespace Niu.Nutri.Addresses.Infra.Data.Context
{
	public partial class AddressesAggContext : BaseContext
	{
		public DbSet<Address> Address { get; set; }
		public DbSet<AddressesAggSettings> AddressesAggSettings { get; set; }
		public DbSet<User> User { get; set; }

		public AddressesAggContext (MediatR.IMediator mediator, DbContextOptions<AddressesAggContext> options, IServiceProvider scope)
            : base(mediator, options, scope)
        {
        }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new AddressMapping());
			builder.ApplyConfiguration(new AddressesAggSettingsMapping());
			builder.ApplyConfiguration(new UserMapping());
		
			ApplyAdditionalMappings(builder);
			base.OnModelCreating(builder);
		}
		partial void ApplyAdditionalMappings(ModelBuilder modelBuilder);
	}
}
