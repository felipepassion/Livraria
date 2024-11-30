using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Repositories;
using Niu.Nutri.Addresses.Domain.Aggregates.AddressesAgg.Entities;
using Niu.Nutri.Addresses.Domain.Aggregates.UsersAgg.Entities;

namespace Niu.Nutri.Addresses.Domain.Aggregates.AddressesAgg.Repositories 
{
	public partial interface IAddressRepository : IRepository<Address> { }
	public partial interface IAddressMongoRepository : IMongoRepository<Address> { }

	public partial interface IAddressesAggSettingsRepository : IRepository<AddressesAggSettings> { }
	public partial interface IAddressesAggSettingsMongoRepository : IMongoRepository<AddressesAggSettings> { }

}
namespace Niu.Nutri.Addresses.Domain.Aggregates.UsersAgg.Repositories 
{
	public partial interface IUserRepository : IRepository<User> { }
	public partial interface IUserMongoRepository : IMongoRepository<User> { }

}
