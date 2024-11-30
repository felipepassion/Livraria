using Companies.Adm.Panel.Client.Shared.Chat;
using FisSst.BlazorMaps.DependencyInjection;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Niu.Nutri.Core.Application.DTO.Seedwork.ValueObjects;
using Niu.Nutri.Shared.Blazor.Authentication.Client.IoC;
using Niu.Nutri.Shared.Blazor.Components.Services;
using Niu.Nutri.Users.Application.DTO.Aggregates.UsersAgg.Requests;
using System.Globalization;

namespace Niu.Nutri.WebApp.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("pt-BR");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddIdentityCookieAuthentication();

            builder.Services.AddScoped<ThemeManager>();
            builder.Services.InjectDependencies(builder.Configuration);

            builder.Services.AddSingleton<ChatContext>();
            builder.Services.AddSingleton<AutoSaveSettingsDTO>();
            builder.Services.AddSingleton<UserCurrentAccessSelectedDTO>();

            builder.Services.AddBlazorLeafletMaps();

            await builder.Build().RunAsync();
        }
    }
}
