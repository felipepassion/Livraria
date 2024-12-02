using Niu.Nutri.Core.Domain.Attributes.T4;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities;

[EndpointsT4(EndpointTypes.HttpAll)]
public partial class Livro_Assunto
{
    [Required]
    [ForeignKey(nameof(Livro))]
    public int Livro_Codl { get; set; }

    [Required]
    [ForeignKey(nameof(Assunto))]
    public int Assunto_CodAut { get; set; }

    public Assunto Assunto { get; set; }

    public Livro Livro { get; set; }
}