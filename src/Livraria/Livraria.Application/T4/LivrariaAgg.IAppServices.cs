using System.Linq.Expressions;
using Niu.Nutri.Core.Application.Aggregates.Common;
using Niu.Nutri.Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;

namespace Niu.Nutri.Livraria.Application.Aggregates.LivrariaAgg.AppServices {
	using Application.DTO.Aggregates.LivrariaAgg.Requests;
    using Domain.Aggregates.LivrariaAgg.Queries.Models;
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
	public partial interface IAssuntoAppService : IBaseAppService {	
		public Task<AssuntoDTO> Get(AssuntoQueryModel request);
		public Task<int> CountAsync(AssuntoQueryModel request);
		public Task<IEnumerable<AssuntoDTO>> GetAll(AssuntoQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(AssuntoQueryModel request, Expression<Func<Domain.Aggregates.LivrariaAgg.Entities.Assunto, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(AssuntoQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.LivrariaAgg.Entities.Assunto, T>> selector = null);

		public Task<DomainResponse> Create(AssuntoDTO request, bool updateIfExists = true, AssuntoQueryModel searchQuery = null);
		public Task<DomainResponse> Delete(AssuntoQueryModel request);
		public Task<DomainResponse> DeleteRange(AssuntoQueryModel request);
		public Task Update(AssuntoQueryModel searchQuery, AssuntoDTO request, bool createIfNotExists = true);
	}
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
	public partial interface ILivrariaAggSettingsAppService : IBaseAppService {	
		public Task<LivrariaAggSettingsDTO> Get(LivrariaAggSettingsQueryModel request);
		public Task<int> CountAsync(LivrariaAggSettingsQueryModel request);
		public Task<IEnumerable<LivrariaAggSettingsDTO>> GetAll(LivrariaAggSettingsQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(LivrariaAggSettingsQueryModel request, Expression<Func<Domain.Aggregates.LivrariaAgg.Entities.LivrariaAggSettings, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(LivrariaAggSettingsQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.LivrariaAgg.Entities.LivrariaAggSettings, T>> selector = null);

		public Task<DomainResponse> Create(LivrariaAggSettingsDTO request, bool updateIfExists = true, LivrariaAggSettingsQueryModel searchQuery = null);
		public Task<DomainResponse> Delete(LivrariaAggSettingsQueryModel request);
		public Task<DomainResponse> DeleteRange(LivrariaAggSettingsQueryModel request);
		public Task Update(LivrariaAggSettingsQueryModel searchQuery, LivrariaAggSettingsDTO request, bool createIfNotExists = true);
	}
}
