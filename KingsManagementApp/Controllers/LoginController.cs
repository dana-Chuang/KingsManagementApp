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
            var loginCredentials = _loginService.Login(request);
            if (loginCredentials == null)
            {
                return Unauthorized(); // Return 401 if credentials are invalid
            }

            return Ok(loginCredentials); // Return 200 with LoginCredentials if valid
            /*            if (isLoginValid)
                        {
                            _logger.LogInformation("Login successful for user: {Email}", request.Email);
                            var response = new { loginName = "Dana" };
                            return Ok(response);
                        }
                        else
                        {
                            _logger.LogWarning("Login failed for user: {Email}", request.Email);
                            return BadRequest();
                        }*/
        }
    }
}
