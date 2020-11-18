using DependencyInversion.Interfaces;
using System;
using System.Net.Mail;

namespace DependencyInversion.Implementations
{
    public class Notifier : INotifier
    {
        public void SendNotification(MailMessage message)
        {
            throw new NotImplementedException();
        }
    }
}
