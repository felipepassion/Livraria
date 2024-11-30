﻿using System.Net;
using System.Net.Mail;

namespace CrossCutting.Application.Mail
{
    public class EmailSender : IEmailSender
    {
        public void Dispose()
        {
        }

        public async Task SendEmailAsync(string toEmailAddress, string emailSubject, string emailMessageHtml)
        {
            if (string.IsNullOrWhiteSpace(toEmailAddress)) return;

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var message = new MailMessage();
            message.To.Add(toEmailAddress);
            message.Subject = emailSubject;
            message.Body = emailMessageHtml;
            message.IsBodyHtml = true;
            message.From = new MailAddress("contato@niutech.app.br");

            using (var smtpClient = new SmtpClient("smtp.gmail.com", 587))
            {
                smtpClient.UseDefaultCredentials = false;
                NetworkCredential MyCredentials = new NetworkCredential("contato@niutech.app.br", "N2VVFKC=Yh3j8hB&");

                smtpClient.EnableSsl = true;
                smtpClient.Credentials = MyCredentials;
                try
                {
                    await smtpClient.SendMailAsync(message);
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
        }
    }

    public interface IEmailSender : IDisposable
    {
        Task SendEmailAsync(string toEmailAddress, string emailSubject, string emailMessageHtml);
    }
}

