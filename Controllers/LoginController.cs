using Microsoft.AspNetCore.Mvc;
using TechExam.Models;
using TechExam.Interfaces;

namespace TechExam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly LoginInterface _loginService;

        public LoginController(LoginInterface loginService)
        {
            _loginService = loginService;
        }

        [HttpPost("registerUser")]
        public async Task<IActionResult> registerUserAsync([FromBody] Users userData)
        {
            if (userData == null)
            {
                return BadRequest("data is null");
            }

            await _loginService.RegisterUser(userData);

            var SuccessMessage = new successMessage()
            {
                SuccessMessage = "User successfully registered",
                SuccessSubMessage = "You can now log in"
            };

            return Ok(new { successMessage = SuccessMessage });
        }

        [HttpGet("loginUser")]
        public async Task<IActionResult> Login([FromQuery] string userName, [FromQuery] string passWord)
        {
            var output = await _loginService.Login(userName, passWord);

            return Ok(new { loginMessage = output });
        }
    }
}
