namespace Niu.Nutri.Livraria.Infra.Data.Aggregates.LivrariaAgg.Repositories;

using Core.Infra.Data.Repositories;
using Context;
using Domain.Aggregates.LivrariaAgg.Entities;
using Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Repositories;

	public partial class AutorRepository : Repository<Autor>, IAutorRepository { public AutorRepository(LivrariaAggContext ctx) : base(ctx) { } }

