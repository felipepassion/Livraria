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
			CreateMap<LivrariaAggSettingsDTO, LivrariaAggSettings>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<LivrariaAggSettings, LivrariaAggSettingsDTO>();
			CreateMap<Livro_AutorDTO, Livro_Autor>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<Livro_Autor, Livro_AutorDTO>();
			CreateMap<AutorDTO, Autor>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<Autor, AutorDTO>();
			CreateMap<AssuntoDTO, Assunto>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<Assunto, AssuntoDTO>();
			CreateMap<Livro_AssuntoDTO, Livro_Assunto>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<Livro_Assunto, Livro_AssuntoDTO>();
			CreateMap<LivroDTO, Livro>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<Livro, LivroDTO>();
			ConfigureAdditionalProfiles();
		}
		partial void ConfigureAdditionalProfiles();
	}
}

namespace Niu.Nutri.Livraria.Domain.Aggregates.UsersAgg.Profiles
{
	using Application.DTO.Aggregates.UsersAgg.Requests;
	using Entities;
	public partial class UsersAggProfile : Profile
	{
		public UsersAggProfile()
		{
			CreateMap<UserDTO, User>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<User, UserDTO>();
			ConfigureAdditionalProfiles();
		}
		partial void ConfigureAdditionalProfiles();
	}
}

