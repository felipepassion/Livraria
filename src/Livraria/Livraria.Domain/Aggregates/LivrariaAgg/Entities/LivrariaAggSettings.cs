using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.ValueObjects;
using Niu.Nutri.Core.Domain.Attributes.T4;
using Niu.Nutri.Livraria.Domain.Aggregates.UsersAgg.Entities;
using System.ComponentModel.DataAnnotations;

namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities
{
    [AggregateSettingsT4, EndpointsT4(EndpointTypes.HttpAll)]
    public class LivrariaAggSettings : BaseAggregateSettings
    {
        [Required]
        public int UserId { get; set; }

        [IgnorePropertyT4OnRequest]
        public User User { get; set; }
    }
}
