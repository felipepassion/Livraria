using Niu.Nutri.Core.Application.DTO.Attributes;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities;
using Niu.Nutri.Core.Domain.Attributes.T4;
using Niu.Nutri.SystemSettings.Domain.Aggregates.UsersAgg.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Niu.Nutri.SystemSettings.Domain.Aggregates.SystemSettingsAgg.Entities
{
    //[DoNotReplaceAfterGenerated]
    [EndpointsT4(EndpointTypes.HttpAll), Steppable(1), H2("Sidebar")]
    public class SystemPanel : SteppableEntity
    {
        [Step(1), DisplayOnList(0)]
        public string? Icon { get; set; }

        [Step(1), Title, DisplayOnList, Required, Unique, DisplayName("Menu")]
        public string Description { get; set; }

        [Step(1), Subtitle, DisplayOnList, Required, Unique, DisplayName("Code")]
        public string Code { get; set; }

        public List<SystemPanelGroup> GroupOfMenus { get; set; } = new List<SystemPanelGroup>();

        [ListingPicker]
        public List<SystemPanelSubItem> SubItems { get; set; } = new List<SystemPanelSubItem>();

        [ListingPicker]
        public List<UserProfileAccess> AccessesOfMyProfile { get; set; } = new List<UserProfileAccess>();
    }
}