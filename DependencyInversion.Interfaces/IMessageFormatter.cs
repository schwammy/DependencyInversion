using System.Net.Mail;

namespace DependencyInversion.Interfaces
{
    public interface IMessageFormatter
    {
        MailMessage FormatMessage(string userName);
    }
}
