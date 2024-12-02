

using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Niu.Nutri.Core.Application.DTO.Attributes;

namespace Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests 
{
public partial class Livro_AutorDTO : ObjectDTO
	{
	    public  int? Livro_Codl { get; set; }
	    public  int? Autor_CodAut { get; set; }
	    public Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests.AutorDTO? Autor { get; set; } 
	    public Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests.LivroDTO? Livro { get; set; } 
	}
public partial class LivroDTO : EntityDTO
	{
	    public  string Titulo { get; set; }
	    public  string Editora { get; set; }
	    public  string Edicao { get; set; }
	    public  System.DateTime AnoPublicacao { get; set; }
	    public List<Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests.AutorDTO>? Autores { get; set; } = new List<Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests.AutorDTO>();
	    public List<Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests.AssuntoDTO>? Assuntos { get; set; } = new List<Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests.AssuntoDTO>();
	}
public partial class AssuntoDTO : EntityDTO
	{
	    public  string? Descricao { get; set; }
	    public List<Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests.LivroDTO>? Livros { get; set; } = new List<Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests.LivroDTO>();
	}
public partial class Livro_AssuntoDTO : ObjectDTO
	{
	    public  int Livro_Codl { get; set; }
	    public  int Assunto_CodAut { get; set; }
	    public Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests.AssuntoDTO? Assunto { get; set; } 
	    public Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests.LivroDTO? Livro { get; set; } 
	}
public partial class AutorDTO : EntityDTO
	{
	    public  string? Nome { get; set; }
	    public List<Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests.LivroDTO>? Livros { get; set; } = new List<Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests.LivroDTO>();
	}
public partial class LivrariaAggSettingsDTO : BaseAggregateSettingsDTO
	{
	}
}
namespace Niu.Nutri.Livraria.Application.DTO.Aggregates.UsersAgg.Requests 
{
public partial class UserDTO : EntityDTO
	{
	}
}
