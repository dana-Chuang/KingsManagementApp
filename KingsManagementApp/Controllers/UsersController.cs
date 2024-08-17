using DataLayer.Models;
using KingsManagementApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace KingsManagementApp.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UsersController : ControllerBase
    {

        private readonly ILogger<UsersController> _logger;
        private readonly IUserService _userService;

        public UsersController(ILogger<UsersController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet(Name = "GetAllUsers")]
        public async Task<IEnumerable<UsersModel>> GetAllUsers()
        {
            var allUserLists = await _userService.GetAllUsers();
            return allUserLists;

        }

        [HttpPost(Name = "UpdatePassword")]
        public IActionResult UpdatePassword(int id, string password, string updatedBy)
        {
            _userService.updateUserPassword(id, password, updatedBy);
            return Ok();
        }

    }
}
