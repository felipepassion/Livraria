using Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Niu.Nutri.Livraria.Infra.Data.Aggregates.LivrariaAgg.Mappings
{
    public partial class LivroMapping : IEntityTypeConfiguration<Livro>
    {
        partial void ConfigureAdditionalMapping(EntityTypeBuilder<Livro> builder)
        {
            builder.Property(x => x.Id).Metadata.SetColumnName("Codl");

        }
    }
}
