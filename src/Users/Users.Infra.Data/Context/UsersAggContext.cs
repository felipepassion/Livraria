using Microsoft.EntityFrameworkCore;
using Niu.Nutri.Users.Infra.Data.Aggregates.IdentityAgg.Mappings;

namespace Niu.Nutri.Users.Infra.Data.Context
{
    public partial class UsersAggContext
    {
        partial void ApplyAdditionalMappings(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ApplicationUserMapping());
        }
    }
}
