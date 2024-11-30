
using Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities; 
using Niu.Nutri.Livraria.Infra.Data.Aggregates.LivrariaAgg.Mappings; 
using Niu.Nutri.Livraria.Domain.Aggregates.UsersAgg.Entities; 
using Niu.Nutri.Livraria.Infra.Data.Aggregates.UsersAgg.Mappings; 
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Niu.Nutri.Core.Infra.Data.Contexts;

namespace Niu.Nutri.Livraria.Infra.Data.Context
{
	public partial class LivrariaAggContext : BaseContext
	{
		public DbSet<LivrariaAggSettings> LivrariaAggSettings { get; set; }
		public DbSet<Livro_Autor> Livro_Autor { get; set; }
		public DbSet<Autor> Autor { get; set; }
		public DbSet<Assunto> Assunto { get; set; }
		public DbSet<Livro_Assunto> Livro_Assunto { get; set; }
		public DbSet<Livro> Livro { get; set; }
		public DbSet<User> User { get; set; }

		public LivrariaAggContext (MediatR.IMediator mediator, DbContextOptions<LivrariaAggContext> options, IServiceProvider scope)
            : base(mediator, options, scope)
        {
        }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new LivrariaAggSettingsMapping());
			builder.ApplyConfiguration(new Livro_AutorMapping());
			builder.ApplyConfiguration(new AutorMapping());
			builder.ApplyConfiguration(new AssuntoMapping());
			builder.ApplyConfiguration(new Livro_AssuntoMapping());
			builder.ApplyConfiguration(new LivroMapping());
			builder.ApplyConfiguration(new UserMapping());
		
			ApplyAdditionalMappings(builder);
			base.OnModelCreating(builder);
		}
		partial void ApplyAdditionalMappings(ModelBuilder modelBuilder);
	}
}
