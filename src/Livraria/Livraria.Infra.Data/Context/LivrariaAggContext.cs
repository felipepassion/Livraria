
using Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities; 
using Niu.Nutri.Livraria.Infra.Data.Aggregates.LivrariaAgg.Mappings; 
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Niu.Nutri.Core.Infra.Data.Contexts;

namespace Niu.Nutri.Livraria.Infra.Data.Context
{
	public partial class LivrariaAggContext : BaseContext
	{
		public DbSet<AutorLivro> AutorLivro { get; set; }
		public DbSet<Book> Livro { get; set; }
		public DbSet<Subject> Assunto { get; set; }
		public DbSet<AssuntoLivro> AssuntoLivro { get; set; }
		public DbSet<Author> Autor { get; set; }

		public LivrariaAggContext (MediatR.IMediator mediator, DbContextOptions<LivrariaAggContext> options, IServiceProvider scope)
            : base(mediator, options, scope)
        {
        }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new AutorLivroMapping());
			builder.ApplyConfiguration(new LivroMapping());
			builder.ApplyConfiguration(new AssuntoMapping());
			builder.ApplyConfiguration(new AssuntoLivroMapping());
			builder.ApplyConfiguration(new AutorMapping());
		
			ApplyAdditionalMappings(builder);
			base.OnModelCreating(builder);
		}
		partial void ApplyAdditionalMappings(ModelBuilder modelBuilder);
	}
}
