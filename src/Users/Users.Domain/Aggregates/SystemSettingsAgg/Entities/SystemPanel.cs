using Niu.Nutri.Core.Application.DTO.Attributes;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities;
using Niu.Nutri.Core.Domain.Attributes.T4;
using Niu.Nutri.Users.Domain.Aggregates.UsersAgg.Entities;

namespace Niu.Nutri.Users.Domain.Aggregates.SystemSettingsAgg.Entities
{
    [EndpointsT4(EndpointTypes.HttpAll)]
    public class SystemPanel : Entity
    {
        public string Description { get; set; }

        public List<SystemPanelSubItem> SubItems { get; set; }
        public List<UserProfileAccess> AccessesOfMyProfile { get; set; }

        [IgnorePropertyT4]
        public List<SystemPanelGroup> GroupOfMenus { get; set; }
    }
}