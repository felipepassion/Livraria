using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Niu.Nutri.Core.Application.DTO.Seedwork;
using Niu.Nutri.Shared.Blazor.Authentication.Server.Components.Account;
using Niu.Nutri.Users.Identity;

namespace Niu.Nutri.Shared.Blazor.Authentication.IoC
{
    public static class IoCFactory
    {
        public static void ConfigureAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthorizationBuilder();
            services.AddScoped<AuthenticationStateProvider, PersistingServerAuthenticationStateProvider>();

            Users.Identity.Infra.IoC.IoCFactory.Current.Configure(configuration, services);
            Core.Infra.IoC.IoCFactory.Current.Configure(configuration, services);

            services.AddControllers()
                .AddApplicationPart(typeof(Controllers.AuthorizeController).Assembly);

            services.AddDataProtection()
                .PersistKeysToDbContext<ApplicationDbContext>()
                .SetApplicationName("SharedCookieApp");

            services.AddAuthentication(IdentityConstants.ApplicationScheme)
                .AddIdentityCookies(x => x.ApplicationCookie.Configure(x => x.Cookie.Name = ".AspNet.SharedCookie"));

            MapperFactory.Setup("Niu.Nutri.Shared.Blazor.Authentication");
        }

        public static void ConfigureStaticAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IdentityUserAccessor>();
            services.AddScoped<IdentityRedirectManager>();
            services.ConfigureAuthentication(configuration);
        }
    }
}
