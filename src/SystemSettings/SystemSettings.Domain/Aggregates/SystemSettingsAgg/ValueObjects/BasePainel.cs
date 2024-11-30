using Niu.Nutri.Core.Application.DTO.Attributes;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities;
using Niu.Nutri.Core.Domain.Attributes.T4;
using System.ComponentModel.DataAnnotations;

namespace Niu.Nutri.SystemSettings.Domain.Aggregates.SystemSettingsAgg.ValueObjects
{
    public class BasePanel : SteppableEntity
    {
        [Step(1)]
        public string? Icon { get; set; }

        [Step(1), Title, DisplayOnList, Required]
        public string Description { get; set; }

        [Step(1), Subtitle, DisplayOnList]
        public string? Url { get; set; }

        [Step(1), Required]
        public bool LinkDireto { get; set; } = true;
    }
}
