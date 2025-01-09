
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests;

using Core.Application.DTO.Aggregates.CommonAgg.Models;
using Core.Application.DTO.Attributes;

public partial class AssuntoLivroDTO 
	{
	    public  int Livro_Codl { get; set; }
	    public  int Assunto_CodAut { get; set; }
	    public Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests.AssuntoDTO? Assunto { get; set; } 
	    public Niu.Nutri.Livraria.Application.DTO.Aggregates.LivrariaAgg.Requests.LivroDTO? Livro { get; set; } 
	}
