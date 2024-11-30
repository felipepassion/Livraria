using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Repositories;
using Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities;

namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Repositories 
{
	public partial interface ILivro_AutorRepository : IRepository<Livro_Autor> { }
	public partial interface ILivro_AutorMongoRepository : IMongoRepository<Livro_Autor> { }

	public partial interface ILivroRepository : IRepository<Livro> { }
	public partial interface ILivroMongoRepository : IMongoRepository<Livro> { }

	public partial interface IAssuntoRepository : IRepository<Assunto> { }
	public partial interface IAssuntoMongoRepository : IMongoRepository<Assunto> { }

	public partial interface ILivro_AssuntoRepository : IRepository<Livro_Assunto> { }
	public partial interface ILivro_AssuntoMongoRepository : IMongoRepository<Livro_Assunto> { }

	public partial interface IAutorRepository : IRepository<Autor> { }
	public partial interface IAutorMongoRepository : IMongoRepository<Autor> { }

	public partial interface ILivrariaAggSettingsRepository : IRepository<LivrariaAggSettings> { }
	public partial interface ILivrariaAggSettingsMongoRepository : IMongoRepository<LivrariaAggSettings> { }

}
