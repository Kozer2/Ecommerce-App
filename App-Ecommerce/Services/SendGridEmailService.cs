using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Net.Http;
using System.Net.Mail;
using System.Threading.Tasks;

namespace App_Ecommerce.Services
{
    public class SendGridEmailService : IEmailService
    {
        public IConfiguration configuration;

        public SendGridEmailService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        /*public class SendGridSmtpEmailService : IEmailService
        {
            public Task SendEmail(string email, string subject, string body)
            {
                var smtp = new SmtpClient();
                // ...
                return Task.CompletedTask;
            }
        }*/

        public async Task SendEmail(string email, string subject, string body)
        {
            var apiKey = configuration["SendGrid:ApiKey"] ?? throw new InvalidOperationException("Missing Api Key");
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress(configuration["SendGrid:FromEmail"]);
            var to = new EmailAddress(email);
            var htmlContent = $"<strong>{body}</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, body, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }

    // not needed? Or did I missunderstand Keith
    public class SendGridHttpEmailService : IEmailService
    {
        public IConfiguration configuration;

        public SendGridHttpEmailService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public Task SendEmail(string email, string subject, string body)
        {
            var http = new HttpClient();
            var sendUrl = configuration["SendGrid:ApiSendUrl"] ?? throw new InvalidOperationException("Missing Api Send Url");

            // http.PostAsync(sendUrl, )
            throw new NotSupportedException("Do we need this?");
        }
    }

    
}