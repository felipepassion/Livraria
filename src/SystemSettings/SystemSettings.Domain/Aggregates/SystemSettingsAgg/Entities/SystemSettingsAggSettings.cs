using Niu.Nutri.Core.Application.DTO.Attributes;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.ValueObjects;
using Niu.Nutri.Core.Domain.Attributes.T4;

namespace Niu.Nutri.SystemSettings.Domain.Aggregates.SystemSettingsAgg.Entities
{
    [MigrationOrder(1), AggregateSettingsT4, EndpointsT4(EndpointTypes.HttpAll), DoNotReplaceAfterGenerated]
    public class SystemSettingsAggSettings : BaseAggregateSettings
    {

    }
}
