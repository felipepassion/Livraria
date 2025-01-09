namespace Niu.Nutri.Livraria.Infra.Data.Aggregates.LivrariaAgg.Mappings;

using Domain.Aggregates.LivrariaAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public partial class AssuntoLivroMapping : IEntityTypeConfiguration<AssuntoLivro>
{
    public void Configure(EntityTypeBuilder<AssuntoLivro> builder)
    {
    }
}
