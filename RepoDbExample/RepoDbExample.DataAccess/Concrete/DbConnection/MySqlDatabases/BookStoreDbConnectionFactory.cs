using MySql.Data.MySqlClient;
using RepoDbExample.Core.DataAccess.RepoDb.DbConnectionOptions;
using System.Data;

namespace RepoDbExample.DataAccess.Concrete.DbConnection.MySqlDatabases
{
    public class BookStoreDbConnectionFactory : IDatabaseConnectionFactory
    {
        private readonly string _connectionStringValue;

        public BookStoreDbConnectionFactory()
        {
            _connectionStringValue = new AppConfiguration(
                                                          DatabaseConnectionName.BookStore
                                                         )._connectionString;
        }

        public string ConnectionString
        {
            get { return _connectionStringValue; }
            set { ConnectionString = _connectionStringValue; }
        }

        public IDbConnection CreateConnection()
        {
            return new MySqlConnection(_connectionStringValue);
        }

        public void Dispose()
        {
            Dispose();
        }
    }
}