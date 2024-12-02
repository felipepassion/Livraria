
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests;

using Core.Application.DTO.Aggregates.CommonAgg.Models;
using Core.Application.DTO.Attributes;

public partial class LivroDTO : EntityDTO
	{
	    public  string Titulo { get; set; }
	    public  string Editora { get; set; }
	    public int? Edicao { get; set; } 
	    public  System.DateTime AnoPublicacao { get; set; }
	    public List<Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests.AutorDTO>? Autores { get; set; } = new List<Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests.AutorDTO>();
	    public List<Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests.AssuntoDTO>? Assuntos { get; set; } = new List<Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests.AssuntoDTO>();
	}
