using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Niu.Nutri.SystemSettings.Domain.Aggregates.UsersAgg.Entities;

namespace Niu.Nutri.SystemSettings.Infra.Data.Aggregates.UsersAgg.Mappings
{
   
    public partial class UserProfileListMapping : IEntityTypeConfiguration<UserProfileList>
    {
        partial void ConfigureAdditionalMapping(EntityTypeBuilder<UserProfileList> builder)
        {
            builder.HasMany(x => x.UserProfiles).WithMany(x => x.AccessesList)
                .UsingEntity<Dictionary<string, object>>(
                    $"{nameof(UserProfileList)}{nameof(UserProfile)}",
                    x => x.HasOne<UserProfile>().WithMany(),
                    x => x.HasOne<UserProfileList>().WithMany()
                ).Metadata.SetIsTableExcludedFromMigrations(true);
        }
    }

    public partial class UserProfileMapping : IEntityTypeConfiguration<UserProfile>
    {
        partial void ConfigureAdditionalMapping(EntityTypeBuilder<UserProfile> builder)
        {
            builder.HasMany(x => x.Accesses).WithOne().HasForeignKey(x => x.UserProfileId);
        }
    }

}