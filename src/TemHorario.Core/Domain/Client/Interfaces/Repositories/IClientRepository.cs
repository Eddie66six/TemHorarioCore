namespace TemHorario.Core.Domain.Client.Interfaces.Repositories
{
    public interface IClientRepository : IBaseRepository<Entities.Client>
    {
        int Authenticate(string email, string password);
        bool CheckIfTheEmailIsAlreadyInUse(string email);
    }
}
