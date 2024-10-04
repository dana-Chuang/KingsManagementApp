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

    public List<UsersModel> GetAll()
    {
        return _connection.Query<UsersModel>("Usp_Users_GetAll", commandType: CommandType.StoredProcedure).ToList();
    }

    public IEnumerable<String> getPasswordBy(int id)
    {
        var parameters = new DynamicParameters();
        parameters.Add("Id", id);
        return _connection.Query<String>("Usp_Users_GetPasswordById", parameters, commandType: CommandType.StoredProcedure);
    }

    public void updatePassword(int id, string newPassword, string updatedBy)
    {
        var parameters = new DynamicParameters();
        parameters.Add("Id", id);
        parameters.Add("NewPassword", newPassword);
        parameters.Add("UpdatedBy", updatedBy);

        _connection.Query<UsersModel>("Usp_Users_UpdatePassword", parameters, commandType: CommandType.StoredProcedure);
    }
}
