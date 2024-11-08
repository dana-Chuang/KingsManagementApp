using DataLayer;
using DataLayer.Models;

public interface IUsersRepository
{
    void AddAdmin(int id, string updatedBy);
    List<UsersModel> GetAll();
    IEnumerable<String> getPasswordBy(int id);
    string getPasswordBy(string email);
    void updatePassword(int id, string newpassword, string updatedBy);
}
