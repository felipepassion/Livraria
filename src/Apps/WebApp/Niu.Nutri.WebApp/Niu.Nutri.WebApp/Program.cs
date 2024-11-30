using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Niu.Nutri.Core.Api.Factory;
using Niu.Nutri.Core.Api.Middlewares;
using Niu.Nutri.Core.Infra.IoC.Extensions;
using Niu.Nutri.Shared.Blazor.Authentication.IoC;
using Niu.Nutri.Shared.Blazor.Authentication.Server.Components.Account;
using Niu.Nutri.Shared.Blazor.Components.Services;
using Niu.Nutri.Users.Identity;
using Niu.Nutri.WebApp.Client.Services.Auth;
using Niu.Nutri.WebApp.Components;

namespace Niu.Nutri.WebApp;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents()
            .AddInteractiveWebAssemblyComponents();

        builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();
        builder.Services.AddScoped<IAuthorizeApi, AuthorizeApi>();
        builder.Services.AddEndpointsApiExplorer();

        builder.Services.InjectDependencies(builder.Configuration);

        builder.Services.AddHttpContextAccessor();
        builder.Services.AddTransient<HttpFactoryBuilder>();

        builder.Services.AddTransient(sp =>
        {
            return HttpFactoryBuilder.Build(sp.GetRequiredService<IHttpContextAccessor>().HttpContext!);
        });
        builder.Services.AddScoped<ThemeManager>();
        builder.Services.AddSwaggerGen(options =>
        {
            options.CustomSchemaIds(type => type.ToString());
        });

        builder.Services.AddSignalR();

        var app = builder.Build();

        app.UseMiddleware<ErrorHandlingMiddleware>();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseWebAssemblyDebugging();
            app.UseMigrationsEndPoint();
        }
        else
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseMiddleware<ErrorHandlingMiddleware>();
        app.UseHttpsRedirection();

        app.UseBlazorFrameworkFiles();
        app.UseStaticFiles();

        app.UseRouting();
        app.UseAuthentication();
        app.UseAuthorization();
        app.UseForwardedHeaders();

        app.MapControllers();

        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode()
            .AddInteractiveWebAssemblyRenderMode()
            .AddAdditionalAssemblies(typeof(Client._Imports).Assembly);

        app.MapIdentityApi<ApplicationUser>();
        // Add additional endpoints required by the Identity /Account Razor components.
        app.MapAdditionalIdentityEndpoints();
        app.OnAppInitialized();
        app.UseAntiforgery();

        app.Run();
    }
}

static partial class IoCFactory
{
    public static void InjectDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.ConfigureControllers();

        services.AddScoped<ErrorHandlingMiddleware>();

        services.ConfigureAuthentication(configuration);
    }

    static void ConfigureControllers(this IServiceCollection services)
    {
        services.AddControllers().AddNewtonsoftJson(options =>
        {
            //options.SerializerSettings.Converters.Add(new StringEnumConverter());
            // Use the default property (Pascal) casing
            options.SerializerSettings.ContractResolver = new DefaultContractResolver();
            var settings = options.SerializerSettings;
            settings.DateFormatString = "yyyy-MM-ddTHH:mm:ss";
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            settings.MissingMemberHandling = MissingMemberHandling.Ignore;
            settings.NullValueHandling = NullValueHandling.Include;
            settings.PreserveReferencesHandling = PreserveReferencesHandling.None;
            settings.DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate;
            settings.Formatting = Formatting.Indented;
            settings.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
            options.AllowInputFormatterExceptionMessages = false;
            //settings.Converters.Add(new TiimeOnlyJsonConverter());
        }).AddBadRequestCustomValidator();
    }

    public static void OnAppInitialized(this WebApplication app)
    {
        using (var scope = app.Services.CreateScope())
        {
            var logProvider = scope.ServiceProvider.GetRequiredService<Niu.Nutri.CrossCutting.Infra.Log.Providers.ILogProvider>();
            logProvider.Write(new Niu.Nutri.CrossCutting.Infra.Log.Entries.LogEntry("------> APP | Nests.Api | STARTED <------", action: "OnAppInitialized"));
        }
    }
}



