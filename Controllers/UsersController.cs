using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserService.UserDTO;
using UserService.Services;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly SystemUserService _systemUserService;
        public UsersController(SystemUserService systemUserService)
        {
            _systemUserService = systemUserService;
        }
        [HttpGet]
        public void test()
        {
            Console.WriteLine("hello test api");
        }
        [HttpPost("loginRequest")]
        public IActionResult LoginRequest([FromBody] LoginRequestDto loginRequestDto)
        {
            string userName = loginRequestDto.reqUserName;
            string password = loginRequestDto.reqPassword;
            // validate the rquest
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                return BadRequest("User name or password are requied");
            }

            // Authenticate user via the service
            string result = _systemUserService.LoginRequestParam(userName, password);

            if (result == "Login successful!")
            {
                return Ok(new { message = result });
            }


            return Unauthorized("Invalid user name or password");
        }
        [HttpGet("getAllUser")]
        public IActionResult getAllUser() {

            return Ok();
        }
        [HttpGet("getUserById /{id?}")]
        public IActionResult getUserById(int? id)
        {
            return Ok();
        }


    }
}
