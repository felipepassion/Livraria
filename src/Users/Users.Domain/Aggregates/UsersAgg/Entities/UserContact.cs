using Niu.Nutri.Core.Application.DTO.Attributes;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities;
using Niu.Nutri.Core.Domain.Attributes.T4;
using System.ComponentModel;

namespace Niu.Nutri.Users.Domain.Aggregates.UsersAgg.Entities
{
    public class UserContact : Entity
    {
        [Step(1)]
        [IgnoreValidation]
        public List<UserContactNumber>? Contacts { get; set; }

        [Step(1)]
        [RequiredT4]
        [DisplayName("E-Mail"), DisplayOnList(7)]
        public string? Email { get; set; }
    }
}
