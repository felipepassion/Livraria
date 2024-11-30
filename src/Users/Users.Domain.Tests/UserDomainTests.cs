using CrossCutting.Application.Mail;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Niu.Nutri.CrossCutting.Infra.Log.Contexts;
using Niu.Nutri.Migrations.Api.DataSeeders;
using Niu.Nutri.Users.Application.Aggregates.UsersAgg.AppServices;
using Niu.Nutri.Users.Application.DTO.Aggregates.UsersAgg.Requests;
using Niu.Nutri.Users.Domain.Aggregates.UsersAgg.Repositories;
using Niu.Nutri.Users.Enumerations;

namespace Niu.Nutri.Users.Domain.Tests
{
    public class UserDomainTests
    {
        [Fact(DisplayName = @"DADO a configuração inicial do sistema
                              QUANDO um novo usuário é criado 
                              E seus perfis de acesso são alterados
                              ENTÃO o sistema deve refletir os acessos atualizados sem erros")]
        public async Task Alteracao_De_Perfis_De_Acesso_User_Nova_Conta_Sucesso()
        {
            using var serviceProvider = BuildServiceProvider();

            using var _profileRepo = serviceProvider.GetRequiredService<IUserProfileAppService>();
            using var _userRepository = serviceProvider.GetRequiredService<IUserRepository>();
            var _userAppService = serviceProvider.GetRequiredService<IUserAppService>();
            var _logRequestContext = serviceProvider.GetRequiredService<ILogRequestContext>();

            var id = Guid.NewGuid().ToString();

            var cpf = CPFGenerator.Generate();
            var userDTO = new UserDTO
            {
                Password = "pwd1234",
                UserName = Guid.NewGuid().ToString(),
                Contact = new UserContactDTO
                {
                    Email = $"{Guid.NewGuid()}@email.com"
                },
                Name = string.Join("", Guid.NewGuid().ToString().Replace("-", " ").Where(x => !char.IsDigit(x))),
                ExternalId = Guid.NewGuid().ToString()
            };

            await _userRepository.ExecuteCommandAsync("CREATE EXTENSION IF NOT EXISTS \"uuid-ossp\"");
            var createResult1 = await _userAppService.Create(userDTO);

            Assert.Null(createResult1.Errors.LastOrDefault().Value);
        }

        [Fact(DisplayName = @"DADO a configuração inicial do sistema
                              QUANDO um novo usuário é criado 
                              E seus perfis de acesso são alterados
                              ENTÃO o sistema deve refletir os acessos atualizados sem erros")]
        public async Task Alteracao_De_Perfis_De_Acesso_User_Nova_Conta_Sucesso2()
        {
            using var serviceProvider = BuildServiceProvider();

            using var _profileRepo = serviceProvider.GetRequiredService<IUserProfileAppService>();
            using var _userRepository = serviceProvider.GetRequiredService<IUserRepository>();
            var _userAppService = serviceProvider.GetRequiredService<IUserAppService>();
            var _logRequestContext = serviceProvider.GetRequiredService<ILogRequestContext>();

            var id = Guid.NewGuid().ToString();

            var expectedProfile = UserRole.SUPPORT.ToFriendlyString();
            var user = await UsuariosSeeders.CreateTearDownUser(serviceProvider, Guid.NewGuid().ToString(), UserRole.SUPPORT.ToFriendlyString(), UserProfileTypes.SUPPORT);

            Assert.NotNull(user);
            Assert.NotNull(user.ExternalId);

            var createdUser = await _userRepository.FindAsync(x => x.ExternalId == user.ExternalId);

            Assert.NotNull(createdUser);
            Assert.NotNull(createdUser.Accesses);
            Assert.Single(createdUser.Accesses);
            Assert.Equal(UserRole.SUPPORT.ToFriendlyString(), createdUser.Accesses.First().UserProfiles.First().Description, ignoreCase: true);
        }

        private static ServiceProvider BuildServiceProvider()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            var _serviceCollection = new ServiceCollection();
            IConfiguration Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            var mailSender = new EmailSender();
            _serviceCollection.AddSingleton(Configuration);

            _serviceCollection.AddLogging(logging => logging.AddConsole());

            _serviceCollection.AddHttpClient();
            _serviceCollection.AddHttpContextAccessor();

            Users.Infra.IoC.IoCFactory.Current.Configure(Configuration, _serviceCollection);
            Identity.Infra.IoC.IoCFactory.Current.Configure(Configuration, _serviceCollection);

            Core.Infra.IoC.IoCFactory.Current.Configure(Configuration, _serviceCollection);
            var ServiceProvider = _serviceCollection.BuildServiceProvider();
            return ServiceProvider;
        }
    }
}
