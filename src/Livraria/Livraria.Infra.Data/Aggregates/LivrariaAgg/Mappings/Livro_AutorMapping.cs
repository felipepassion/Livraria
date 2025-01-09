namespace Niu.Nutri.Livraria.Infra.Data.Aggregates.LivrariaAgg.Mappings;

using Domain.Aggregates.LivrariaAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public partial class AutorLivroMapping : IEntityTypeConfiguration<AutorLivro>
{
    public void Configure(EntityTypeBuilder<AutorLivro> builder)
    {
    }
}
