using CoreApiJwtStudy.JwtHandling;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreApiJwtStudy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        public IActionResult GetToken()
        {
            return Ok(new JwtGenerator().GeneratedToken());

        }

    }
}
