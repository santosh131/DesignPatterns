using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string to, string subject, string body)
        {
            // Implementation for sending email
            Console.WriteLine($"Sending email to {to} with subject '{subject}' and body '{body}'");
        }
    }
}
