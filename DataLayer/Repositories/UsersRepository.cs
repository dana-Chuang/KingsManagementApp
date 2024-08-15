using Dapper;
using DataLayer;
using DataLayer.Models;
using System.Data;
using System.Data.SqlClient;

public class UsersRepository : IUsersRepository
{ 
    private readonly DbContext context;
    public UsersRepository(DbContext context)
    {
        this.context = context;
    }

    async Task<IEnumerable<UsersModel>> IUsersRepository.GetAll()
    {
        var sql = $@"SELECT [Id], [CompanyCode], [EmployeeNo], [FirstName], [LastName], [Status], [Password]
                      FROM [Users]";
        using var connection = context.CreateConnection();
        return await connection.QueryAsync<UsersModel>(sql);
    }

    public void updatePassword(int id, string newPassword)
    {
        var sql = $@"UPDATE [Password] = @newPassword
                      FROM [Users] WHERE [Id] = @id";
    }
}
