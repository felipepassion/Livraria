using AutoMapper;
using Niu.Nutri.Users.Application.DTO.Aggregates.UsersAgg.Requests;
using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models.Auth;

namespace Niu.Nutri.Shared.Blazor.Authentication.Profiles
{
    public partial class AuthenticationParametersProfile : Profile
    {
        public AuthenticationParametersProfile()
        {
            CreateMap<RegisterParametersDTO, UserDTO>()
                .ForMember(x => x.Contact, opt => opt.MapFrom(x => new UserContactDTO { Email = x.UserName, Contacts = new List<UserContactNumberDTO>() { new UserContactNumberDTO { Number = x.PhoneNumber } } }));
        }
    }
}
