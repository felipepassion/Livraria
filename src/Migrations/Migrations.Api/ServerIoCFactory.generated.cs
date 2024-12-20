

using Niu.Nutri.Core.Infra.Data.Contexts;
using Niu.Nutri.Core.Infra.IoC;
using Microsoft.EntityFrameworkCore;
    
namespace Niu.Nutri.Migrations.Api {
    public static partial class IoCFactory {
       
		public static void InjectDependencies(this IServiceCollection services, IConfiguration configuration) {

            Niu.Nutri.Livraria.Infra.IoC.IoCFactory.Current.Configure(configuration, services);
			
            Niu.Nutri.Core.Infra.IoC.IoCFactory.Current.Configure(configuration, services);
		}

        public static void Migrate(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var contexts = (from asm in AppDomain.CurrentDomain.GetAssemblies()
                                from type in asm.GetTypes()
                                where type.IsClass && type.BaseType == typeof(BaseContext)
                                select type).ToArray();

                foreach (var item in contexts)
                {
                    (scope.ServiceProvider.GetRequiredService(item) as DbContext)
                        .Database.Migrate();
                }
                // Task.Run(async () => await TablesCsvSeeder.SeedDatabase(scope));
            }
        }

        public static void OnAppInitialized(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var logProvider = scope.ServiceProvider.GetRequiredService<Niu.Nutri.CrossCutting.Infra.Log.Providers.ILogProvider>();
                logProvider.Write(new Niu.Nutri.CrossCutting.Infra.Log.Entries.LogEntry("------> APP | Migrations.Api | STARTED <------", action: "OnAppInitialized"));
            }
        }
    }
}