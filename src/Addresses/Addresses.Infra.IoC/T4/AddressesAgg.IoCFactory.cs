
using Niu.Nutri.Addresses.Application.Aggregates.AddressesAgg.AppServices;
using Niu.Nutri.Addresses.Infra.Data.Aggregates.AddressesAgg.Repositories;
using Niu.Nutri.Addresses.Domain.Aggregates.AddressesAgg.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.Commands;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Niu.Nutri.Core.Application.DTO.Seedwork;
using Niu.Nutri.Core.Infra.IoC;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Microsoft.AspNetCore.DataProtection;

namespace Niu.Nutri.Addresses.Infra.IoC {
	using Core.Infra.IoC.Extensions;
    using Core.Api.Middlewares;
	using Infra.Data.Context;
	using Domain.Aggregates.AddressesAgg.CommandHandlers;
	

    public partial class IoCFactory : IBaseIoC {
		string connectionString;
		
		partial void ConfigureFactories();
		partial void ConfigureValidators();
		partial void ConfigureAdditionalAppServices(IServiceCollection services);
		partial void ConfigureAdditionalRepositories();
		partial void PreConfigureDatabase(IServiceCollection services, IConfiguration configuration);

        #region Constructor

        private static IoCFactory _current;
		public static IoCFactory Current { get { return _current ?? (_current = new IoCFactory()); } }

        #endregion

        #region Methods

        public void Configure(IConfiguration configuration, IServiceCollection services) {
			ConfigureFactories();
			ConfigureMediatR(services);
			ConfigureAppServices(services);
			ConfigureRepositories(services);
			ConfigureDatabase(services, configuration);
			ConfigureMappings();
			ConfigureMiddleware(services);
			ConfigureControllers(services);
        }

		void ConfigureControllers(IServiceCollection services)
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
			}).AddBadRequestCustomValidator();;
		}

		void ConfigureMiddleware(IServiceCollection services)
        {
            services.AddScoped<ErrorHandlingMiddleware>();
        }

		void ConfigureMappings()
		{
			MapperFactory.Setup(this.GetType().Namespace.Replace("Infra.IoC","Domain"));
		}

		void ConfigureMediatR(IServiceCollection services)
		{
            services.AddMediatR((x) => { x.RegisterServicesFromAssembly(typeof(BaseCommand).GetTypeInfo().Assembly); });
            services.AddMediatR((x) => { x.RegisterServicesFromAssembly(typeof(BaseAddressesAggCommandHandler<>).GetTypeInfo().Assembly); });
						
		}

		void ConfigureDatabase(IServiceCollection services, IConfiguration configuration)
        {
			PreConfigureDatabase(services, configuration);
			if(string.IsNullOrWhiteSpace(connectionString)) 
				connectionString = configuration.GetConnectionString("DefaultConnection")!;
			services.AddDbContext<AddressesAggContext>(options =>
			options.UseNpgsql(connectionString));
		}

		void ConfigureRepositories(IServiceCollection services) {

            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IAddressesAggSettingsRepository, AddressesAggSettingsRepository>();
			
			ConfigureAdditionalRepositories();
		}

		void ConfigureAppServices(IServiceCollection services) {

            services.AddScoped<IAddressAppService, AddressAppService>();
            services.AddScoped<IAddressesAggSettingsAppService, AddressesAggSettingsAppService>();
		
			ConfigureAdditionalAppServices(services);
		}

        #endregion
    }
}
