using Microsoft.Extensions.Configuration;
using Niu.Nutri.Core.Infra.Data.Repositories;
using Niu.Nutri.SystemSettings.Infra.Data.Context;

using Niu.Nutri.SystemSettings.Domain.Aggregates.UsersAgg.Entities;
using Niu.Nutri.SystemSettings.Domain.Aggregates.SystemSettingsAgg.Entities;

namespace Niu.Nutri.SystemSettings.Infra.Data.Aggregates.UsersAgg.Repositories
{
	using Niu.Nutri.SystemSettings.Domain.Aggregates.UsersAgg.Repositories;
	public partial class UserProfileAccessRepository : Repository<UserProfileAccess>, IUserProfileAccessRepository { public UserProfileAccessRepository(SystemSettingsAggContext ctx) : base(ctx) { } }

	public partial class UserCurrentAccessSelectedRepository : Repository<UserCurrentAccessSelected>, IUserCurrentAccessSelectedRepository { public UserCurrentAccessSelectedRepository(SystemSettingsAggContext ctx) : base(ctx) { } }

	public partial class UserProfileListRepository : Repository<UserProfileList>, IUserProfileListRepository { public UserProfileListRepository(SystemSettingsAggContext ctx) : base(ctx) { } }

	public partial class UserProfileRepository : Repository<UserProfile>, IUserProfileRepository { public UserProfileRepository(SystemSettingsAggContext ctx) : base(ctx) { } }

	public partial class UserRepository : Repository<User>, IUserRepository { public UserRepository(SystemSettingsAggContext ctx) : base(ctx) { } }

}
namespace Niu.Nutri.SystemSettings.Infra.Data.Aggregates.SystemSettingsAgg.Repositories
{
	using Niu.Nutri.SystemSettings.Domain.Aggregates.SystemSettingsAgg.Repositories;
	public partial class SystemPanelSubItemRepository : Repository<SystemPanelSubItem>, ISystemPanelSubItemRepository { public SystemPanelSubItemRepository(SystemSettingsAggContext ctx) : base(ctx) { } }

	public partial class SystemPanelRepository : Repository<SystemPanel>, ISystemPanelRepository { public SystemPanelRepository(SystemSettingsAggContext ctx) : base(ctx) { } }

	public partial class SystemPanelGroupRepository : Repository<SystemPanelGroup>, ISystemPanelGroupRepository { public SystemPanelGroupRepository(SystemSettingsAggContext ctx) : base(ctx) { } }

	public partial class CargaTabelaRepository : Repository<CargaTabela>, ICargaTabelaRepository { public CargaTabelaRepository(SystemSettingsAggContext ctx) : base(ctx) { } }

	public partial class SystemSettingsAggSettingsRepository : Repository<SystemSettingsAggSettings>, ISystemSettingsAggSettingsRepository { public SystemSettingsAggSettingsRepository(SystemSettingsAggContext ctx) : base(ctx) { } }

}
