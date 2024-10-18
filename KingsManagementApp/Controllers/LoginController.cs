using DataLayer.Models;
using KingsManagementApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace KingsManagementApp.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class LoginController: Controller
    {
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "Login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            return Ok();
        }
    }
}
