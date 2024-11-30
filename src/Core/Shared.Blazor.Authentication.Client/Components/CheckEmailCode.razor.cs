//// Licensed to the .NET Foundation under one or more agreements.
//// The .NET Foundation licenses this file to you under the MIT license.
//#nullable disable

//using System;
//using System.ComponentModel;
//using System.ComponentModel.DataAnnotations;
//using System.Text;
//using System.Text.Encodings.Web;
//using System.Threading.Tasks;
//using Niu.Nutri.Core.Domain.Aggregates.CommonAgg.AppServices;
//using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;
//using Niu.Nutri.Users.Application.Aggregates.UsersAgg.AppServices;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Components;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.UI.Services;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.AspNetCore.WebUtilities;

//namespace Companies.Adm.Panel.Server.Areas.Identity.Pages.Account
//{
//    public class CheckEmailCodeModel : PageModel
//    {
//        private readonly UserManager<Niu.Nutri.Users.Identity.ApplicationUser> _userManager;
//        private readonly IEmailSender _emailSender;
//        [Inject] IUserAppService _userAppService { get; set; }

//        public CheckEmailCodeModel(UserManager<Niu.Nutri.Users.Identity.ApplicationUser> userManager, IEmailSender emailSender)
//        {
//            _userManager = userManager;
//            _emailSender = emailSender;
//        }

//        /// <summary>
//        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
//        ///     directly from your code. This API may change or be removed in future releases.
//        /// </summary>
//        [BindProperty]
//        public InputModel Input { get; set; }

//        /// <summary>
//        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
//        ///     directly from your code. This API may change or be removed in future releases.
//        /// </summary>
//        public class InputModel
//        {
//            /// <summary>
//            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
//            ///     directly from your code. This API may change or be removed in future releases.
//            /// </summary>


//            [Required]
//            public string Email { get; set; }

//            [Required]
//            public string RecoverPasswordCode { get; set; }
//        }

//        public async Task<IActionResult> OnGetAsync(string email)
//        {
//            Input = new InputModel { Email = email };
//            return Page();
//        }

//        public async Task<IActionResult> OnPostAsync()
//        {
//            if (ModelState.IsValid)
//            {
//                var user = await _userManager.FindByEmailAsync(Input.Email);
//                if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)))
//                {
//                    // Don't reveal that the user does not exist or is not confirmed
//                    return RedirectToPage("./ForgotPasswordConfirmation");
//                }

//                if (Input.RecoverPasswordCode.Equals(user.RecoverPasswordCode.ToString()) &&
//                    ((DateTime.UtcNow - (DateTime)user.RecoverPasswordCodeDate).Hours < 24))
//                {
//                    return RedirectToPage("./CreatePassword", new { user.Email });
//                }
//                else
//                    ModelState.AddModelError(string.Empty, "Código incorreto ou expirado.");
//            }

//            return Page();
//        }
//    }
//}
