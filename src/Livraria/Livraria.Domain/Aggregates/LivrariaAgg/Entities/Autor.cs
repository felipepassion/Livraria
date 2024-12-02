using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities;
using Niu.Nutri.Core.Domain.Attributes.T4;
using System.ComponentModel.DataAnnotations;

namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities
{
    [EndpointsT4(EndpointTypes.HttpAll)]
    public partial class Autor : Entity
    {
        [StringLength(40)]
        public string Nome { get; set; }

        public List<Livro> Livros { get; set; }
    }
}
