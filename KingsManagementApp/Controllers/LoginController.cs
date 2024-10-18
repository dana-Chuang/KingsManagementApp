using DataLayer.Models;
using DataLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

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
            _loginService.Login(request);
            return Ok();
        }
    }
}
