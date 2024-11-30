using Niu.Nutri.Addresses.Domain.Aggregates.AddressesAgg.Entities;
using Niu.Nutri.Addresses.Domain.Aggregates.UsersAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Niu.Nutri.Addresses.Infra.Data.Aggregates.AddressesAgg.Mappings 
{
    public partial class AddressMapping : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<Address> builder);
    }
    public partial class AddressesAggSettingsMapping : IEntityTypeConfiguration<AddressesAggSettings>
    {
        public void Configure(EntityTypeBuilder<AddressesAggSettings> builder)
        {
            builder.HasKey(x => x.Id);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<AddressesAggSettings> builder);
    }
}
namespace Niu.Nutri.Addresses.Infra.Data.Aggregates.UsersAgg.Mappings 
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
