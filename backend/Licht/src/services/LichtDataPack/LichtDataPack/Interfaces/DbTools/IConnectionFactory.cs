using System.Data;

namespace LichtDataPack.Interfaces.DbTools
{
    public interface IConnectionFactory
    {
        public IDbConnection GetSqlConnection { get; }
        public void SetConnection(string connectionString);
    }
}