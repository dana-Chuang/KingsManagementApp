using Dapper;
using DataLayer;
using DataLayer.Interfaces;
using DataLayer.Models;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

public class LoginRepository : ILoginRepository
{ 
    private readonly IConfiguration _configuration;
    private readonly SqlConnection _connection;
    public LoginRepository(IConfiguration configuration)
    {
        _configuration = configuration;
        _connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
    }

    public IEnumerable<String> GetPassword(string username)
    {
        var parameters = new DynamicParameters();
        parameters.Add("Username", username);
        return _connection.Query<String>("Usp_Login_GetPasswordByUsername", parameters, commandType: CommandType.StoredProcedure);
    }
}
