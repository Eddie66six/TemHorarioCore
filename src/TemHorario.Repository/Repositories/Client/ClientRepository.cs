using System.Linq;
using TemHorario.Core.Domain.Client.Interfaces.Repositories;

namespace TemHorario.Repository.Repositories.Client
{
    public class ClientRepository : BaseRepository<Core.Domain.Client.Entities.Client>, IClientRepository
    {
        public ClientRepository(Context context) : base(context)
        {
        }

        public int Authenticate(string email, string password)
        {
            return _context.Clients.Where(p => p.Email == email && p.Password == password).Select(p => p.ClientId).FirstOrDefault();
        }

        public bool CheckIfTheEmailIsAlreadyInUse(string email)
        {
            return _context.Clients.Any(p => p.Email == email);
        }
    }
}
