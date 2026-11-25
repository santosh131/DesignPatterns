using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class EmailLogDecorator : IEmailService
    {
        private readonly IEmailService _emailService;

        public EmailLogDecorator(IEmailService emailService)
        {
            _emailService = emailService;
        }
         
        public void SendEmail(string to, string subject, string body)
        {
            Console.WriteLine($"Logging email to {to} with subject '{subject}' and body '{body}'");
            _emailService.SendEmail(to, subject, body);
        }

        public void SendEmail2(string to, string subject, string body)
        {
            Console.WriteLine($"Logging email to {to} with subject '{subject}' and body '{body}'");
            _emailService.SendEmail(to, subject, body);
        }
    }
}
