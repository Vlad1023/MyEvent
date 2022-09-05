using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Services.Email
{
    public class EmailService : IEmailService
    {
        readonly string apiKey;
        public EmailService(IConfiguration configuration)
        {
            apiKey = configuration.GetConnectionString("SendGrid");
        }
        public async Task<bool> SendEmailThatEventFinished(string recipient, string eventName, string userName)
        {
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("crashg364@gmail.com"),
                Subject = "Event notification",
                PlainTextContent = $"'{eventName}' event has finished. Please share your feedback!"
            };
            msg.AddTo(new EmailAddress(recipient, userName));
            var response = await client.SendEmailAsync(msg);
            return response.IsSuccessStatusCode;
        }
    }
}
