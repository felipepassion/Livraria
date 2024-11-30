using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models.Auth;
using Niu.Nutri.Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;

namespace Niu.Nutri.WebApp.Client.Services.Auth
{
    public interface IAuthorizeApi
    {
        Task<GetHttpResponseDTO> Register(RegisterParametersDTO registerParameters);
        Task<GetHttpResponseDTO> ForgotPassword(ForgotPasswordParametersDTO forgotPasswordParameters);
        Task<GetHttpResponseDTO> VerifyForgotPasswordToken(TokenModelDTO forgotPasswordParameters);
        Task<GetHttpResponseDTO> CreatePassword(CreatePasswordParametersDTO forgotPasswordParameters);
        Task<GetHttpResponseDTO<DomainResponseDTO>> CreateAsync<T>(T request) where T : IEntityDTO, new();
        Task<GetHttpResponseDTO> Logout();
    }
}
