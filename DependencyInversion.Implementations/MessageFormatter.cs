using DependencyInversion.Interfaces;
using System;
using System.Net.Mail;

namespace DependencyInversion.Implementations
{
    public class MessageFormatter : IMessageFormatter
    {
        public MailMessage FormatMessage(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
