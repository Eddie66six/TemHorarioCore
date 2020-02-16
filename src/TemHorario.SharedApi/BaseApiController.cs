using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;
using TemHorario.Core;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TemHorario.SharedApi
{
    public class BaseApiController : ControllerBase
    {
        private readonly ErrorEvent _ErrorEvent;
        public BaseApiController(ErrorEvent errorEvent)
        {
            _ErrorEvent = errorEvent;
        }
        public Task<ObjectResult> CreateResponse(object result, HttpStatusCode httpStatusCode = HttpStatusCode.OK)
        {
            return Task.FromResult(_ErrorEvent.IsError() ? StatusCode((int)HttpStatusCode.BadRequest, _ErrorEvent.GetErrorMessages()) : StatusCode((int)httpStatusCode, result));
        }
    }
}
