using Niu.Nutri.Core.Application.DTO.Attributes;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.ValueObjects;
using Niu.Nutri.Core.Domain.Attributes.T4;
using System.ComponentModel.DataAnnotations;

namespace Niu.Nutri.Users.Domain.Aggregates.UsersAgg.Entities
{
    [MigrationOrder(3), AggregateSettingsT4, EndpointsT4(EndpointTypes.HttpAll), DoNotReplaceAfterGenerated]
    public class UsersAggSettings : BaseAggregateSettings
    {
        [Required]
        public int UserId { get; set; }
    }
}
