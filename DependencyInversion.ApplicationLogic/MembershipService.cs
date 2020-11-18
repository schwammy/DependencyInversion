using DependencyInversion.Interfaces;

namespace DependencyInversion.ApplicationLogic
{
    public class MembershipService
    {
        private readonly IMembershipValidator _validator;
        private readonly IMembershipDataService _membership;
        private readonly IMessageFormatter _formatter;
        private readonly INotifier _notifier;

        public void Join(string userName, string password)
        {
            _validator.ValidateUser(userName, password);

            _membership.Add(userName, password);

            var message = _formatter.FormatMessage(userName);

            _notifier.SendNotification(message);
        }
    }
}
