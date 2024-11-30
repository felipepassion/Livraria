using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Niu.Nutri.Users.Domain.Aggregates.SystemSettingsAgg.Entities;

namespace Niu.Nutri.Users.Infra.Data.Aggregates.SystemSettingsAgg.Mappings
{
    public partial class SystemPanelGroupMapping : IEntityTypeConfiguration<SystemPanelGroup>
    {
        partial void ConfigureAdditionalMapping(EntityTypeBuilder<SystemPanelGroup> builder)
        {
            builder.HasMany(x => x.SubItems).WithMany(x => x.GroupOfMenus)
                .UsingEntity<Dictionary<string, object>>(
                    $"{nameof(SystemPanelGroup)}{nameof(SystemPanel)}",
                    x => x.HasOne<SystemPanel>().WithMany(),
                    x => x.HasOne<SystemPanelGroup>().WithMany()
                ).Metadata.SetIsTableExcludedFromMigrations(true);
        }
    }
}
