using Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Niu.Nutri.Livraria.Infra.Data.Aggregates.LivrariaAgg.Mappings
{
    public partial class AutorMapping : IEntityTypeConfiguration<Autor>
    {
		partial void ConfigureAdditionalMapping(EntityTypeBuilder<Autor> builder)
        {
            builder.Property(x => x.Id).Metadata.SetColumnName("CodAu");
        }
    }
}
