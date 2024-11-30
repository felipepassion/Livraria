using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Niu.Nutri.Core.Application.DTO.Attributes;

namespace Niu.Nutri.SystemSettings.Application.DTO.Aggregates.SystemSettingsAgg.Requests
{
    public class BasePanelDTO : SteppableEntityDTO
    {
        public string? Icon { get; set; }

        [Title, Required]
        public string Description { get; set; }

        [Subtitle]
        public string? Url { get; set; }

        public bool LinkDireto { get; set; } = true;
    }
}
