using Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Niu.Nutri.Livraria.Infra.Data.Aggregates.LivrariaAgg.Mappings
{
    public partial class Livro_AutorMapping : IEntityTypeConfiguration<Livro_Autor>
    {
        partial void ConfigureAdditionalMapping(EntityTypeBuilder<Livro_Autor> builder)
        {
        }
    }
}
