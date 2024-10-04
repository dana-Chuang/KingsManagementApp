using DataLayer;
using DataLayer.Models;

public interface IUsersRepository
{
    List<UsersModel> GetAll();
    IEnumerable<String> getPasswordBy(int id);
    void updatePassword(int id, string newpassword, string updatedBy);
}
