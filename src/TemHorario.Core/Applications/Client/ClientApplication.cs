using TemHorario.Core.Domain;
using TemHorario.Core.Domain.Client.Interfaces.Applications;
using TemHorario.Core.Domain.Client.Interfaces.Repositories;

namespace TemHorario.Core.Applications.Client
{
    public class ClientApplication : BaseApplication, IClientApplication
    {
        private readonly IClientRepository _clientRepository;
        public ClientApplication(IUnitOfWork unitOfWork, IClientRepository clientRepository) : base(unitOfWork)
        {
            _clientRepository = clientRepository;
        }
        public void RegisterNewClient()
        {
            var client = new Domain.Client.Entities.Client("Guilherme", "Rodrigues", "jogos.coisas@gmail.com");
            if (_clientRepository.CheckIfTheEmailIsAlreadyInUse(client.Email))
            {
                AddError("Ja existe um cadastro com esse email");
                return;
            }
            _clientRepository.Add(client);
            Commit();
        }

        public int? Authenticate(string email, string password)
        {
            var clientId = _clientRepository.Authenticate(email, password);
            if (clientId == 0)
            {
                AddError("Usuario nao encontrado");
                return null;
            }

            return clientId;
        }
    }
}
