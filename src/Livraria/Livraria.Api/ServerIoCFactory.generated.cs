namespace Niu.Nutri.Livraria.Api;

public static partial class IoCFactory
{
    public static void InjectDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        Niu.Nutri.Livraria.Infra.IoC.IoCFactory.Current.Configure(configuration, services);
        Niu.Nutri.Core.Infra.IoC.IoCFactory.Current.Configure(configuration, services);
    }

    public static void OnAppInitialized(this WebApplication app)
    {
        using (var scope = app.Services.CreateScope())
        {
            var logProvider = scope.ServiceProvider.GetRequiredService<Niu.Nutri.CrossCutting.Infra.Log.Providers.ILogProvider>();
            logProvider.Write(new Niu.Nutri.CrossCutting.Infra.Log.Entries.LogEntry("------> APP | Livraria.Api | STARTED <------", action: "OnAppInitialized"));
        }
    }
}