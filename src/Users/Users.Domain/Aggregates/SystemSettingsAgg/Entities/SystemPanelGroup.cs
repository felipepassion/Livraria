using Niu.Nutri.Core.Application.DTO.Attributes;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities;
using Niu.Nutri.Core.Domain.Attributes.T4;
using Niu.Nutri.Users.Domain.Aggregates.UsersAgg.Entities;
using System.ComponentModel;

namespace Niu.Nutri.Users.Domain.Aggregates.SystemSettingsAgg.Entities
{
    [EndpointsT4(EndpointTypes.HttpAll)]
    public class SystemPanelGroup : Entity
    {
        [Title, DisplayName("Description")]
        public string Description { get; set; }

        [IgnorePropertyT4]
        public List<UserProfileAccess> UserProfileAccesses { get; set; }

        [DisplayName("Menus"), DisplayOnList]
        public List<SystemPanel> SubItems { get; set; }
    }
}