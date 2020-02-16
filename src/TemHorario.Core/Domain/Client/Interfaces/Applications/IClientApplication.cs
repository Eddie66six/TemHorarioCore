namespace TemHorario.Core.Domain.Client.Interfaces.Applications
{
    public interface IClientApplication
    {
        void RegisterNewClient();
        int? Authenticate(string email, string password);
    }
}
