using System.Net.Mail;

namespace DependencyInversion
{
    public class SingleResponsibility
    {
        public void Join(string userName, string password)
        {
            new MembershipValidator().ValidateUser(userName, password);

            new MembershipService().Add(userName, password);

            var message = new MessageFormatter().FormatMessage(userName);

            new Notifier().SendNotification(message);

            //Possible nested dependencies?
            // Does MembershipService have a dependency on EF?
            // Does MessageFormatter read a document from the file system in windows?
            // Does Notifier have a dependency on SMTP mail?
        }
    }

    public class MembershipValidator
    {
        public void ValidateUser(string userName, string password)
        {
            //check username and password against rules for length and strength, etc
        }
    }

    public class MembershipService
    {
        public void Add(string userName, string password)
        {
            //maybe save info to a db?
        }
    }

    public class MessageFormatter
    {
        public MailMessage FormatMessage(string userName)
        {
            MailMessage message = new MailMessage();
            message.Subject = string.Format("Welcome {0}", userName);
            return message;
        }
    }

    public class Notifier
    {
        public void SendNotification(MailMessage message)
        {
            //use SMTP Mail...
        }
    }
}
