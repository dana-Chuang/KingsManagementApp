using DataLayer.Models;
using KingsManagementApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

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
        public List<UsersModel> GetAllUsers()
        {
            var allUserLists = _userService.GetAllUsers();
            return allUserLists;

        }

        [HttpPut(Name = "UpdatePassword")]
        public IActionResult UpdatePassword([FromBody] UpdatePasswordRequest request)
        {
/*            var id = 1;
            var newPassword = "testing";
            var updatedBy ="tDana";*/
            if (_userService.isPasswordSame(request.Id, request.NewPassword))
            {
                throw new ValidationException("New Password should not be same as the old one");
            }
            _userService.updateUserPassword(request.Id, request.NewPassword, request.UpdatedBy);
            return Ok();
        }

    }
}
