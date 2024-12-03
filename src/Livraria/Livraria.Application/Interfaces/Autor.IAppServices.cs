using System.Linq.Expressions;

namespace Niu.Nutri.Livraria.Application.Aggregates.LivrariaAgg.AppServices;
	using Application.DTO.Aggregates.LivrariaAgg.Requests;
    using Domain.Aggregates.LivrariaAgg.Queries.Models;
	using Core.Application.Aggregates.Common;
	using Core.Application.DTO.Http.Models.Responses;

	public partial interface IAutorAppService : IBaseAppService {	
		public Task<AutorDTO> Get(AutorQueryModel request);
		public Task<int> CountAsync(AutorQueryModel request);
		public Task<IEnumerable<AutorDTO>> GetAll(AutorQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(AutorQueryModel request, Expression<Func<Domain.Aggregates.LivrariaAgg.Entities.Autor, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(AutorQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.LivrariaAgg.Entities.Autor, T>> selector = null);

		public Task<DomainResponse> Create(AutorDTO request, bool updateIfExists = true, AutorQueryModel searchQuery = null);
		public Task<DomainResponse> Delete(AutorQueryModel request);
		public Task<DomainResponse> DeleteRange(AutorQueryModel request);
		public Task Update(AutorQueryModel searchQuery, AutorDTO request, bool createIfNotExists = true);
}
	