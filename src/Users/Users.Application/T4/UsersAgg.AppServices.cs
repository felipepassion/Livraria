
using MediatR;
using System.Linq.Expressions;
using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;
using Niu.Nutri.Core.Application.DTO.Extensions;
using Niu.Nutri.Core.Application.Aggregates.Common;
using Niu.Nutri.Core.Domain.CrossCutting;

namespace Niu.Nutri.Users.Application.Aggregates.UsersAgg.AppServices {
	using Application.DTO.Aggregates.UsersAgg.Requests;
	using Domain.Aggregates.UsersAgg.Queries.Models;
	using Domain.Aggregates.UsersAgg.Repositories;
	using Domain.Aggregates.UsersAgg.Filters;
	using Domain.Aggregates.UsersAgg.Entities;
	using Domain.Aggregates.UsersAgg.CommandModels;
	public partial class UserProfileAccessAppService : BaseAppService, IUserProfileAccessAppService {	
		public IUserProfileAccessRepository _userProfileAccessRepository;
		public UserProfileAccessAppService(IMediator mediator, Niu.Nutri.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IUserProfileAccessRepository userProfileAccessRepository) : base(ctx, mediator) { _userProfileAccessRepository = userProfileAccessRepository; }	
		public async Task<UserProfileAccessDTO> Get(UserProfileAccessQueryModel request) {
            return (await _userProfileAccessRepository.FindAsync(filter: UserProfileAccessFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification), selector: x => x.ProjectedAs<UserProfileAccessDTO>()));
        }
		public void Dispose()
        {
			_userProfileAccessRepository = null;
        }
		public async Task<IEnumerable<T>> GetAll<T>(UserProfileAccessQueryModel request, int? page = null, int? size = null, Expression<Func<UserProfileAccess, T>> selector = null) {
			return await _userProfileAccessRepository.SelectAllAsync(
                filter: UserProfileAccessFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<UserProfileAccess>(),
                selector: selector);
		}
		public async Task<T> Select<T>(UserProfileAccessQueryModel request, Expression<Func<UserProfileAccess, T>> selector = null)
        {
            return (await _userProfileAccessRepository.FindAsync(filter: UserProfileAccessFilters.GetFilters(request, isOrSpecification: true), selector: selector));
        }
        public async Task<IEnumerable<UserProfileAccessDTO>> GetAll(UserProfileAccessQueryModel request, int? page = null, int? size = null) {
            return await _userProfileAccessRepository.FindAllAsync(
                filter: UserProfileAccessFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<UserProfileAccess>(),
                selector: x => x.ProjectedAs<UserProfileAccessDTO>());
        }
		public async Task<IEnumerable<UserProfileAccessListiningDTO>> GetAllSummary(UserProfileAccessQueryModel request, int? page = null, int? size = null)
        {
            return await _userProfileAccessRepository.FindAllAsync(
                filter: UserProfileAccessFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<UserProfileAccess>(),
                selector: x => x.ProjectedAs<UserProfileAccessListiningDTO>());
        }

		public Task<DomainResponse> Create(UserProfileAccessDTO request, bool updateIfExists = true, UserProfileAccessQueryModel searchQuery = null) { return _mediator.Send(new CreateUserProfileAccessCommand(_logRequestContext, request)); }
		public async Task<int> CountAsync(UserProfileAccessQueryModel request) { return await _userProfileAccessRepository.CountAsync(filter: UserProfileAccessFilters.GetFilters(request, isOrSpecification: true)); }
		public Task Update(UserProfileAccessQueryModel searchQuery, UserProfileAccessDTO request, bool createIfNotExists = true) { return _mediator.Send(new UpdateUserProfileAccessCommand(_logRequestContext, searchQuery, request)); }
		public Task<DomainResponse> DeleteRange(UserProfileAccessQueryModel request){ return _mediator.Send(new DeleteRangeUserProfileAccessCommand(_logRequestContext, request)); }
		public Task<DomainResponse> Delete(UserProfileAccessQueryModel request){ return _mediator.Send(new DeleteUserProfileAccessCommand(_logRequestContext, request)); }
	}
	public partial class UserCurrentAccessSelectedAppService : BaseAppService, IUserCurrentAccessSelectedAppService {	
		public IUserCurrentAccessSelectedRepository _userCurrentAccessSelectedRepository;
		public UserCurrentAccessSelectedAppService(IMediator mediator, Niu.Nutri.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IUserCurrentAccessSelectedRepository userCurrentAccessSelectedRepository) : base(ctx, mediator) { _userCurrentAccessSelectedRepository = userCurrentAccessSelectedRepository; }	
		public async Task<UserCurrentAccessSelectedDTO> Get(UserCurrentAccessSelectedQueryModel request) {
            return (await _userCurrentAccessSelectedRepository.FindAsync(filter: UserCurrentAccessSelectedFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification), selector: x => x.ProjectedAs<UserCurrentAccessSelectedDTO>()));
        }
		public void Dispose()
        {
			_userCurrentAccessSelectedRepository = null;
        }
		public async Task<IEnumerable<T>> GetAll<T>(UserCurrentAccessSelectedQueryModel request, int? page = null, int? size = null, Expression<Func<UserCurrentAccessSelected, T>> selector = null) {
			return await _userCurrentAccessSelectedRepository.SelectAllAsync(
                filter: UserCurrentAccessSelectedFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<UserCurrentAccessSelected>(),
                selector: selector);
		}
		public async Task<T> Select<T>(UserCurrentAccessSelectedQueryModel request, Expression<Func<UserCurrentAccessSelected, T>> selector = null)
        {
            return (await _userCurrentAccessSelectedRepository.FindAsync(filter: UserCurrentAccessSelectedFilters.GetFilters(request, isOrSpecification: true), selector: selector));
        }
        public async Task<IEnumerable<UserCurrentAccessSelectedDTO>> GetAll(UserCurrentAccessSelectedQueryModel request, int? page = null, int? size = null) {
            return await _userCurrentAccessSelectedRepository.FindAllAsync(
                filter: UserCurrentAccessSelectedFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<UserCurrentAccessSelected>(),
                selector: x => x.ProjectedAs<UserCurrentAccessSelectedDTO>());
        }
		public async Task<IEnumerable<UserCurrentAccessSelectedListiningDTO>> GetAllSummary(UserCurrentAccessSelectedQueryModel request, int? page = null, int? size = null)
        {
            return await _userCurrentAccessSelectedRepository.FindAllAsync(
                filter: UserCurrentAccessSelectedFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<UserCurrentAccessSelected>(),
                selector: x => x.ProjectedAs<UserCurrentAccessSelectedListiningDTO>());
        }

		public Task<DomainResponse> Create(UserCurrentAccessSelectedDTO request, bool updateIfExists = true, UserCurrentAccessSelectedQueryModel searchQuery = null) { return _mediator.Send(new CreateUserCurrentAccessSelectedCommand(_logRequestContext, request)); }
		public async Task<int> CountAsync(UserCurrentAccessSelectedQueryModel request) { return await _userCurrentAccessSelectedRepository.CountAsync(filter: UserCurrentAccessSelectedFilters.GetFilters(request, isOrSpecification: true)); }
		public Task Update(UserCurrentAccessSelectedQueryModel searchQuery, UserCurrentAccessSelectedDTO request, bool createIfNotExists = true) { return _mediator.Send(new UpdateUserCurrentAccessSelectedCommand(_logRequestContext, searchQuery, request)); }
		public Task<DomainResponse> DeleteRange(UserCurrentAccessSelectedQueryModel request){ return _mediator.Send(new DeleteRangeUserCurrentAccessSelectedCommand(_logRequestContext, request)); }
		public Task<DomainResponse> Delete(UserCurrentAccessSelectedQueryModel request){ return _mediator.Send(new DeleteUserCurrentAccessSelectedCommand(_logRequestContext, request)); }
	}
	public partial class UserProfileListAppService : BaseAppService, IUserProfileListAppService {	
		public IUserProfileListRepository _userProfileListRepository;
		public UserProfileListAppService(IMediator mediator, Niu.Nutri.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IUserProfileListRepository userProfileListRepository) : base(ctx, mediator) { _userProfileListRepository = userProfileListRepository; }	
		public async Task<UserProfileListDTO> Get(UserProfileListQueryModel request) {
            return (await _userProfileListRepository.FindAsync(filter: UserProfileListFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification), selector: x => x.ProjectedAs<UserProfileListDTO>()));
        }
		public void Dispose()
        {
			_userProfileListRepository = null;
        }
		public async Task<IEnumerable<T>> GetAll<T>(UserProfileListQueryModel request, int? page = null, int? size = null, Expression<Func<UserProfileList, T>> selector = null) {
			return await _userProfileListRepository.SelectAllAsync(
                filter: UserProfileListFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<UserProfileList>(),
                selector: selector);
		}
		public async Task<T> Select<T>(UserProfileListQueryModel request, Expression<Func<UserProfileList, T>> selector = null)
        {
            return (await _userProfileListRepository.FindAsync(filter: UserProfileListFilters.GetFilters(request, isOrSpecification: true), selector: selector));
        }
        public async Task<IEnumerable<UserProfileListDTO>> GetAll(UserProfileListQueryModel request, int? page = null, int? size = null) {
            return await _userProfileListRepository.FindAllAsync(
                filter: UserProfileListFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<UserProfileList>(),
                selector: x => x.ProjectedAs<UserProfileListDTO>());
        }
		public async Task<IEnumerable<UserProfileListListiningDTO>> GetAllSummary(UserProfileListQueryModel request, int? page = null, int? size = null)
        {
            return await _userProfileListRepository.FindAllAsync(
                filter: UserProfileListFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<UserProfileList>(),
                selector: x => x.ProjectedAs<UserProfileListListiningDTO>());
        }

		public Task<DomainResponse> Create(UserProfileListDTO request, bool updateIfExists = true, UserProfileListQueryModel searchQuery = null) { return _mediator.Send(new CreateUserProfileListCommand(_logRequestContext, request)); }
		public async Task<int> CountAsync(UserProfileListQueryModel request) { return await _userProfileListRepository.CountAsync(filter: UserProfileListFilters.GetFilters(request, isOrSpecification: true)); }
		public Task Update(UserProfileListQueryModel searchQuery, UserProfileListDTO request, bool createIfNotExists = true) { return _mediator.Send(new UpdateUserProfileListCommand(_logRequestContext, searchQuery, request)); }
		public Task<DomainResponse> DeleteRange(UserProfileListQueryModel request){ return _mediator.Send(new DeleteRangeUserProfileListCommand(_logRequestContext, request)); }
		public Task<DomainResponse> Delete(UserProfileListQueryModel request){ return _mediator.Send(new DeleteUserProfileListCommand(_logRequestContext, request)); }
	}
	public partial class UserProfileAppService : BaseAppService, IUserProfileAppService {	
		public IUserProfileRepository _userProfileRepository;
		public UserProfileAppService(IMediator mediator, Niu.Nutri.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IUserProfileRepository userProfileRepository) : base(ctx, mediator) { _userProfileRepository = userProfileRepository; }	
		public async Task<UserProfileDTO> Get(UserProfileQueryModel request) {
            return (await _userProfileRepository.FindAsync(filter: UserProfileFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification), selector: x => x.ProjectedAs<UserProfileDTO>()));
        }
		public void Dispose()
        {
			_userProfileRepository = null;
        }
		public async Task<IEnumerable<T>> GetAll<T>(UserProfileQueryModel request, int? page = null, int? size = null, Expression<Func<UserProfile, T>> selector = null) {
			return await _userProfileRepository.SelectAllAsync(
                filter: UserProfileFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<UserProfile>(),
                selector: selector);
		}
		public async Task<T> Select<T>(UserProfileQueryModel request, Expression<Func<UserProfile, T>> selector = null)
        {
            return (await _userProfileRepository.FindAsync(filter: UserProfileFilters.GetFilters(request, isOrSpecification: true), selector: selector));
        }
        public async Task<IEnumerable<UserProfileDTO>> GetAll(UserProfileQueryModel request, int? page = null, int? size = null) {
            return await _userProfileRepository.FindAllAsync(
                filter: UserProfileFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<UserProfile>(),
                selector: x => x.ProjectedAs<UserProfileDTO>());
        }
		public async Task<IEnumerable<UserProfileListiningDTO>> GetAllSummary(UserProfileQueryModel request, int? page = null, int? size = null)
        {
            return await _userProfileRepository.FindAllAsync(
                filter: UserProfileFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<UserProfile>(),
                selector: x => x.ProjectedAs<UserProfileListiningDTO>());
        }

		public Task<DomainResponse> Create(UserProfileDTO request, bool updateIfExists = true, UserProfileQueryModel searchQuery = null) { return _mediator.Send(new CreateUserProfileCommand(_logRequestContext, request)); }
		public async Task<int> CountAsync(UserProfileQueryModel request) { return await _userProfileRepository.CountAsync(filter: UserProfileFilters.GetFilters(request, isOrSpecification: true)); }
		public Task Update(UserProfileQueryModel searchQuery, UserProfileDTO request, bool createIfNotExists = true) { return _mediator.Send(new UpdateUserProfileCommand(_logRequestContext, searchQuery, request)); }
		public Task<DomainResponse> DeleteRange(UserProfileQueryModel request){ return _mediator.Send(new DeleteRangeUserProfileCommand(_logRequestContext, request)); }
		public Task<DomainResponse> Delete(UserProfileQueryModel request){ return _mediator.Send(new DeleteUserProfileCommand(_logRequestContext, request)); }
	}
	public partial class UsersAggSettingsAppService : BaseAppService, IUsersAggSettingsAppService {	
		public IUsersAggSettingsRepository _usersAggSettingsRepository;
		public UsersAggSettingsAppService(IMediator mediator, Niu.Nutri.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IUsersAggSettingsRepository usersAggSettingsRepository) : base(ctx, mediator) { _usersAggSettingsRepository = usersAggSettingsRepository; }	
		public async Task<UsersAggSettingsDTO> Get(UsersAggSettingsQueryModel request) {
            return (await _usersAggSettingsRepository.FindAsync(filter: UsersAggSettingsFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification), selector: x => x.ProjectedAs<UsersAggSettingsDTO>()));
        }
		public void Dispose()
        {
			_usersAggSettingsRepository = null;
        }
		public async Task<IEnumerable<T>> GetAll<T>(UsersAggSettingsQueryModel request, int? page = null, int? size = null, Expression<Func<UsersAggSettings, T>> selector = null) {
			return await _usersAggSettingsRepository.SelectAllAsync(
                filter: UsersAggSettingsFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<UsersAggSettings>(),
                selector: selector);
		}
		public async Task<T> Select<T>(UsersAggSettingsQueryModel request, Expression<Func<UsersAggSettings, T>> selector = null)
        {
            return (await _usersAggSettingsRepository.FindAsync(filter: UsersAggSettingsFilters.GetFilters(request, isOrSpecification: true), selector: selector));
        }
        public async Task<IEnumerable<UsersAggSettingsDTO>> GetAll(UsersAggSettingsQueryModel request, int? page = null, int? size = null) {
            return await _usersAggSettingsRepository.FindAllAsync(
                filter: UsersAggSettingsFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<UsersAggSettings>(),
                selector: x => x.ProjectedAs<UsersAggSettingsDTO>());
        }
		public async Task<IEnumerable<UsersAggSettingsListiningDTO>> GetAllSummary(UsersAggSettingsQueryModel request, int? page = null, int? size = null)
        {
            return await _usersAggSettingsRepository.FindAllAsync(
                filter: UsersAggSettingsFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<UsersAggSettings>(),
                selector: x => x.ProjectedAs<UsersAggSettingsListiningDTO>());
        }

		public Task<DomainResponse> Create(UsersAggSettingsDTO request, bool updateIfExists = true, UsersAggSettingsQueryModel searchQuery = null) { return _mediator.Send(new CreateUsersAggSettingsCommand(_logRequestContext, request)); }
		public async Task<int> CountAsync(UsersAggSettingsQueryModel request) { return await _usersAggSettingsRepository.CountAsync(filter: UsersAggSettingsFilters.GetFilters(request, isOrSpecification: true)); }
		public Task Update(UsersAggSettingsQueryModel searchQuery, UsersAggSettingsDTO request, bool createIfNotExists = true) { return _mediator.Send(new UpdateUsersAggSettingsCommand(_logRequestContext, searchQuery, request)); }
		public Task<DomainResponse> DeleteRange(UsersAggSettingsQueryModel request){ return _mediator.Send(new DeleteRangeUsersAggSettingsCommand(_logRequestContext, request)); }
		public Task<DomainResponse> Delete(UsersAggSettingsQueryModel request){ return _mediator.Send(new DeleteUsersAggSettingsCommand(_logRequestContext, request)); }
	}
	public partial class UserAppService : BaseAppService, IUserAppService {	
		public IUserRepository _userRepository;
		public UserAppService(IMediator mediator, Niu.Nutri.CrossCutting.Infra.Log.Contexts.ILogRequestContext ctx, IUserRepository userRepository) : base(ctx, mediator) { _userRepository = userRepository; }	
		public async Task<UserDTO> Get(UserQueryModel request) {
            return (await _userRepository.FindAsync(filter: UserFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification), selector: x => x.ProjectedAs<UserDTO>()));
        }
		public void Dispose()
        {
			_userRepository = null;
        }
		public async Task<IEnumerable<T>> GetAll<T>(UserQueryModel request, int? page = null, int? size = null, Expression<Func<User, T>> selector = null) {
			return await _userRepository.SelectAllAsync(
                filter: UserFilters.GetFilters(request, isOrSpecification: request.IsOrSpecification),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<User>(),
                selector: selector);
		}
		public async Task<T> Select<T>(UserQueryModel request, Expression<Func<User, T>> selector = null)
        {
            return (await _userRepository.FindAsync(filter: UserFilters.GetFilters(request, isOrSpecification: true), selector: selector));
        }
        public async Task<IEnumerable<UserDTO>> GetAll(UserQueryModel request, int? page = null, int? size = null) {
            return await _userRepository.FindAllAsync(
                filter: UserFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
				ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<User>(),
                selector: x => x.ProjectedAs<UserDTO>());
        }
		public async Task<IEnumerable<UserListiningDTO>> GetAllSummary(UserQueryModel request, int? page = null, int? size = null)
        {
            return await _userRepository.FindAllAsync(
                filter: UserFilters.GetFilters(request, isOrSpecification: true),
                take: size,
                skip: page * size,
                ascending: request.OrderByDesc != true,
                orderBy: request.OrderBy.GetPropertyListSelector<User>(),
                selector: x => x.ProjectedAs<UserListiningDTO>());
        }

		public Task<DomainResponse> Create(UserDTO request, bool updateIfExists = true, UserQueryModel searchQuery = null) { return _mediator.Send(new CreateUserCommand(_logRequestContext, request)); }
		public async Task<int> CountAsync(UserQueryModel request) { return await _userRepository.CountAsync(filter: UserFilters.GetFilters(request, isOrSpecification: true)); }
		public Task Update(UserQueryModel searchQuery, UserDTO request, bool createIfNotExists = true) { return _mediator.Send(new UpdateUserCommand(_logRequestContext, searchQuery, request)); }
		public Task<DomainResponse> DeleteRange(UserQueryModel request){ return _mediator.Send(new DeleteRangeUserCommand(_logRequestContext, request)); }
		public Task<DomainResponse> Delete(UserQueryModel request){ return _mediator.Send(new DeleteUserCommand(_logRequestContext, request)); }
	}
}
