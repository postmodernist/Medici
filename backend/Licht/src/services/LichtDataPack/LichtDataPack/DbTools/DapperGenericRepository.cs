using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Dapper;
using LichtDataPack.Interfaces.DbTools;
using LichtDataPack.Interfaces.Entity;

namespace LichtDataPack.DbTools
{
    public class DapperGenericRepository<T>: IDapperGenericRepository<T> where T: class, IEntity
    {
        protected ConnectionFactory _connectionFactory;
        protected string _tableName { get; set; }
        protected string _IdName { get; set; }

        public DapperGenericRepository(string connectionString, string tableName, string idName = "Id")
        {
            _connectionFactory = new ConnectionFactory(connectionString);
            _tableName = tableName;
            _IdName = idName;
        }

        private IEnumerable<string> GetColumns()
        {
            return typeof(T)
                    .GetProperties()
                    .Where(e => e.Name != "Id" && !e.PropertyType.GetTypeInfo().IsGenericType)
                    .Select(e => e.Name);
        }

        private IEnumerable<string> GetProperties(T entity)
        {
            return typeof(T)
                    .GetProperties()
                    .Where(e => e.Name != "Id" && e.GetValue(entity) != null && !e.PropertyType.GetTypeInfo().IsGenericType)
                    .Select(e => e.GetValue(entity).ToString());//.Select(e => '\'' + e.GetValue(entity).ToString() + '\'');
        }

        private IEnumerable<string> GetPropertiesUpdate(T entity)
        {
            return typeof(T)
                    .GetProperties()
                    .Where(e => e.Name != "Id" && e.GetValue(entity) != null && !e.PropertyType.GetTypeInfo().IsGenericType)
                    .Select(e => e.Name + " = " + '\'' + e.GetValue(entity).ToString() + '\'');
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            var query = "SP_GetAllRecordsFromTable";

            using (var db = _connectionFactory.GetSqlConnection)
            {
                return await db.QueryAsync<T>(query,
                    new { P_tableName = _tableName },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<T> GetByIdAsync(int Id)
        {
            var query = "SP_GetRecordByIdFromTable";

            using (var db = _connectionFactory.GetSqlConnection)
            {
                var items = await db.QueryAsync<T>(query,
                    new { P_tableName = _tableName, P_IdName = _IdName, P_Id = Id },
                    commandType: CommandType.StoredProcedure);
                return items.FirstOrDefault(item => item.Id == Id);
            }
        }

        public async Task<T> AddAsync(T entity)
        {
            var columns = GetColumns();
            var stringOfColumns = string.Join(", ", columns);
            var stringOfProperties = string.Join(", ", GetProperties(entity)); ;
            var query = "SP_InsertRecordToTable";
            /*            try
                        {*/
            using (var db = _connectionFactory.GetSqlConnection)
            {
                var InsertionStatement = await db.QueryFirstAsync<int>(
                sql: query,
                param: new { P_tableName = _tableName, P_columnsString = stringOfColumns, P_propertiesString = stringOfProperties },
                commandType: CommandType.StoredProcedure);
                return entity;
            }
            /*            }
                        catch (Exception e)
                        {
                            Console.Write(e);
                            return false;
                        }*/
        }

        public async Task<T> UpdateAsync(T entity)
        {
            var stringOfColumns = string.Join(", ", GetPropertiesUpdate(entity));
            //var query = "SP_UpdateRecordInTable";
            var query = "SP_UpdateRecordInTableInOneString";
            try
            {
                using (var db = _connectionFactory.GetSqlConnection)
                {
                    var UpdateStatement = await db.QueryFirstAsync<string>(
                        sql: query,
                        param: new
                        {
                            P_tableName = _tableName, P_columnsString = stringOfColumns, P_IdName = _IdName,
                            P_Id = entity.Id
                        },
                        commandType: CommandType.StoredProcedure);
                    return entity;
                }
            }
            catch (Exception e)
            {
                Console.Write(e);
                return entity;
            }
        }

        public async Task DeleteAsync(int Id)
        {
            var query = "SP_DeleteRecordFromTable";
            try
            {
                using (var db = _connectionFactory.GetSqlConnection)
                {
                    var result = await db.ExecuteAsync(
                    sql: query,
                    param: new { P_tableName = _tableName, P_IdName = _IdName, P_Id = Id },
                    commandType: CommandType.StoredProcedure);
                    return ;
                }
            }
            catch (Exception e)
            {
                Console.Write(e);
                
            }
        }
    }
}