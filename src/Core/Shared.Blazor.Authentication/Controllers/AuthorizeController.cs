using CrossCutting.Application.Mail;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Niu.Nutri.Core.Api.Factory;
using Niu.Nutri.Core.Application.DTO.Aggregates.CommonAgg.Models.Auth;
using Niu.Nutri.Core.Application.DTO.Extensions;
using Niu.Nutri.Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;
using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;
using Niu.Nutri.Shared.Blazor.Authentication.Server.Template;
using Niu.Nutri.Users.Application.DTO.Aggregates.UsersAgg.Requests;
using Niu.Nutri.Users.Identity;
using Niu.Nutri.WebApp.Controllers;

namespace Niu.Nutri.Shared.Blazor.Authentication.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AuthorizeController : BaseController
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEmailSender _emailSender;

        public AuthorizeController(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IEmailSender emailSender,
            IConfiguration configuration,
            HttpClient httpClient)
            : base(configuration, httpClient)
        {
            _userManager = userManager;
            _emailSender = emailSender;
            _signInManager = signInManager;
            _http.BaseAddress = new Uri(HttpFactoryBuilder.FindRoute("Users", configuration).BaseUrl);
        }

        #region private methods

        private async Task<ApplicationUser> ExistUser(string emailOrPhone)
        {
            ApplicationUser? user;

            if (!emailOrPhone.Contains("@"))
            {
                user = await _userManager.Users.Where(x => x.PhoneNumber ==
                                                      emailOrPhone.RemoveTelephoneMask())
                                                     .FirstOrDefaultAsync();
            }
            else
            {
                user = await _userManager.FindByEmailAsync(emailOrPhone);
            }

            return user;
        }

        private UserInfoDTO BuildUserInfo()
        {
            return new UserInfoDTO
            {
                UserId = User.GetUserId(),
                IsAuthenticated = User.Identity.IsAuthenticated,
                Email = User.Identity.Name,
                ExposedClaims = User.Claims
                    //Optionally: filter the claims you want to expose to the client
                    //.Where(c => c.Type == "test-claim")
                    .ToDictionary(c => c.Type, c => c.Value)
            };
        }

        #endregion

        [HttpPost]
        public async Task<GetHttpResponseDTO> Login(LoginParametersDTO parameters)
        {
            if (ModelState.IsValid)
            {

                var user = await ExistUser(parameters.EmailOrPhone);

                if (user == null) return GetHttpResponseDTO.NotFound("Usuário não existe.");

                var singInResult = await _signInManager.CheckPasswordSignInAsync(user, parameters.Password, false);

                if (!singInResult.Succeeded) return GetHttpResponseDTO.BadRequest("Usuário ou senha inválido.");

                await _signInManager.SignInAsync(user, parameters.RememberMe);

                return GetHttpResponseDTO.Ok();

            }

            return GetHttpResponseDTO.BadRequest("Informe um usuário válido");
        }

        [HttpPost]
        public async Task<GetHttpResponseDTO> ForgotPassword(ForgotPasswordParametersDTO forgotPasswordParameters)
        {
            try
            {
                var user = await ExistUser(forgotPasswordParameters.EmailOrPhone);

                if (user == null) return GetHttpResponseDTO.NotFound("Usuário não existe.");

                var userId = await _userManager.GetUserIdAsync(user);
                var email = await _userManager.GetEmailAsync(user);

                Random generator = new Random();

                var r = generator.Next(1, 1000000).ToString("D6");
                user.RecoverPasswordCode = int.Parse(r);

                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    await _emailSender.SendEmailAsync(
                        email!,
                        "Esqueceu sua senha na NIU?",
                        EmailTemplates.ForgotPassword(user.Name, user.RecoverPasswordCode, "C:\\Users\\tutor\\source\\repos\\Niu-Technology\\niu-nutri\\src\\Apps\\WebApp\\Niu.Nutri.WebApp\\Niu.Nutri.WebApp\\wwwroot\\Images\\Logos\\header-e-mail.png"));
                }
                return GetHttpResponseDTO.Ok(forgotPasswordParameters.EmailOrPhone);
            }
            catch (Exception ex)
            {
                return GetHttpResponseDTO.Error(ex.Message);
            }
        }

        [HttpPost]
        [Authorize]
        public async Task<GetHttpResponseDTO> CreatePassword(CreatePasswordParametersDTO forgotPasswordParameters)
        {
            try
            {
                var user = await _userManager.FindByNameAsync(forgotPasswordParameters.UserName);

                if (user == null) return GetHttpResponseDTO.NotFound("Usuário não encontrado.");

                var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                var result = await _userManager.ResetPasswordAsync(user, code, forgotPasswordParameters.Password);

                if (!result.Succeeded)
                    return GetHttpResponseDTO.BadRequest($"Erro ao resetar a senha: {string.Join(", ", result.Errors.Select(x => x.Description))}");

                user.NeedResetPassword = false;
                var resultUpdate = await _userManager.UpdateAsync(user);

                if (resultUpdate.Succeeded)
                    return GetHttpResponseDTO.Ok();
                else
                    return GetHttpResponseDTO.BadRequest(resultUpdate.Errors.Select(x => x.Description).ToArray());
            }
            catch (Exception ex)
            {
                return GetHttpResponseDTO.Error(ex);
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<GetHttpResponseDTO> VerifyForgotPasswordToken(TokenModelDTO forgotPasswordParameters)
        {
            try
            {
                var appUser = await ExistUser(forgotPasswordParameters.UserName);

                if (appUser == null) return GetHttpResponseDTO.NotFound("Usuário não encontrado.");

                var result = appUser.RecoverPasswordCode?.ToString() == forgotPasswordParameters.TokenValue;

                if (result)
                {
                    var http = HttpFactoryBuilder.Build(this.HttpContext);

                    return GetHttpResponseDTO.Ok(forgotPasswordParameters.TokenValue);
                }
                else
                    return GetHttpResponseDTO.BadRequest("Código inválido");
            }
            catch (Exception ex)
            {
                return GetHttpResponseDTO.Error(ex.Message);
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<GetHttpResponseDTO> ResetPassword(CreatePasswordParametersDTO forgotPasswordParameters)
        {
            try
            {
                var aspUser = await ExistUser(forgotPasswordParameters.UserName);

                if (aspUser == null) return GetHttpResponseDTO.NotFound("Usuário não encontrado.");

                if (forgotPasswordParameters.Code != aspUser.RecoverPasswordCode?.ToString())
                    return GetHttpResponseDTO.Ok("Token Inválido");

                var code = await _userManager.GeneratePasswordResetTokenAsync(aspUser);
                var result = await _userManager.ResetPasswordAsync(aspUser, code, forgotPasswordParameters.Password);

                if (result.Succeeded)
                {
                    aspUser.RecoverPasswordCode = null;
                    await _userManager.UpdateAsync(aspUser);

                    await _signInManager.SignInAsync(aspUser, true);
                    return GetHttpResponseDTO.Ok();
                }

                return GetHttpResponseDTO.BadRequest(result.Errors.Select(x => x.Description).ToArray());
            }
            catch (Exception ex)
            {
            }

            return GetHttpResponseDTO.Ok();
        }

        [HttpPost]
        public async Task<GetHttpResponseDTO> RegisterAsync(RegisterParametersDTO parameters)
        {

            var existUserByEmail = _userManager.FindByEmailAsync(parameters.UserName);
            if (existUserByEmail.Result != null)
            {
                return GetHttpResponseDTO.BadRequest("Já existe um usuário com este e-mail.");
            }

            var existUserByTelephone = await _userManager.Users.Where(x => x.PhoneNumber == parameters.PhoneNumber.RemoveTelephoneMask()).FirstOrDefaultAsync();

            if (existUserByTelephone != null)
            {
                return GetHttpResponseDTO.BadRequest("Já existe um usuário com este telefone.");
            }

            try
            {
                var newUser = parameters.ProjectedAs<UserDTO>();
                newUser.CreatedAt = DateTime.UtcNow;
                var userCreationResult = await _http.CreateAsync(newUser);

                if (userCreationResult.Success)
                    return await Login(new LoginParametersDTO
                    {
                        EmailOrPhone = parameters.UserName,
                        Password = parameters.Password,
                        RememberMe = true,
                        ValidAllrights = true
                    });
                else
                    return GetHttpResponseDTO.BadRequest("Código inválido");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        [Authorize]
        public async Task<GetHttpResponseDTO> Logout()
        {
            await _signInManager.SignOutAsync();
            return GetHttpResponseDTO.Ok();
        }

        [HttpGet]
        public UserInfoDTO UserInfo()
        {
            //var user = await _userManager.GetUserAsync(HttpContext.User);
            return BuildUserInfo();
        }

    }
}
