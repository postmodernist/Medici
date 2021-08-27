using System.Data;
using System.Data.SqlClient;
using LichtDataPack.Interfaces.DbTools;
using Microsoft.Extensions.Configuration;

namespace LichtDataPack.DbTools
{
    public class ConnectionFactory : IConnectionFactory
    {
        //private readonly IConfiguration configuation;
        private static string _connectionString;

        public ConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void SetConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection GetSqlConnection
        {
            get
            {
                SqlConnection connection;
                connection = new SqlConnection(_connectionString); 
                return connection;
            }
        }
    }
}