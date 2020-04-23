using RepoDbExample.Core.DataAccess.RepoDb.DbConnectionOptions;
using System.Data;
using System.Data.SqlClient;

namespace RepoDbExample.DataAccess.Concrete.DbConnection.SqlConnectionDatabases
{
    public class NorthWindDbConnectionFactory : IDatabaseConnectionFactory
    {
        private readonly string _connectionStringValue;

        public NorthWindDbConnectionFactory()
        {
            _connectionStringValue = new AppConfiguration(
                                                           DatabaseConnectionName.NorthWind
                                                         )._connectionString;
        }

        public string ConnectionString
        {
            get { return _connectionStringValue; }
            set { ConnectionString = _connectionStringValue; }
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionStringValue);
        }

        public void Dispose()
        {
            Dispose();
        }
    }
}