using DataLayer;
using DataLayer.Models;

public interface IUsersRepository
{
    Task<IEnumerable<UsersModel>> GetAll();
    Task<IEnumerable<String>> getPasswordBy(int id);
    void updatePassword(int id, string newpassword, string updatedBy);
}
