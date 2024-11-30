using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Niu.Nutri.CrossCutting.Infra.Log.Contexts;
using Niu.Nutri.Users.Api;
using Niu.Nutri.Users.Api.Controllers;
using Niu.Nutri.Users.Application.Aggregates.UsersAgg.AppServices;

namespace Users.Api.Tests
{
    public class UnitTest1
    {
        public IConfiguration _configuration { get; }

        public UnitTest1(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [Fact(DisplayName = @"DADO a configura��o de inje��o de depend�ncias
                              QUANDO o UserController � instanciado
                              ENT�O ele deve ser inicializado corretamente")]
        public void Test1()
        {
            var fakeUserAppService = new Mock<IUserAppService>();
            IServiceCollection serviceCollection = new ServiceCollection();
            var fakeLogContext = new Mock<ILogRequestContext>().Object;

            serviceCollection.InjectDependencies(_configuration);
            
            var fakeProvider = serviceCollection.BuildServiceProvider();

            var controller = new UserController(fakeProvider, fakeLogContext, fakeUserAppService.Object);
        }
    }
}