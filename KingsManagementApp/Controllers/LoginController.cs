using DataLayer.Models;
using DataLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KingsManagementApp.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class LoginController: Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly ILoginService _loginService;

        public LoginController(ILogger<LoginController> logger, ILoginService loginService)
        {
            _logger = logger;
            _loginService = loginService;
        }

        [HttpPost(Name = "Login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            var isLoginValid = _loginService.Login(request);
            if (isLoginValid)
            {
                _logger.LogInformation("Login successful for user: {Email}", request.Email);
                return Ok();
            }
            else
            {
                _logger.LogWarning("Login failed for user: {Email}", request.Email);
                return BadRequest();
            }
        }
    }
}
