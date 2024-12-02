using System.ComponentModel.DataAnnotations.Schema;

namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities
{
    public partial class Livro_Autor
    {
        [ForeignKey(nameof(Livro))]
        public int Livro_Codl { get; set; }

        [ForeignKey(nameof(Autor))]
        public int Autor_CodAut { get; set; }

        public Autor Autor { get; set; }
    
        public Livro Livro { get; set; }
    }
}
