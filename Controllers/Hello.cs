using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace MyMicroservice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        private readonly ILogger<HelloController> _logger;

        public HelloController(ILogger<HelloController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetHello")]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public String Get()
        {
            return "DotNet says \"Hi!\"";
        }
    }
}
