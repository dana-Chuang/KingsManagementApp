using Dapper;
using DataLayer;
using DataLayer.Models;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

public class UsersRepository : IUsersRepository
{ 
    private readonly IConfiguration _configuration;
    private readonly SqlConnection _connection;
    public UsersRepository(IConfiguration configuration)
    {
        _configuration = configuration;
        _connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
    }

    public async Task<IEnumerable<UsersModel>> GetAll()
    {
        return await _connection.QueryAsync<UsersModel>("Usp_Users_GetAll", commandType: CommandType.StoredProcedure);
    }

    public void updatePassword(int id, string newPassword)
    {

        var sql = $@"UPDATE [Password] = @newPassword
                      FROM [Users] WHERE [Id] = @id";
    }
}
