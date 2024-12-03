namespace Niu.Nutri.Livraria.Infra.Data.Aggregates.LivrariaAgg.Mappings;

using Domain.Aggregates.LivrariaAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public partial class LivroMapping : IEntityTypeConfiguration<Livro>
{
    public void Configure(EntityTypeBuilder<Livro> builder)
    {
        builder.HasMany(x => x.Autores).WithMany(x => x.Livros)
            .UsingEntity<Livro_Autor>();

        builder.HasMany(x => x.Assuntos).WithMany(x => x.Livros)
            .UsingEntity<Livro_Assunto>();
    }
}
