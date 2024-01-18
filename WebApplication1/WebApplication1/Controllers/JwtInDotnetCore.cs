using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class JwtInDotnetCore : Controller
    {
      
        [Route("api/[controller]")]
        [ApiController]
        public class HelloWorldController : ControllerBase
        {
            [HttpGet]
            public IActionResult Get()
            {
                return Ok("Hello World");
            }
        }
    }
}
