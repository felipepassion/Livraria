namespace Niu.Nutri.Livraria.Infra.Data.Aggregates.LivrariaAgg.Mappings;

using Domain.Aggregates.LivrariaAgg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public partial class AssuntoMapping : IEntityTypeConfiguration<Assunto>
{
    public void Configure(EntityTypeBuilder<Assunto> builder)
    {
    }
}
