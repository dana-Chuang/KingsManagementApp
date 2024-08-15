using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace DataLayer
{
    public class DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connection;

        public DbContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connection = configuration.GetConnectionString("DefaultConnection");
        }
        public IDbConnection CreateConnection() => new SqlConnection(_connection);
    }
}
