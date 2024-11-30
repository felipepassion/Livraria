using Microsoft.Extensions.Configuration;
using Niu.Nutri.Core.Infra.Data.Repositories;
using Niu.Nutri.Addresses.Infra.Data.Context;

using Niu.Nutri.Addresses.Domain.Aggregates.AddressesAgg.Entities;

namespace Niu.Nutri.Addresses.Infra.Data.Aggregates.AddressesAgg.Repositories
{
	using Niu.Nutri.Addresses.Domain.Aggregates.AddressesAgg.Repositories;
	public partial class AddressRepository : Repository<Address>, IAddressRepository { public AddressRepository(AddressesAggContext ctx) : base(ctx) { } }

	public partial class AddressesAggSettingsRepository : Repository<AddressesAggSettings>, IAddressesAggSettingsRepository { public AddressesAggSettingsRepository(AddressesAggContext ctx) : base(ctx) { } }

}
