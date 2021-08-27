using Article.DAL.Entities;
using LichtDataPack.DbTools;

namespace Article.DAL.Repositories
{
    public class ArticleRepository:DapperGenericRepository<ArticleRecord>
    {
        private const string ConnectionString = "";
        private const string TableName = "Articles";
        public ArticleRepository(string connectionString = ConnectionString, string tableName = TableName, string idName = "Id") : base(connectionString, tableName, idName)
        {
        }
    }
}