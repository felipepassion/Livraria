
namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Profiles;

using Entities;
using AutoMapper;
using Application.DTO.Aggregates.LivrariaAgg.Requests;

public partial class LivrariaAggProfile : Profile
{
	public LivrariaAggProfile()
	{
		CreateMap<LivroDTO, Livro>().ReverseMap();
		CreateMap<AutorDTO, Autor>().ReverseMap();
		CreateMap<AssuntoDTO, Assunto>().ReverseMap();
		CreateMap<Livro_AutorDTO, Livro_Autor>().ReverseMap();
		CreateMap<Livro_AssuntoDTO, Livro_Assunto>().ReverseMap();
	}
}
