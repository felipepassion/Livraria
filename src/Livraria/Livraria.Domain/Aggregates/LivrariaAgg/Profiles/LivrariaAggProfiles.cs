
namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Profiles;

using Entities;
using AutoMapper;
using Application.DTO.Aggregates.LivrariaAgg.Requests;

public partial class LivrariaAggProfile : Profile
{
	public LivrariaAggProfile()
	{
		CreateMap<LivroDTO, Book>().ReverseMap();
		CreateMap<AutorDTO, Author>().ReverseMap();
		CreateMap<AssuntoDTO, Subject>().ReverseMap();
		CreateMap<AutorLivroDTO, AutorLivro>().ReverseMap();
		CreateMap<AssuntoLivroDTO, AssuntoLivro>().ReverseMap();
	}
}
