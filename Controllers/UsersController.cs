using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserService.UserDTO;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public void test()
        {
            Console.WriteLine("hello test api");
        }
        [HttpPost("loginRequest")]
        public IActionResult LoginRequest([FromBody] LoginRequestDto loginRequestDto)
        {
            return Unauthorized("Invalid user name or password");
        }

    }
}
