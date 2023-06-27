using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace MyMicroservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeezController : ControllerBase
    {
        private readonly ILogger<DeezController> _logger;

        public DeezController(ILogger<DeezController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetDeez")]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public String Get()
        {
            return "DotNet Deez Nuts";
        }
    }
}
