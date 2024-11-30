using Microsoft.Extensions.Configuration;
using Niu.Nutri.Core.Infra.Data.Repositories;
using Niu.Nutri.Livraria.Infra.Data.Context;

using Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities;

namespace Niu.Nutri.Livraria.Infra.Data.Aggregates.LivrariaAgg.Repositories
{
	using Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Repositories;
	public partial class LivrariaAggSettingsRepository : Repository<LivrariaAggSettings>, ILivrariaAggSettingsRepository { public LivrariaAggSettingsRepository(LivrariaAggContext ctx) : base(ctx) { } }

	public partial class Livro_AutorRepository : Repository<Livro_Autor>, ILivro_AutorRepository { public Livro_AutorRepository(LivrariaAggContext ctx) : base(ctx) { } }

	public partial class AutorRepository : Repository<Autor>, IAutorRepository { public AutorRepository(LivrariaAggContext ctx) : base(ctx) { } }

	public partial class AssuntoRepository : Repository<Assunto>, IAssuntoRepository { public AssuntoRepository(LivrariaAggContext ctx) : base(ctx) { } }

	public partial class Livro_AssuntoRepository : Repository<Livro_Assunto>, ILivro_AssuntoRepository { public Livro_AssuntoRepository(LivrariaAggContext ctx) : base(ctx) { } }

	public partial class LivroRepository : Repository<Livro>, ILivroRepository { public LivroRepository(LivrariaAggContext ctx) : base(ctx) { } }

}
