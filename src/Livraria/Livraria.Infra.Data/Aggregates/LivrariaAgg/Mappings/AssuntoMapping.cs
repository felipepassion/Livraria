using Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Niu.Nutri.Livraria.Infra.Data.Aggregates.LivrariaAgg.Mappings
{
    public partial class AssuntoMapping : IEntityTypeConfiguration<Assunto>
    {
        partial void ConfigureAdditionalMapping(EntityTypeBuilder<Assunto> builder)
        {
            builder.Property(x => x.Id).Metadata.SetColumnName("CodAs");
        }
    }
}
