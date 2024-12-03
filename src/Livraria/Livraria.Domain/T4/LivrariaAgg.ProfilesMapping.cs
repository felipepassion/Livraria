using AutoMapper;
namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Profiles
{
    public class LivrariaAggCoreProfile : Core.Domain.Aggregates.CommonAgg.Profiles.CoreAggProfile { }
}

namespace Niu.Nutri.Livraria.Domain.Aggregates.LivrariaAgg.Profiles
{
	using Application.DTO.Aggregates.LivrariaAgg.Requests;
	using Entities;
	public partial class LivrariaAggProfile : Profile
	{
		public LivrariaAggProfile()
		{
			CreateMap<Livro_AutorDTO, Livro_Autor>().ReverseMap();;
			CreateMap<LivroDTO, Livro>().ReverseMap();;
			CreateMap<AssuntoDTO, Assunto>().ReverseMap();;
			CreateMap<Livro_AssuntoDTO, Livro_Assunto>().ReverseMap();;
			CreateMap<AutorDTO, Autor>().ReverseMap();;
			ConfigureAdditionalProfiles();
		}
		partial void ConfigureAdditionalProfiles();
	}
}

