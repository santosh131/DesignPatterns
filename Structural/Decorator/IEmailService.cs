using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public interface IEmailService
    {
        void SendEmail(string to, string subject, string body);
    }
}
