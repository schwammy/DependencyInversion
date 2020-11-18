using DependencyInversion.Interfaces;
using System;

namespace DependencyInversion.Implementations
{
    public class MembershipDataService : IMembershipDataService
    {
        public void Add(string userName, string password)
        {
            throw new NotImplementedException();
        }
    }
}
