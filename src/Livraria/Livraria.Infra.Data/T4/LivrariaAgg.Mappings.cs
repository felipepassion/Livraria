using Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities;
using Niu.Nutri.Livraria.Domain.Aggregates.UsersAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Niu.Nutri.Livraria.Infra.Data.Aggregates.LivrariaAgg.Mappings 
{
    public partial class Livro_AutorMapping : IEntityTypeConfiguration<Livro_Autor>
    {
        public void Configure(EntityTypeBuilder<Livro_Autor> builder)
        {
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<Livro_Autor> builder);
    }
    public partial class LivroMapping : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<Livro> builder);
    }
    public partial class AssuntoMapping : IEntityTypeConfiguration<Assunto>
    {
        public void Configure(EntityTypeBuilder<Assunto> builder)
        {
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<Assunto> builder);
    }
    public partial class Livro_AssuntoMapping : IEntityTypeConfiguration<Livro_Assunto>
    {
        public void Configure(EntityTypeBuilder<Livro_Assunto> builder)
        {
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<Livro_Assunto> builder);
    }
    public partial class AutorMapping : IEntityTypeConfiguration<Autor>
    {
        public void Configure(EntityTypeBuilder<Autor> builder)
        {
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<Autor> builder);
    }
    public partial class LivrariaAggSettingsMapping : IEntityTypeConfiguration<LivrariaAggSettings>
    {
        public void Configure(EntityTypeBuilder<LivrariaAggSettings> builder)
        {
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<LivrariaAggSettings> builder);
    }
}
namespace Niu.Nutri.Livraria.Infra.Data.Aggregates.UsersAgg.Mappings 
{
    public partial class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Metadata.SetIsTableExcludedFromMigrations(true);
            ConfigureAdditionalMapping(builder);
        }

		partial void ConfigureAdditionalMapping(EntityTypeBuilder<User> builder);
    }
}
