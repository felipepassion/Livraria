using Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Niu.Nutri.Livraria.Infra.Data.Aggregates.LivrariaAgg.Mappings
{
    public partial class Livro_AssuntoMapping : IEntityTypeConfiguration<Livro_Assunto>
    {
        partial void ConfigureAdditionalMapping(EntityTypeBuilder<Livro_Assunto> builder)
        {
        }
    }
}
