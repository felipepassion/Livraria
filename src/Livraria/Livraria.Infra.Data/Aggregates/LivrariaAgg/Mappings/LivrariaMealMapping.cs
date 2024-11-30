using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities;

namespace Niu.Nutri.Livraria.Infra.Data.Aggregates.LivrariaAgg.Mappings;

public partial class LivrariaMealMapping
{
    partial void ConfigureAdditionalMapping(EntityTypeBuilder<LivrariaMeal> builder)
    {
    }
}
