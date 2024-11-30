using AutoMapper;
namespace Niu.Nutri.Addresses.Domain.Aggregates.AddressesAgg.Profiles
{
    public class AddressesAggCoreProfile : Core.Domain.Aggregates.CommonAgg.Profiles.CoreAggProfile { }
}

namespace Niu.Nutri.Addresses.Domain.Aggregates.AddressesAgg.Profiles
{
	using Application.DTO.Aggregates.AddressesAgg.Requests;
	using Entities;
	public partial class AddressesAggProfile : Profile
	{
		public AddressesAggProfile()
		{
			CreateMap<AddressDTO, Address>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<Address, AddressDTO>();
			CreateMap<AddressesAggSettingsDTO, AddressesAggSettings>()
				.ForMember(x=>x.ExternalId, opt => opt.MapFrom(x=>x.ExternalId ?? Guid.NewGuid().ToString()));
			CreateMap<AddressesAggSettings, AddressesAggSettingsDTO>();
			ConfigureAdditionalProfiles();
		}
		partial void ConfigureAdditionalProfiles();
	}
}

namespace Niu.Nutri.Addresses.Domain.Aggregates.UsersAgg.Profiles
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

