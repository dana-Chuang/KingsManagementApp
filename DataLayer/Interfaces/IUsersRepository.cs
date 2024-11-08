using DataLayer;
using DataLayer.Models;

public interface IUsersRepository
{
    void AddAdmin(int id, string updatedBy);
    void ChangeAdminStatus(int id, int newStatus, string updatedBy);
    List<UsersModel> GetAll();
    LoginCredentials getLoginCredentials(string email);
    IEnumerable<String> getPasswordBy(int id);
    string getPasswordBy(string email);
    void updatePassword(int id, string newpassword, string updatedBy);
}
