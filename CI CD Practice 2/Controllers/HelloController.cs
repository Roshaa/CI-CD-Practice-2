using Microsoft.AspNetCore.Mvc;

namespace CI_CD_Practice_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello, World!");
        }

    }
}
