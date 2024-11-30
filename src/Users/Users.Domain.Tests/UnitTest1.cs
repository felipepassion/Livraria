using Niu.Nutri.CrossCutting.Infra.Log.Contexts;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Niu.Nutri.Users.Domain.Aggregates.UsersAgg.Repositories;

namespace Niu.Nutri.Users.Domain.Tests
{
    public class UnitTest1
    {
        public UnitTest1()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        [Fact(DisplayName = @"DADO a configura��o inicial das depend�ncias de servi�o
                              E a adi��o das extens�es necess�rias no banco de dados
                              QUANDO um novo usu�rio � criado
                              ENT�O um email � enviado com sucesso para a nova conta")]
        public async Task Criacao_User_Envio_Email_Nova_Conta_Sucesso()
        {
            var _serviceCollection = new ServiceCollection();
            var Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            _serviceCollection.AddSingleton(Configuration);

            _serviceCollection.AddLogging(logging => logging.AddConsole());

            Users.Infra.IoC.IoCFactory.Current.Configure(Configuration, _serviceCollection);
            Identity.Infra.IoC.IoCFactory.Current.Configure(Configuration, _serviceCollection);

            Niu.Nutri.Core.Infra.IoC.IoCFactory.Current.Configure(Configuration, _serviceCollection);

            using var ServiceProvider = _serviceCollection.BuildServiceProvider();

            using var _userRepository = ServiceProvider.GetRequiredService<IUserRepository>();

            var _logRequestContext = ServiceProvider.GetRequiredService<ILogRequestContext>();

            _userRepository.ExecuteCommandAsync("CREATE EXTENSION IF NOT EXISTS \"uuid-ossp\"").Wait();
        }
    }
}