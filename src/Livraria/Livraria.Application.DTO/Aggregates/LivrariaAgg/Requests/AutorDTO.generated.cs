
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests;

using Core.Application.DTO.Aggregates.CommonAgg.Models;
using Core.Application.DTO.Attributes;

public partial class AutorDTO : EntityDTO
	{
	    public  string? Nome { get; set; }
	    public List<Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests.LivroDTO>? Livros { get; set; } = new List<Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests.LivroDTO>();
	}
