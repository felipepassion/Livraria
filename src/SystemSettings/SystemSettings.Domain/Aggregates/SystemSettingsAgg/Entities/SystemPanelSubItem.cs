using Niu.Nutri.Core.Application.DTO.Attributes;
using Niu.Nutri.Core.Domain.Attributes.T4;
using Niu.Nutri.SystemSettings.Domain.Aggregates.SystemSettingsAgg.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace Niu.Nutri.SystemSettings.Domain.Aggregates.SystemSettingsAgg.Entities
{
    [Steppable(1), EndpointsT4(EndpointTypes.HttpAll), H2("Submenu")]
    public class SystemPanelSubItem : BasePanel
    {
        [NotRequiredOnFrontT4, ListingPicker]
        public List<SystemPanelSubItem> SubItems { get; set; }
        
        public int? SystemPanelSubItemId { get; set; }

        [Required]
        public int SystemPanelId { get; set; }

        public bool IsSubItem { get; set; } = false;

        [Required]
        public int Position { get; set; }
    }
}
