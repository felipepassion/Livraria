using Niu.Nutri.Chat.Domain.Aggregates.UsersAgg.Entities;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.ValueObjects;
using Niu.Nutri.Core.Domain.Attributes.T4;
using System.ComponentModel.DataAnnotations;

namespace Niu.Nutri.Chat.Domain.Aggregates.ChatAgg.Entities
{
    [AggregateSettingsT4, EndpointsT4(EndpointTypes.HttpAll)]
    public class ChatAggSettings : BaseAggregateSettings
    {
        [Required]
        public int UserId { get; set; }

        [IgnorePropertyT4OnRequest]
        public User User { get; set; }
    }
}
