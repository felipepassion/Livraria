using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Niu.Nutri.Core.Application.DTO.Attributes;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities;
using Niu.Nutri.Core.Domain.Attributes.T4;
using Niu.Nutri.SystemSettings.Domain.Aggregates.UsersAgg.Entities;

namespace Niu.Nutri.SystemSettings.Domain.Aggregates.SystemSettingsAgg.Entities
{
    [EndpointsT4(EndpointTypes.HttpAll), Steppable(1), H2("Grupo de Menus / Painéis"), DoNotReplaceAfterGenerated]
    public class SystemPanelGroup : SteppableEntity
    {
        [Step(1)]
        public string? Icon { get; set; }

        [Step(1), Title, DisplayOnList, Required, Unique, DisplayName("Description")]
        public string Description { get; set; }

        [Step(1), Subtitle, DisplayOnList, Required, Unique, DisplayName("Code")]
        public string Code { get; set; }

        [Step(1), DisplayOnList]
        public bool IsPrivate { get; set; }

        [Step(1), ListingPicker, DisplayName("Menus"), DisplayOnList]
        public List<SystemPanel> SubItems { get; set; } = [];

        [ListingPicker]
        public List<UserProfileAccess> AccessesOfMyProfile { get; set; } = [];
    }
}