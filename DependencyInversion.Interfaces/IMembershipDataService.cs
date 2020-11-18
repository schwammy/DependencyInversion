namespace DependencyInversion.Interfaces
{
    public interface IMembershipDataService
    {
        void Add(string userName, string password);
    }
}
