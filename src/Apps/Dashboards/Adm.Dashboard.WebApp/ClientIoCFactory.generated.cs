
using FluentValidation;
namespace Niu.Nutri.Adm.Dashboard.WebApp {
    public static partial class IoCFactory {
       
		public static void InjectDependencies(this IServiceCollection services, IConfiguration configuration) {
            ConfigureValidators(services);
		}

        static void ConfigureValidators(IServiceCollection services) {
			services.AddValidatorsFromAssemblyContaining
				<Users.Application.DTO.Aggregates.UsersAgg.Validators.BaseUsersAggValidator
					<Core.Application.DTO.Aggregates.CommonAgg.Models.EntityDTO>>();
			services.AddValidatorsFromAssemblyContaining
				<DefaultTemplate.Application.DTO.Aggregates.DefaultTemplateAgg.Validators.BaseDefaultTemplateAggValidator
					<Core.Application.DTO.Aggregates.CommonAgg.Models.EntityDTO>>();
			services.AddValidatorsFromAssemblyContaining
				<Chat.Application.DTO.Aggregates.ChatAgg.Validators.BaseChatAggValidator
					<Core.Application.DTO.Aggregates.CommonAgg.Models.EntityDTO>>();
			services.AddValidatorsFromAssemblyContaining
				<SystemSettings.Application.DTO.Aggregates.SystemSettingsAgg.Validators.BaseSystemSettingsAggValidator
					<Core.Application.DTO.Aggregates.CommonAgg.Models.EntityDTO>>();
			services.AddValidatorsFromAssemblyContaining
				<Addresses.Application.DTO.Aggregates.AddressesAgg.Validators.BaseAddressesAggValidator
					<Core.Application.DTO.Aggregates.CommonAgg.Models.EntityDTO>>();
			services.AddValidatorsFromAssemblyContaining
				<Livraria.Application.DTO.Aggregates.LivrariaAgg.Validators.BaseLivrariaAggValidator
					<Core.Application.DTO.Aggregates.CommonAgg.Models.EntityDTO>>();
			
		}
    }
}