using System.Linq.Expressions;

namespace Niu.Nutri.Livraria.Application.Aggregates.LivrariaAgg.AppServices;
	using Application.DTO.Aggregates.LivrariaAgg.Requests;
    using Domain.Aggregates.LivrariaAgg.Queries.Models;
	using Core.Application.Aggregates.Common;
	using Core.Application.DTO.Http.Models.Responses;

	public partial interface IAssuntoAppService : IBaseAppService {	
		public Task<AssuntoDTO> Get(AssuntoQueryModel request);
		public Task<int> CountAsync(AssuntoQueryModel request);
		public Task<IEnumerable<AssuntoDTO>> GetAll(AssuntoQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(AssuntoQueryModel request, Expression<Func<Domain.Aggregates.LivrariaAgg.Entities.Subject, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(AssuntoQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.LivrariaAgg.Entities.Subject, T>> selector = null);

		public Task<DomainResponse> Create(AssuntoDTO request, bool updateIfExists = true, AssuntoQueryModel searchQuery = null);
		public Task<DomainResponse> Delete(AssuntoQueryModel request);
		public Task<DomainResponse> DeleteRange(AssuntoQueryModel request);
		public Task Update(AssuntoQueryModel searchQuery, AssuntoDTO request, bool createIfNotExists = true);
}
	