
using Microsoft.AspNetCore.DataProtection;

namespace Niu.Nutri.SystemSettings.Api {
    using Infra.Data.Context;
    public static partial class IoCFactory {
       
		public static void InjectDependencies(this IServiceCollection services, IConfiguration configuration) {
                    Niu.Nutri.SystemSettings.Infra.IoC.IoCFactory.Current.Configure(configuration, services);
            Niu.Nutri.Core.Infra.IoC.IoCFactory.Current.Configure(configuration, services);
            services.ConfigureAuthentication();
		}

        private static void ConfigureAuthentication(this IServiceCollection services)
        {
            services.AddDataProtection()
                .PersistKeysToDbContext<SystemSettingsAggContext>()
                .SetApplicationName("SharedCookieApp");

            services.AddAuthentication("Identity.Application")
                .AddCookie("Identity.Application", options =>
                {
                    options.Cookie.Name = ".AspNet.SharedCookie";
                });
        }

        public static void OnAppInitialized(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var logProvider = scope.ServiceProvider.GetRequiredService<Niu.Nutri.CrossCutting.Infra.Log.Providers.ILogProvider>();
                logProvider.Write(new Niu.Nutri.CrossCutting.Infra.Log.Entries.LogEntry("------> APP | SystemSettings.Api | STARTED <------", action: "OnAppInitialized"));
            }
        }
    }
}