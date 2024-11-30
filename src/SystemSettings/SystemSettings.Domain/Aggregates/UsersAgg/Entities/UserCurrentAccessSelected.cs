using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities;

namespace Niu.Nutri.SystemSettings.Domain.Aggregates.UsersAgg.Entities
{
    [Core.Domain.Attributes.T4.EndpointsT4]
    public class UserCurrentAccessSelected : Entity
    {
        public int? UserProfileId { get; set; }
    }
}
