using Microsoft.AspNetCore.Mvc;

namespace Identity.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private static readonly string[] Users = new[]
        {
            "Fred", "Jhon", "ABC", "XYZ"
        };


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Users);
        }
    }
}
