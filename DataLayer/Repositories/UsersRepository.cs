using DataLayer;
using System.Data;
using System.Data.SqlClient;

public class UsersRepository : IUsersRepository
{
    private IDbConnection db;

    public UsersRepository(string connString)
    {
        this.db = new SqlConnection(connString);
    }

    public List<Users> GetAll()
    {
        
    }
}
