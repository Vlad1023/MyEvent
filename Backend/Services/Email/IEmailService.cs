using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Services.Email
{
    interface IEmailService
    {
        Task<bool> SendEmailThatEventFinished(string recipient, string eventName, string userName);
    }
}
