using Microsoft.AspNetCore.Mvc;

namespace AuthenticationApi.Controllers
{
    public class HealthCheckController : ApiControllerBase
    {
        [HttpGet]
        public IActionResult Ping()
        {
            return Ok();
        }
    }
}
