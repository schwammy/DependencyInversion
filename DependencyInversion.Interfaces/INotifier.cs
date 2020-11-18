using System.Net.Mail;

namespace DependencyInversion.Interfaces
{
    public interface INotifier
    {
        void SendNotification(MailMessage message);
    }
}
