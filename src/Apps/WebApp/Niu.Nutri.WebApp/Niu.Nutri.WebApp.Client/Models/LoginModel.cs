using System.ComponentModel.DataAnnotations;

namespace Niu.Nutri.WebApp.Client.Models
{
    public class LoginModel
    {
        public string? UserName { get; set; }

        public string? Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
