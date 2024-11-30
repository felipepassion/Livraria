using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Newtonsoft.Json;
using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models.Auth;
using Niu.Nutri.Core.Application.DTO.Extensions;
using Niu.Nutri.Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;
using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Text.Json;

namespace Niu.Nutri.Shared.Blazor.Authentication.Client.Providers
{
    public class CookieAuthenticationStateProvider : AuthenticationStateProvider, ICookieAuthenticationStateProvider
    {
        private readonly HttpClient httpClient;
        private readonly IServiceProvider _provider;

        public CookieAuthenticationStateProvider(HttpClient httpClient, IServiceProvider provider)
        {
            this.httpClient = httpClient;
            this._provider = provider;
        }

        public async override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var user = new ClaimsPrincipal(new ClaimsIdentity());

            try
            {
                var requestMessage = new HttpRequestMessage(HttpMethod.Get, "/api/authorize/UserInfo");
                requestMessage.SetBrowserRequestCredentials(BrowserRequestCredentials.Include);
                var userResponse = await httpClient.SendAsync(requestMessage);
                if (userResponse.IsSuccessStatusCode)
                {
                    var userJson = await userResponse.Content.ReadAsStringAsync();
                    var jsonSOptions = new JsonSerializerOptions { AllowTrailingCommas = true, PropertyNameCaseInsensitive = true };
                    var userInfo = System.Text.Json.JsonSerializer.Deserialize<UserInfoDTO>(userJson, jsonSOptions);
                    if (userInfo != null)
                    {
                        var claims = new List<Claim>
                    {
                        new(ClaimTypes.NameIdentifier, userInfo.UserId!),
                        new(ClaimTypes.Name, userInfo.Email!),
                        new(ClaimTypes.Email, userInfo.Email!)
                    };
                        var id = new ClaimsIdentity(claims, nameof(CookieAuthenticationStateProvider));
                        user = new ClaimsPrincipal(id);
                        var test = user.GetUserId();
                    }
                }
                return new AuthenticationState(user);
            }
            catch { return new AuthenticationState(user); }
        }

        record LoginResponse
        {
            public required string Title { get; set; }
            public required int Status { get; set; }
        }

        public async Task<GetHttpResponseDTO> LoginAndGetAuthenticationState(string userName, string password, bool rememberMe = false)
        {
            var model = new LoginParametersDTO
            {
                EmailOrPhone = userName,
                Password = password,
                RememberMe = rememberMe
            };

            //model.Email = "fred@gmail.com"; model.Password = "Fred@123";
            var jsonContent = new StringContent(System.Text.Json.JsonSerializer.Serialize(model), Encoding.UTF8, "application/json");
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "api/authorize/Login")
            {
                Content = jsonContent
            };
            requestMessage.SetBrowserRequestCredentials(BrowserRequestCredentials.Include);
            var userResponse = await httpClient.SendAsync(requestMessage);
            var content = JsonConvert.DeserializeObject<GetHttpResponseDTO>(await userResponse.Content.ReadAsStringAsync());

            if (content?.StatusCode == HttpStatusCode.OK)
            {
                NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
                return GetHttpResponseDTO.Ok();
            }

            return content;
        }
    }
}
