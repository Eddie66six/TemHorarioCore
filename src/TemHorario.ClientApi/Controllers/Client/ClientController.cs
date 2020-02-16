using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TemHorario.Core;
using TemHorario.Core.Domain.Client.Interfaces.Applications;
using TemHorario.SharedApi;

namespace TemHorario.ClientApi.Controllers.Client
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : BaseApiController
    {
        private readonly IClientApplication _clientApplication;
        public ClientController(ErrorEvent errorEvent, IClientApplication clientApplication) : base(errorEvent)
        {
            _clientApplication = clientApplication;
        }

        [HttpPost]
        [AllowAnonymous]
        public Task<ObjectResult> Register()
        {
            _clientApplication.RegisterNewClient();
            return CreateResponse(null);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("authenticate")]
        public Task<ObjectResult> Authenticate(string email, string password)
        {
            var clientId = _clientApplication.Authenticate(email, password);
            if (clientId == null) return CreateResponse(null);

            var token = TokenService.GenerateToken(clientId.Value, "client");
            return CreateResponse(new
            {
                token = token
            });
        }
    }
}