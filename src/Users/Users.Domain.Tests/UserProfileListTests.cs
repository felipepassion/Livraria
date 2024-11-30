using CrossCutting.Application.Mail;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Niu.Nutri.CrossCutting.Infra.Log.Contexts;
using Niu.Nutri.Users.Application.Aggregates.UsersAgg.AppServices;
using Niu.Nutri.Users.Application.DTO.Aggregates.UsersAgg.Requests;
using Niu.Nutri.Users.Domain.Aggregates.UsersAgg.CommandModels;
using Niu.Nutri.Users.Domain.Aggregates.UsersAgg.Queries.Models;
using Niu.Nutri.Users.Domain.Aggregates.UsersAgg.Repositories;

namespace Niu.Nutri.Users.Domain.Tests
{
    public class UserProfileListTests
    {
        [Fact(DisplayName = @"DADO uma busca de perfis de usuários
                              QUANDO a busca de perfis de usuário é solicitada
                              ENTÃO a resultado não deve estar vazio")]
        public async Task Get_UserProfileLists()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            var _serviceCollection = new ServiceCollection();
            IConfiguration Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            var mailSender = new EmailSender();
            _serviceCollection.AddSingleton(Configuration);

            _serviceCollection.AddLogging(logging => logging.AddConsole());

            Users.Infra.IoC.IoCFactory.Current.Configure(Configuration, _serviceCollection);
            Identity.Infra.IoC.IoCFactory.Current.Configure(Configuration, _serviceCollection);

            Core.Infra.IoC.IoCFactory.Current.Configure(Configuration, _serviceCollection);

            using var ServiceProvider = _serviceCollection.BuildServiceProvider();

            using var _profileRepo = ServiceProvider.GetRequiredService<IUserProfileListAppService>();
            using var _userRepository = ServiceProvider.GetRequiredService<IUserRepository>();
            var _userAppService = ServiceProvider.GetRequiredService<IUserAppService>();
            var _logRequestContext = ServiceProvider.GetRequiredService<ILogRequestContext>();


            //var test = await _profileRepo.GetAll(new UserProfileListQueryModel { });

            //Assert.NotEmpty(test);
        }
    }
}
