using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities;
using Niu.Nutri.Core.Domain.Attributes.T4;

namespace Niu.Nutri.SystemSettings.Domain.Aggregates.UsersAgg.Entities
{
    [EndpointsT4]
    public class UserProfile : Entity
    {
        public string? Code { get; set; }
        public List<UserProfileAccess> Accesses { get; set; } = new List<UserProfileAccess>();
        public List<UserProfileList> AccessesList { get; set; }
    }
}
