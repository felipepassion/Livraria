using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Niu.Nutri.Shared.Blazor.Authentication.Client.Providers;
using Niu.Nutri.WebApp.Client.Services.Auth;

namespace Niu.Nutri.Shared.Blazor.Authentication.Client.IoC
{
    public static class IoCFactory
    {
        public static void AddIdentityCookieAuthentication(this IServiceCollection services)
        {
            services.AddScoped<AuthenticationStateProvider, CookieAuthenticationStateProvider>();
            services.AddScoped<IAuthorizeApi, AuthorizeApi>();
            services.AddAuthorizationCore();
        }
    }
}
