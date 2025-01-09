namespace Niu.Nutri.Livraria.Infra.Data.Aggregates.LivrariaAgg.Mappings;

using Domain.Aggregates.LivrariaAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public partial class LivroMapping : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasMany(x => x.Authors).WithMany(x => x.Livros)
            .UsingEntity<AutorLivro>();

        builder.HasMany(x => x.Subjects).WithMany(x => x.Livros)
            .UsingEntity<AssuntoLivro>();
    }
}
