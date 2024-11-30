using Microsoft.AspNetCore.Components.Authorization;

namespace Niu.Nutri.Shared.Blazor.Authentication.Client.Providers
{
    public interface ICookieAuthenticationStateProvider
    {
        Task<AuthenticationState> GetAuthenticationStateAsync();
        Task<Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses.GetHttpResponseDTO> LoginAndGetAuthenticationState(string userName, string password, bool remember);
    }
}