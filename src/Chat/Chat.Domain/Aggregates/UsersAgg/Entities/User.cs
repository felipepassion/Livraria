using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities;

namespace Niu.Nutri.Chat.Domain.Aggregates.UsersAgg.Entities
{
    public partial class User : Entity
    {
        public string Name { get; set; }

        public string? ProfilePicture { get; set; }
    }
}
