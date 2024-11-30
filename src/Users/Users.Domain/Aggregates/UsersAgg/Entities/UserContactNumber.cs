using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities;
using Niu.Nutri.Core.Domain.Attributes.T4;

namespace Niu.Nutri.Users.Domain.Aggregates.UsersAgg.Entities
{
    public class UserContactNumber : Entity
    {
        [RequiredT4("'Contato' precisa ser informado")]
        public string Number { get; set; }
    }
}
