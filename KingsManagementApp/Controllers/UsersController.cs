using DataLayer.Models;
using DataLayer.Interfaces;
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
            if (_userService.isPasswordSame(request.Id, request.NewPassword))
            {
                throw new ValidationException("New Password should not be same as the old one");
            }
            _userService.updateUserPassword(request.Id, request.NewPassword, request.UpdatedBy);
            return Ok();
        }

        [HttpPost(Name = "AddAdmin")]
        public IActionResult AddAdmin([FromBody] AdminRequest request)
        {
            if (request == null || request.Id <= 0)
            {
                return BadRequest("Invalid user ID.");
            }

            try
            {
                _userService.AddAdmin(request.Id, request.UpdatedBy);
                return Ok(new { message = "Admin added successfully", userId = request.Id });
            }
            catch (Exception ex)
            {
                // Log the error as needed
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

    }
}
