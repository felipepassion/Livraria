using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities;

namespace Niu.Nutri.Livraria.Infra.Data.Aggregates.LivrariaAgg.Mappings
{
    public partial class LivroMapping : IEntityTypeConfiguration<Livro>
    {
        partial void ConfigureAdditionalMapping(EntityTypeBuilder<Livro> builder)
        {
            builder.Property(x => x.Id).Metadata.SetColumnName("Codl");

            builder.HasMany(x => x.Autores).WithMany(x => x.Livros)
                .UsingEntity<Livro_Autor>();

            builder.HasMany(x => x.Assuntos).WithMany(x => x.Livros)
                .UsingEntity<Livro_Assunto>();
        }
    }
}
