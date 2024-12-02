
using System.Linq.Expressions;

namespace Niu.Nutri.Livraria.Application.Aggregates.LivrariaAgg.AppServices;
	using Application.DTO.Aggregates.LivrariaAgg.Requests;
    using Domain.Aggregates.LivrariaAgg.Queries.Models;
	using Core.Application.Aggregates.Common;
	using Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;

	public partial interface ILivroAppService : IBaseAppService {	
		public Task<LivroDTO> Get(LivroQueryModel request);
		public Task<int> CountAsync(LivroQueryModel request);
		public Task<IEnumerable<LivroDTO>> GetAll(LivroQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(LivroQueryModel request, Expression<Func<Domain.Aggregates.LivrariaAgg.Entities.Livro, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(LivroQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.LivrariaAgg.Entities.Livro, T>> selector = null);

		public Task<DomainResponse> Create(LivroDTO request, bool updateIfExists = true, LivroQueryModel searchQuery = null);
		public Task<DomainResponse> Delete(LivroQueryModel request);
		public Task<DomainResponse> DeleteRange(LivroQueryModel request);
		public Task Update(LivroQueryModel searchQuery, LivroDTO request, bool createIfNotExists = true);
}
	