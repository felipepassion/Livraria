using CrossCutting.Application.Mail;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Newtonsoft.Json;
using Niu.Nutri.Core.Api.Factory;
using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models.Auth;
using Niu.Nutri.Core.Application.DTO.Extensions;
using Niu.Nutri.Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;
using Niu.Nutri.Shared.Blazor.Authentication.Controllers;
using Niu.Nutri.Shared.Blazor.Authentication.IoC;
using Niu.Nutri.Users.Application.DTO.Aggregates.UsersAgg.Requests;
using Niu.Nutri.Users.Identity;
using RichardSzalay.MockHttp;
using System.Net;

namespace Shared.Blazor.Authentication.Tests
{
    public class UnitTest1
    {
        readonly IConfiguration _configuration;

        public UnitTest1()
        {
            IServiceCollection serviceCollection = new ServiceCollection();

            _configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            serviceCollection.AddSingleton(_configuration);
            serviceCollection.ConfigureAuthentication(_configuration);
        }





        [Fact(DisplayName = @"DADO os parametros de registro de um usu�rio
                              QUANDO � convertido para DTO
                              ENT�O deve conter todas propriedas n�o nulas")]
        public async Task Convert_RegisterParametersDTO_To_UserDTO_ShouldMapUserSuccess()
        {
            // arrange
            RegisterParametersDTO fakeUser = new RegisterParametersDTO
            {
                PhoneNumber = "12345678901",
                UserName = "email@email.com",
                Password = "123456",
                Name = "Teste"
            };

            // act -> convert
            UserDTO convertedUserDTO = fakeUser.ProjectedAs<UserDTO>();

            // assert
            Assert.NotNull(convertedUserDTO);
            Assert.NotNull(convertedUserDTO.Contact.Email);
            Assert.NotNull(convertedUserDTO.UserName);
            Assert.NotNull(convertedUserDTO.Document);
            Assert.NotNull(convertedUserDTO.Password);
            Assert.NotNull(convertedUserDTO.Name);
        }

        [Fact(DisplayName = @"DADO o registro de um usu�rio com campos v�lidos
                              QUANDO o formul�rio de registro � submetido
                              ENT�O deve retornar um status de sucesso e c�digo de resposta HTTP 200")]
        public async Task Test1()
        {
            var fakeHttpAccessor = new Mock<IHttpContextAccessor>();
            var mailSender = new Mock<IEmailSender>();
            var store = new Mock<IUserStore<ApplicationUser>>();
     
            var mockHttp = new MockHttpMessageHandler();

            // Setup a respond for the user api (including a wildcard in the URL)
            mockHttp.When("https://localhost:5003/api/User")
                    .Respond("application/json", JsonConvert.SerializeObject(GetHttpResponseDTO.Ok()));

            // Inject the handler or client into your application code
            var httpClient = new HttpClient(mockHttp);

            var userManager = new UserManager<ApplicationUser>(store.Object, null, null, null, null, null, null, null, null);
            var signinManager = new SignInManager<ApplicationUser>(userManager, fakeHttpAccessor.Object,
                new Mock<IUserClaimsPrincipalFactory<ApplicationUser>>().Object, null, null, null, null);

            var controller = new AuthorizeController(
                userManager,
                signinManager,
                mailSender.Object,
                _configuration,
                httpClient);

            var result = await controller.RegisterAsync(new RegisterParametersDTO
            {
                UserName = "email@email.com",
                Password = "123456",
                Name = "Teste"
            });

            Assert.True(result.Success);
            Assert.Equal(HttpStatusCode.OK, result.StatusCode);
        }
    }
}