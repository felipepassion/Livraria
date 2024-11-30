using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities;
using Niu.Nutri.Core.Domain.Attributes.T4;
using System.ComponentModel.DataAnnotations;

namespace Niu.Nutri.Users.Domain.Aggregates.SystemSettingsAgg.Entities
{
    [EndpointsT4(EndpointTypes.HttpAll)]
    public class SystemPanelSubItem : Entity
    {
        public int? SystemPanelSubItemId { get; set; }
        
        [Required]
        public int SystemPanelId { get; set; }
        
        [Required]
        public bool IsSubItem { get; set; }
        
        [Required]
        public bool LinkDireto { get; set; }
        
        [Required]
        public string Description { get; set; }
        
        public string? Url { get; set; }

    }
}