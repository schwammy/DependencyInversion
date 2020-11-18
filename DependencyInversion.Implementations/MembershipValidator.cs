using DependencyInversion.Interfaces;
using System;

namespace DependencyInversion.Implementations
{
    public class MembershipValidator : IMembershipValidator
    {
        public void ValidateUser(string userName, string password)
        {
            throw new NotImplementedException();
        }
    }
}
