using DataLayer.Models;

namespace KingsManagementApp.Services
{
    public interface IUserService
    {
        Task<IEnumerable<UsersModel>> GetAllUsers();
        void updateUserPassword(int id, string password);
    }
}