using Niu.Nutri.Core.Application.DTO.Attributes;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities;
using Niu.Nutri.Core.Domain.Attributes.T4;

namespace Niu.Nutri.Users.Domain.Aggregates.UsersAgg.Entities
{
    [EndpointsT4(EndpointTypes.HttpAll)]
    public class UserProfileList : SteppableEntity
    {
        public int? UserId { get; set; }

        [ListingPicker]
        public List<UserProfile> UserProfiles { get; set; } = new List<UserProfile>();
    }
}
