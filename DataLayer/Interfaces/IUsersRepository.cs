using DataLayer;
using DataLayer.Models;

public interface IUsersRepository
{
    Task<IEnumerable<UsersModel>> GetAll();
    void updatePassword(int id, string newpassword);
}
