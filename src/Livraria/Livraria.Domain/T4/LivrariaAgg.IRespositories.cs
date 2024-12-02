using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Repositories;
using Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities;
using Niu.Nutri.Livraria.Domain.Aggregates.UsersAgg.Entities;

namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Repositories 
{
	public partial interface ILivro_AutorRepository : IRepository<Livro_Autor> { }

	public partial interface ILivroRepository : IRepository<Livro> { }

	public partial interface IAssuntoRepository : IRepository<Assunto> { }

	public partial interface ILivro_AssuntoRepository : IRepository<Livro_Assunto> { }

	public partial interface IAutorRepository : IRepository<Autor> { }

}
namespace Niu.Nutri.Livraria.Domain.Aggregates.UsersAgg.Repositories 
{
	public partial interface IUserRepository : IRepository<User> { }

}
