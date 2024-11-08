using DataLayer.Interfaces;
using DataLayer.Models;
using System.Diagnostics;

namespace KingsManagementApp.Controllers
{
    public class LoginService : ILoginService
    {
        private readonly ILogger<LoginService> _logger;
        private readonly IUsersRepository _usersRepository;

        public LoginService(ILogger<LoginService> logger, IUsersRepository usersRepository)
        {
            _logger = logger;
            _usersRepository = usersRepository;
        }

        public Boolean Login(LoginRequest request)
        {
            var pwFromDB = _usersRepository.getPasswordBy(request.Email);
            if (pwFromDB == null)
            {
                _logger.LogWarning("No password found for the email:" + request.Email);
                //Debug.WriteLine("No password found for the email: " + request.Email);
                return false;
            }
            return pwFromDB == request.Password;
        }
    }
}