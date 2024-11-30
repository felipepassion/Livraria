


using Niu.Nutri.Addresses.Domain.Aggregates.UsersAgg.Entities;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.ValueObjects;
using Niu.Nutri.Core.Domain.Attributes.T4;
using System.ComponentModel.DataAnnotations;

namespace Niu.Nutri.Addresses.Domain.Aggregates.AddressesAgg.Entities
{
    [MigrationOrder(4)]
    [AggregateSettingsT4, EndpointsT4(EndpointTypes.HttpAll)]
    public class AddressesAggSettings : BaseAggregateSettings
    {
        [Required]
        public int UserId { get; set; }

        [IgnorePropertyT4OnRequest]
        public User User { get; set; }
    }
}
