using DataLayer.Interfaces;
using DataLayer.Models;

namespace KingsManagementApp.Controllers
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public void Login(LoginRequest request)
        {
            var pwFromDB = _loginRepository.GetPassword(request.Username);
            throw new NotImplementedException();
        }
    }
}