using DataLayer.Models;

namespace DataLayer.Interfaces
{
    public interface IUserService
    {
        List<UsersModel> GetAllUsers();
        Boolean isPasswordSame(int id, string password);
        void updateUserPassword(int id, string password,string updatedBy);
    }
}