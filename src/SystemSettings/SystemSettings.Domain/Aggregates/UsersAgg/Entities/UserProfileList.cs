using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities;

namespace Niu.Nutri.SystemSettings.Domain.Aggregates.UsersAgg.Entities
{
    [Core.Domain.Attributes.T4.EndpointsT4]
    public class UserProfileList : Entity
    {
        public int? UserId { get; set; }
        public List<UserProfile> UserProfiles { get; set; } = new List<UserProfile>();
    }
}
