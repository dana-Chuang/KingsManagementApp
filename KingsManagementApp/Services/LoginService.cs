using DataLayer.Interfaces;
using DataLayer.Models;
using System.Diagnostics;

namespace KingsManagementApp.Controllers
{
    public class LoginService : ILoginService
    {
        private readonly IUsersRepository _usersRepository;

        public LoginService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public Boolean Login(LoginRequest request)
        {
            var pwFromDB = _usersRepository.getPasswordBy(request.Email);
            // Check if no password was found
            if (pwFromDB == null)
            {
                Debug.WriteLine("No password found for the email: " + request.Email);
                return false;
            }

            Debug.WriteLine("Get password from database: " + pwFromDB);

            // Compare the retrieved password with the request's password
            return pwFromDB == request.Password;
            //Debug.WriteLine("Get password from database: " + pwFromDB.ToString());
            //return pwFromDB.ToString() == request.Password;
        }
    }
}