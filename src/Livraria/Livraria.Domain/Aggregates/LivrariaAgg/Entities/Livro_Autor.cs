using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities;
using Niu.Nutri.Core.Domain.Attributes.T4;
using System.ComponentModel.DataAnnotations.Schema;

namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities
{
    [EndpointsT4(EndpointTypes.HttpAll)]
    public partial class Livro_Autor : Entity
    {
        [ForeignKey(nameof(Livro))]
        public int Livro_Codl { get; set; }

        [ForeignKey(nameof(Autor))]
        public int Autor_CodAut { get; set; }

        public Autor Autor { get; set; }
    
        public Livro Livro { get; set; }
    }
}
