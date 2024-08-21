using DataLayer.Models;

namespace KingsManagementApp.Services
{
    public interface IUserService
    {
        Task<IEnumerable<UsersModel>> GetAllUsers();
        Boolean isPasswordSame(int id, string password);
        void updateUserPassword(int id, string password,string updatedBy);
    }
}