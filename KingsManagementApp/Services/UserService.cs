using DataLayer.Models;
using KingsManagementApp.Services;

namespace KingsManagementApp.Controllers
{
    public class UserService : IUserService
    {
        private readonly IUsersRepository _usersRepository;

        public UserService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public Task<IEnumerable<UsersModel>> GetAllUsers()
        {
            return _usersRepository.GetAll();
        }

        public void updateUserPassword(int id, string newpassword)
        {
            _usersRepository.updatePassword(id,newpassword);
        }
    }
}