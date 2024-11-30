using Microsoft.Extensions.Configuration;
using Niu.Nutri.Core.Infra.Data.Repositories;
using Niu.Nutri.Users.Infra.Data.Context;

using Niu.Nutri.Users.Domain.Aggregates.UsersAgg.Entities;
using Niu.Nutri.Users.Domain.Aggregates.SystemSettingsAgg.Entities;

namespace Niu.Nutri.Users.Infra.Data.Aggregates.UsersAgg.Repositories
{
	using Niu.Nutri.Users.Domain.Aggregates.UsersAgg.Repositories;
	public partial class UserProfileAccessRepository : Repository<UserProfileAccess>, IUserProfileAccessRepository { public UserProfileAccessRepository(UsersAggContext ctx) : base(ctx) { } }

	public partial class UserCurrentAccessSelectedRepository : Repository<UserCurrentAccessSelected>, IUserCurrentAccessSelectedRepository { public UserCurrentAccessSelectedRepository(UsersAggContext ctx) : base(ctx) { } }

	public partial class UserProfileListRepository : Repository<UserProfileList>, IUserProfileListRepository { public UserProfileListRepository(UsersAggContext ctx) : base(ctx) { } }

	public partial class UserProfileRepository : Repository<UserProfile>, IUserProfileRepository { public UserProfileRepository(UsersAggContext ctx) : base(ctx) { } }

	public partial class UsersAggSettingsRepository : Repository<UsersAggSettings>, IUsersAggSettingsRepository { public UsersAggSettingsRepository(UsersAggContext ctx) : base(ctx) { } }

	public partial class UserRepository : Repository<User>, IUserRepository { public UserRepository(UsersAggContext ctx) : base(ctx) { } }

}
namespace Niu.Nutri.Users.Infra.Data.Aggregates.SystemSettingsAgg.Repositories
{
	using Niu.Nutri.Users.Domain.Aggregates.SystemSettingsAgg.Repositories;
	public partial class SystemPanelSubItemRepository : Repository<SystemPanelSubItem>, ISystemPanelSubItemRepository { public SystemPanelSubItemRepository(UsersAggContext ctx) : base(ctx) { } }

	public partial class SystemPanelRepository : Repository<SystemPanel>, ISystemPanelRepository { public SystemPanelRepository(UsersAggContext ctx) : base(ctx) { } }

	public partial class SystemPanelGroupRepository : Repository<SystemPanelGroup>, ISystemPanelGroupRepository { public SystemPanelGroupRepository(UsersAggContext ctx) : base(ctx) { } }

}
