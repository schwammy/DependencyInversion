namespace DependencyInversion.Interfaces
{
    public interface IMembershipValidator
    {
        void ValidateUser(string userName, string password);
    }
}
