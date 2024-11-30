using Newtonsoft.Json;
using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models;
using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models.Auth;
using Niu.Nutri.Core.Application.DTO.Extensions;
using Niu.Nutri.Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;
using Niu.Nutri.Shared.Blazor.Authentication.Client.Providers;
using System.Net.Http.Json;

namespace Niu.Nutri.WebApp.Client.Services.Auth
{
    public class AuthorizeApi : IAuthorizeApi
    {
        private readonly HttpClient _httpClient;

        public AuthorizeApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<GetHttpResponseDTO> Register(RegisterParametersDTO registerParameters)
        {
            //var stringContent = new StringContent(JsonSerializer.Serialize(registerParameters), Encoding.UTF8, "application/json");
            var result = await _httpClient.PostAsJsonAsync("api/Authorize/Register", registerParameters);
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
            var content = JsonConvert.DeserializeObject<GetHttpResponseDTO>(await result.Content.ReadAsStringAsync());

            return content;
        }

        public async Task<GetHttpResponseDTO> ForgotPassword(ForgotPasswordParametersDTO forgotPasswordParameters)
        {
            //var stringContent = new StringContent(JsonSerializer.Serialize(registerParameters), Encoding.UTF8, "application/json");
            var result = await _httpClient.PostAsJsonAsync("api/Authorize/ForgotPassword", forgotPasswordParameters);
            var content = await result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<GetHttpResponseDTO>(content);
        }

        public async Task<GetHttpResponseDTO> VerifyForgotPasswordToken(TokenModelDTO forgotPasswordParameters)
        {
            //var stringContent = new StringContent(JsonSerializer.Serialize(registerParameters), Encoding.UTF8, "application/json");
            var result = await _httpClient.PostAsJsonAsync("api/Authorize/VerifyForgotPasswordToken", forgotPasswordParameters);
            var content = await result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<GetHttpResponseDTO>(content);
        }

        public async Task<GetHttpResponseDTO> CreatePassword(CreatePasswordParametersDTO forgotPasswordParameters)
        {
            //var stringContent = new StringContent(JsonSerializer.Serialize(registerParameters), Encoding.UTF8, "application/json");
            var result = await _httpClient.PostAsJsonAsync($"api/Authorize/{(string.IsNullOrWhiteSpace(forgotPasswordParameters.Code) ? "CreatePassword" : "ResetPassword")}", forgotPasswordParameters);
            var content = await result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<GetHttpResponseDTO>(content);
        }

        public async Task<GetHttpResponseDTO<DomainResponseDTO>> CreateAsync<T>(T request)
            where T : IEntityDTO, new()
        {
            return await this._httpClient.CreateAsync<T>(request);
        }

        public async Task<GetHttpResponseDTO> Logout()
        {
            var result = await _httpClient.PostAsync($"api/Authorize/Logout", null);
            var content = await result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<GetHttpResponseDTO>(content);
        }
    }
}
