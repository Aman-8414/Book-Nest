using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EcommProject_1144.Utility
{
    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration _configuration;
        private EmailSettings _emailSettings { get; }
        public EmailSender(IConfiguration configuration,IOptions<EmailSettings>emailSettings)
        {
            _configuration = configuration;
            _emailSettings = emailSettings.Value;
        }
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            Execute(email, subject, htmlMessage).Wait();
            return Task.FromResult(0);
        }
        public async Task Execute(string email,string subject,string message)
        {
            try
            {
                string toemail = string.IsNullOrEmpty(email) ?
                    _emailSettings.ToEmail : email;
                MailMessage mailMessage = new MailMessage()
                {
                    From = new MailAddress(_emailSettings.UsernameEmail, "Book Shopping Project")
                };
                mailMessage.To.Add(toemail);
                mailMessage.CC.Add(_emailSettings.CcEmail);
                mailMessage.Subject = "Shopping App" + subject;
                mailMessage.Body = message;
                mailMessage.IsBodyHtml = true;
                mailMessage.Priority = MailPriority.High;
                using(SmtpClient smtpClient=new SmtpClient(_emailSettings.PrimaryDomain,_emailSettings.PrimaryPort))
                {
                    smtpClient.Credentials = new NetworkCredential(_emailSettings.UsernameEmail,_emailSettings.UsernamePassword);
                    smtpClient.EnableSsl = true;
                    smtpClient.Send(mailMessage);
                };
            }
            catch(Exception ex)
            {
                string str = ex.Message;
            }
        }
    }
}
