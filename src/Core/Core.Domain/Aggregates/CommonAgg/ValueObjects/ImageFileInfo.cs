using Niu.Nutri.Core.Application.DTO.Attributes;
using Niu.Nutri.Core.Domain.Attributes.T4;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Niu.Nutri.Core.Domain.Aggregates.CommonAgg.ValueObjects
{
    [Keyless]
    public class ImageFileInfo
    {
        [Required, RegisterOrder(0), IgnorePropertyT4, DisplayOnList]
        public byte[]? Image { get; set; }

        public string Src { get; set; }
    }
}
