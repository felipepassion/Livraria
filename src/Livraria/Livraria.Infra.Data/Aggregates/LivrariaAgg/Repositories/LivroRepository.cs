namespace Niu.Nutri.Livraria.Infra.Data.Aggregates.LivrariaAgg.Repositories;

using Core.Infra.Data.Repositories;
using Context;
using Domain.Aggregates.LivrariaAgg.Entities;
using Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Repositories;

	public partial class LivroRepository : Repository<Livro>, ILivroRepository { public LivroRepository(LivrariaAggContext ctx) : base(ctx) { } }

