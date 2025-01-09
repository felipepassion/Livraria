using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities;
using Niu.Nutri.Core.Domain.Attributes.T4;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities
{
    [EndpointsT4(EndpointTypes.HttpAll)]
    public partial class Author : Entity
    {
        [Key, Column("CodAu")]
        public override int Id { get; set; }

        [StringLength(40)]
        public string Nome { get; set; }

        public List<Book> Livros { get; set; }
    }
}
