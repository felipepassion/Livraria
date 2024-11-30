using System.Linq.Expressions;

namespace Niu.Nutri.Addresses.Domain.Aggregates.AddressesAgg.Repositories
{
    public partial interface IAddressRepository
    {
        Task<List<Entities.Address>> SearchAddressesByLogradouroAsync(
            Expression<Func<Domain.Aggregates.AddressesAgg.Entities.Address, object>> groupBy,
            string searchTerm,
            int? skip = 0,
            int? take = 10);

        Task<List<Entities.Address>> SearchAddressesByBairroAsync(
            Expression<Func<Domain.Aggregates.AddressesAgg.Entities.Address, object>> groupBy,
            string city,
            string? searchTerm = null,
            int? skip = 0,
            int? take = 10);
    }
}
