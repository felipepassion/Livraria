using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Niu.Nutri.CrossCutting.Infra.Log.Contexts;

namespace Core.Tests
{
    public class TestBase
    {
        protected readonly IConfiguration Configuration;

        protected IServiceProvider ServiceProvider => this.ServiceCollection.BuildServiceProvider();

        private IServiceCollection _serviceCollection;
        protected IServiceCollection ServiceCollection
        { get { return _serviceCollection ?? (_serviceCollection = new ServiceCollection()); } }
        
        protected readonly ILogRequestContext _logRequestContext;
        protected readonly IMediator _mediator;

        public TestBase()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            _serviceCollection = new ServiceCollection();
            Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            _serviceCollection.AddSingleton(Configuration);

            _serviceCollection.AddLogging(logging => logging.AddConsole());

            Niu.Nutri.Users.Identity.Infra.IoC.IoCFactory.Current.Configure(this.Configuration, this.ServiceCollection);
            
            Niu.Nutri.Core.Infra.IoC.IoCFactory.Current.Configure(this.Configuration, this.ServiceCollection);

            _mediator = ServiceProvider.GetRequiredService<IMediator>();

            _logRequestContext = this.ServiceProvider.GetRequiredService<ILogRequestContext>();

            //_userRepository.ExecuteCommandAsync("CREATE EXTENSION IF NOT EXISTS \"uuid-ossp\"").Wait();
        }
    }
}