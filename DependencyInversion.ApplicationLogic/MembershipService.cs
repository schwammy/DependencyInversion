using DependencyInversion.Interfaces;

namespace DependencyInversion.ApplicationLogic
{
    public interface IMembershipService
    {
        void Join(string userName, string password);
    }

    public class MembershipService : IMembershipService
    {
        private readonly IMembershipValidator _validator;
        private readonly IMembershipDataService _membership;
        private readonly IMessageFormatter _formatter;
        private readonly INotifier _notifier;

        public MembershipService(IMembershipValidator validator, IMembershipDataService membership, IMembershipDataService membership2, IMembershipDataService membership3, IMessageFormatter formatter, INotifier notifier)
        {
            _validator = validator;
            _membership = membership;
            _formatter = formatter;
            _notifier = notifier;
        }


        public void Join(string userName, string password)
        {
            _validator.ValidateUser(userName, password);

            _membership.Add(userName, password);

            var message = _formatter.FormatMessage(userName);

            _notifier.SendNotification(message);
        }
    }
}
