using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities;
using Niu.Nutri.Core.Domain.Attributes.T4;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities
{
    [EndpointsT4(EndpointTypes.HttpAll)]
    public partial class Assunto : Entity
    {
        [Key, Column("CodAs")]
        public override int Id { get; set; }

        [StringLength(20)]
        public string Descricao { get; set; }

        public List<Livro> Livros { get; set; }
    }
}
