using Niu.Nutri.CrossCuting.Infra.Utils.Extensions;

namespace Niu.Nutri.Shared.Blazor.Authentication.Server.Template
{
    public static class EmailTemplates
    {
        public static string ForgotPassword(string userName, int? recoverCodePassword, string headerImagePath)
        {
            string htmlMessage = $@"
            <html>
              <head>
                <style>
                  * {{
                    margin: 0;
                    padding: 0;
                    box-sizing: border-box;
                  }}
                  body {{
                    font-family: Arial, Helvetica, sans-serif;
                    background-color: #ffffff;
                    font-size: 15px;
                    line-height: 1.5;
                  }}
                  p {{
                    color: #151520;
                    font-family: Arial, Helvetica, sans-serif;
                    font-size: 15px;
                    font-style: normal;
                    font-weight: 400;
                    line-height: 1.5;
                    padding-bottom: 3px;
                  }}
                  .container {{
                    width: 100%;
                    max-width: 600px;
                    margin: 0 auto;
                    background-color: #ffffff;
                    box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
                  }}
                  .content {{
                    padding: 20px;
                    color: #333333;
                  }}
                  .footer {{
                    background-color: #f1f1f1;
                    color: #777777;
                    text-align: center;
                    font-size: 12px;
                    height: 105px;
                    display: flex;
                    align-items: center;
                    justify-content: center;
                    text-align: center;
                    flex-direction: column;
                    gap: 1rem;
                  }}
                  .footer > p {{
                    font-size: 12px;
                  }}
                  .recover-password-code {{
                    display: inline-block;
                    color: #252524;
                    font-size: 28px;
                    font-style: normal;
                    font-weight: 600;
                    line-height: normal;
                    border-radius: 8px;
                    border: 1px solid var(--Light-Primary-P50, #dbdefc);
                    background: var(--Light-Primary-P40, #eceefe);
                    padding: 0.5rem;
                    margin-top: 10px;
                  }}
                </style>
              </head>
              <body>
                <div class=""container"">
                  <img src=""https://i.imgur.com/Dp74YfG.png"" alt=""Header Image"" />
                  <div class=""content"">
                    <h1 style=""color: #7079f4"">Eae {userName}!</h1>
                    <p>Você acabou esquecendo sua senha para acessar a Niu Nutri?</p>
                    <p>Fica em paz pequeno gafanhoto, ta na mão seu código!</p>
                    <span class=""recover-password-code"">{recoverCodePassword}</span>
                    <p>Obrigado por estar conosco.</p>
                    <p>Equipe NIU.</p>
                  </div>
                </div>
              </body>
            </html>";
            return htmlMessage;
        }
    }
}
