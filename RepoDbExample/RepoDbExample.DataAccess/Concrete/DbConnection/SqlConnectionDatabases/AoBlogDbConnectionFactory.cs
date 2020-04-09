using RepoDbExample.Core.DataAccess.RepoDb.DbConnectionOptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace RepoDbExample.DataAccess.Concrete.DbConnection.SqlConnectionDatabases
{
    public class AoBlogDbConnectionFactory : IDatabaseConnectionFactory
    {

        private string _connectionStringValue;
        public AoBlogDbConnectionFactory()
        {
            _connectionStringValue = new AppConfiguration(DatabaseConnectionName.AdemBlogDb)._connectionString;
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

        
    }
}
