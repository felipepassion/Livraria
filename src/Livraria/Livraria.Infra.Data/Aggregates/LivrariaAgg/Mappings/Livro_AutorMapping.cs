namespace Niu.Nutri.Livraria.Infra.Data.Aggregates.LivrariaAgg.Mappings;

using Domain.Aggregates.LivrariaAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public partial class Livro_AutorMapping : IEntityTypeConfiguration<Livro_Autor>
{
    public void Configure(EntityTypeBuilder<Livro_Autor> builder)
    {
    }
}
