using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities;
using Niu.Nutri.Core.Domain.Attributes.T4;

namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities
{
    [EndpointsT4(EndpointTypes.HttpAll)]
    public partial class Assunto : Entity
    {
        public string Descricao { get; set; }

        public List<Livro> Livros { get; set; }
    }
}
