using Niu.Nutri.Core.Domain.Attributes.T4;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Entities;
using System.ComponentModel.DataAnnotations;

namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Entities;

[EndpointsT4(EndpointTypes.HttpAll)]
public partial class Livro : Entity
{
    [Required]
    public string Titulo { get; set; }

    [Required]
    public string Editora { get; set; }

    [Required]
    public string Edicao { get; set; }

    [Required]
    public DateTime AnoPublicacao { get; set; }

    public List<Autor> Autores { get; set; } = new();

    public List<Assunto> Assuntos { get; set; } = new();
}
