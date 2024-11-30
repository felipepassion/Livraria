using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Niu.Nutri.Adm.Dashboard;
using Niu.Nutri.Adm.Dashboard.Components;
using Niu.Nutri.Core.Application.DTO.Seedwork.ValueObjects;
using Niu.Nutri.Shared.Blazor.Authentication.Components.Account;
using Niu.Nutri.Shared.Blazor.Authentication.IoC;
using Niu.Nutri.Users.Application.DTO.Aggregates.UsersAgg.Requests;
using Niu.Nutri.Users.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.ConfigureAuthentication(builder.Configuration);

builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.InjectDependencies(builder.Configuration, builder.Host);

builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();
builder.Services.AddSingleton<UserCurrentAccessSelectedDTO>();
builder.Services.AddSingleton<AutoSaveSettingsDTO>();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Add additional endpoints required by the Identity /Account Razor components.
app.MapAdditionalIdentityEndpoints();

app.OnAppInitialized();
app.MapControllers();

app.Run();

static partial class IoCFactory
{
    public static void InjectDependencies(this IServiceCollection services, IConfiguration configuration, ConfigureHostBuilder host)
    {
        services.AddScoped(sp =>
        {
            try
            {
                return new HttpClient { BaseAddress = new Uri(sp.GetRequiredService<NavigationManager>().BaseUri) };
            }
            catch
            {
                return new HttpClient();
            }
        });

        services.ConfigureControllers();

        services.InjectDependencies(configuration);

        Niu.Nutri.Users.Identity.Infra.IoC.IoCFactory.Current.Configure(configuration, services);
        Niu.Nutri.Core.Infra.IoC.IoCFactory.Current.Configure(configuration, services);
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
            settings.NullValueHandling = NullValueHandling.Ignore;
            settings.PreserveReferencesHandling = PreserveReferencesHandling.None;
            settings.DefaultValueHandling = DefaultValueHandling.Ignore;
            settings.Formatting = Formatting.Indented;
            settings.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
            options.AllowInputFormatterExceptionMessages = false;
            //settings.Converters.Add(new TiimeOnlyJsonConverter());
        });
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