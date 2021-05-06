
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Ecommerce.Services
{
    public interface IEmailService
    {
        Task SendEmail(string emailAddress, string subject, string body);
    }

   
    public class LoggerEmailService : IEmailService
    {
        private readonly ILogger<LoggerEmailService> logger;

        public LoggerEmailService(ILogger<LoggerEmailService> logger)
        {
            this.logger = logger;
        }

        public Task SendEmail(string email, string subject, string body)
        {
            logger.LogInformation("Sending email to {0} with the subject '{2}'", email, subject);
            return Task.CompletedTask;
        }
    }

    
}