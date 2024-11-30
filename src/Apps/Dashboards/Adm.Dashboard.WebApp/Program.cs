using Companies.Adm.Panel.Client.Shared.Chat;
using CrossCutting.Application.Mail;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Niu.Nutri.Adm.Dashboard.WebApp;
using Niu.Nutri.Adm.Dashboard.WebApp.Components;
using Niu.Nutri.Core.Infra.IoC.Extensions;
using Niu.Nutri.Shared.Blazor.Authentication.IoC;
using Niu.Nutri.Shared.Blazor.Authentication.Server.Components.Account;
using Niu.Nutri.Shared.Blazor.Forms.IoC;
using Niu.Nutri.Shared.Blazor.Sidebar.Contexts;
using Niu.Nutri.Users.Application.DTO.Aggregates.UsersAgg.Requests;
using Niu.Nutri.Users.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddSingleton<IEmailSender, EmailSender>();
builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();

var loggedUserSessionCache = new UserCurrentAccessSelectedDTO();
builder.Services.AddSingleton<UserCurrentAccessSelectedDTO>(loggedUserSessionCache);

builder.Services.InjectDependencies(builder.Configuration, builder.Host);
builder.Services.AddAuthorizationCore();
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzU0OTU1MkAzMjM3MmUzMDJlMzBjdFhjUkN1M3RBbWJDYXg5b2ZRbGtjVVdqZC84cWh2Z3h6VzhhM1FhalpNPQ==");
builder.Services.AddCors(options =>
{
    options.AddPolicy("_myAllowSpecificOrigins",
        builder =>
        {
            builder.WithOrigins("https://localhost:44389")
                   .AllowAnyHeader()
                   .AllowAnyMethod()
                   .SetIsOriginAllowed((x) => true)
                   .AllowCredentials();
        });
});

builder.Services.AddSignalR();
builder.Services.AddSingleton<ChatContext>();

var app = builder.Build();

app.UseDeveloperExceptionPage();
app.UseExceptionHandler("/Error", createScopeForErrors: true);

// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
app.UseHsts();
app.UseRouting();
app.UseCors("_myAllowSpecificOrigins");

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Add additional endpoints required by the Identity /Account Razor components.
app.MapControllers();
app.UseAuthorization();

app.OnAppInitialized();

app.Run();

static partial class IoCFactory
{
    public static void InjectDependencies(this IServiceCollection services, IConfiguration configuration, ConfigureHostBuilder host)
    {
        services.AddScoped(sp =>
        {
            var ctx = sp.GetRequiredService<IHttpContextAccessor>();
            var headers = ctx?.HttpContext?.Request?.Headers;
            var request = ctx?.HttpContext?.Request;
            var baseUrl = $"{request.Scheme}://{request.Host}{request.PathBase}";

            var httpClient = new HttpClient
            {
                BaseAddress = new Uri(baseUrl)
            };

            if (headers != null)
            {
                foreach (var header in headers)
                {
                    try
                    {
                        // Adicione cada cabe�alho ao DefaultRequestHeaders do HttpClient
                        if (!httpClient.DefaultRequestHeaders.Contains(header.Key))
                        {
                            httpClient.DefaultRequestHeaders.Add(header.Key, header.Value.ToArray());
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
            }

            return httpClient;
        });


        services.AddSingleton<SidebarContext>();
        services.ConfigureControllers();

        services.InjectDependencies(configuration);

        services.ConfigureStaticAuthentication(configuration);

        services.ConfigureSyncfusion(configuration);
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