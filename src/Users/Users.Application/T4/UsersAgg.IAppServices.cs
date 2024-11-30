using System.Linq.Expressions;
using Niu.Nutri.Core.Domain.CrossCutting;
using Niu.Nutri.Core.Application.Aggregates.Common;

namespace Niu.Nutri.Users.Application.Aggregates.UsersAgg.AppServices {
	using Application.DTO.Aggregates.UsersAgg.Requests;
    using Domain.Aggregates.UsersAgg.Queries.Models;
	public partial interface IUserProfileAccessAppService : IBaseAppService {	
		public Task<UserProfileAccessDTO> Get(UserProfileAccessQueryModel request);
		public Task<int> CountAsync(UserProfileAccessQueryModel request);
		public Task<IEnumerable<UserProfileAccessDTO>> GetAll(UserProfileAccessQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(UserProfileAccessQueryModel request, Expression<Func<Domain.Aggregates.UsersAgg.Entities.UserProfileAccess, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(UserProfileAccessQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.UsersAgg.Entities.UserProfileAccess, T>> selector = null);
		public Task<IEnumerable<UserProfileAccessListiningDTO>> GetAllSummary(UserProfileAccessQueryModel request, int? page = null, int? size = null);

		public Task<DomainResponse> Create(UserProfileAccessDTO request, bool updateIfExists = true, UserProfileAccessQueryModel searchQuery = null);
		public Task<DomainResponse> Delete(UserProfileAccessQueryModel request);
		public Task<DomainResponse> DeleteRange(UserProfileAccessQueryModel request);
		public Task Update(UserProfileAccessQueryModel searchQuery, UserProfileAccessDTO request, bool createIfNotExists = true);
	}
	public partial interface IUserCurrentAccessSelectedAppService : IBaseAppService {	
		public Task<UserCurrentAccessSelectedDTO> Get(UserCurrentAccessSelectedQueryModel request);
		public Task<int> CountAsync(UserCurrentAccessSelectedQueryModel request);
		public Task<IEnumerable<UserCurrentAccessSelectedDTO>> GetAll(UserCurrentAccessSelectedQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(UserCurrentAccessSelectedQueryModel request, Expression<Func<Domain.Aggregates.UsersAgg.Entities.UserCurrentAccessSelected, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(UserCurrentAccessSelectedQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.UsersAgg.Entities.UserCurrentAccessSelected, T>> selector = null);
		public Task<IEnumerable<UserCurrentAccessSelectedListiningDTO>> GetAllSummary(UserCurrentAccessSelectedQueryModel request, int? page = null, int? size = null);

		public Task<DomainResponse> Create(UserCurrentAccessSelectedDTO request, bool updateIfExists = true, UserCurrentAccessSelectedQueryModel searchQuery = null);
		public Task<DomainResponse> Delete(UserCurrentAccessSelectedQueryModel request);
		public Task<DomainResponse> DeleteRange(UserCurrentAccessSelectedQueryModel request);
		public Task Update(UserCurrentAccessSelectedQueryModel searchQuery, UserCurrentAccessSelectedDTO request, bool createIfNotExists = true);
	}
	public partial interface IUserProfileListAppService : IBaseAppService {	
		public Task<UserProfileListDTO> Get(UserProfileListQueryModel request);
		public Task<int> CountAsync(UserProfileListQueryModel request);
		public Task<IEnumerable<UserProfileListDTO>> GetAll(UserProfileListQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(UserProfileListQueryModel request, Expression<Func<Domain.Aggregates.UsersAgg.Entities.UserProfileList, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(UserProfileListQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.UsersAgg.Entities.UserProfileList, T>> selector = null);
		public Task<IEnumerable<UserProfileListListiningDTO>> GetAllSummary(UserProfileListQueryModel request, int? page = null, int? size = null);

		public Task<DomainResponse> Create(UserProfileListDTO request, bool updateIfExists = true, UserProfileListQueryModel searchQuery = null);
		public Task<DomainResponse> Delete(UserProfileListQueryModel request);
		public Task<DomainResponse> DeleteRange(UserProfileListQueryModel request);
		public Task Update(UserProfileListQueryModel searchQuery, UserProfileListDTO request, bool createIfNotExists = true);
	}
	public partial interface IUserProfileAppService : IBaseAppService {	
		public Task<UserProfileDTO> Get(UserProfileQueryModel request);
		public Task<int> CountAsync(UserProfileQueryModel request);
		public Task<IEnumerable<UserProfileDTO>> GetAll(UserProfileQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(UserProfileQueryModel request, Expression<Func<Domain.Aggregates.UsersAgg.Entities.UserProfile, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(UserProfileQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.UsersAgg.Entities.UserProfile, T>> selector = null);
		public Task<IEnumerable<UserProfileListiningDTO>> GetAllSummary(UserProfileQueryModel request, int? page = null, int? size = null);

		public Task<DomainResponse> Create(UserProfileDTO request, bool updateIfExists = true, UserProfileQueryModel searchQuery = null);
		public Task<DomainResponse> Delete(UserProfileQueryModel request);
		public Task<DomainResponse> DeleteRange(UserProfileQueryModel request);
		public Task Update(UserProfileQueryModel searchQuery, UserProfileDTO request, bool createIfNotExists = true);
	}
	public partial interface IUsersAggSettingsAppService : IBaseAppService {	
		public Task<UsersAggSettingsDTO> Get(UsersAggSettingsQueryModel request);
		public Task<int> CountAsync(UsersAggSettingsQueryModel request);
		public Task<IEnumerable<UsersAggSettingsDTO>> GetAll(UsersAggSettingsQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(UsersAggSettingsQueryModel request, Expression<Func<Domain.Aggregates.UsersAgg.Entities.UsersAggSettings, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(UsersAggSettingsQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.UsersAgg.Entities.UsersAggSettings, T>> selector = null);
		public Task<IEnumerable<UsersAggSettingsListiningDTO>> GetAllSummary(UsersAggSettingsQueryModel request, int? page = null, int? size = null);

		public Task<DomainResponse> Create(UsersAggSettingsDTO request, bool updateIfExists = true, UsersAggSettingsQueryModel searchQuery = null);
		public Task<DomainResponse> Delete(UsersAggSettingsQueryModel request);
		public Task<DomainResponse> DeleteRange(UsersAggSettingsQueryModel request);
		public Task Update(UsersAggSettingsQueryModel searchQuery, UsersAggSettingsDTO request, bool createIfNotExists = true);
	}
	public partial interface IUserAppService : IBaseAppService {	
		public Task<UserDTO> Get(UserQueryModel request);
		public Task<int> CountAsync(UserQueryModel request);
		public Task<IEnumerable<UserDTO>> GetAll(UserQueryModel request, int? page = null, int? size = null);
		public Task<T> Select<T>(UserQueryModel request, Expression<Func<Domain.Aggregates.UsersAgg.Entities.User, T>> selector = null);
		public Task<IEnumerable<T>> GetAll<T>(UserQueryModel request, int? page = null, int? size = null, Expression<Func<Domain.Aggregates.UsersAgg.Entities.User, T>> selector = null);
		public Task<IEnumerable<UserListiningDTO>> GetAllSummary(UserQueryModel request, int? page = null, int? size = null);

		public Task<DomainResponse> Create(UserDTO request, bool updateIfExists = true, UserQueryModel searchQuery = null);
		public Task<DomainResponse> Delete(UserQueryModel request);
		public Task<DomainResponse> DeleteRange(UserQueryModel request);
		public Task Update(UserQueryModel searchQuery, UserDTO request, bool createIfNotExists = true);
	}
}
