using Npgsql;
using RepoDbExample.Core.DataAccess.RepoDb.DbConnectionOptions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace RepoDbExample.DataAccess.Concrete.DbConnection.PostgreSqLConnectionDatabases
{
    public class FinansDbConnectionFactory : IDatabaseConnectionFactory
    {
        private readonly string _connectionStringValue;
        public FinansDbConnectionFactory()
        {
            _connectionStringValue = new AppConfiguration(
                                                           DatabaseConnectionName.FinansDb
                                                         )._connectionString;
        }
         
        public string ConnectionString
        {
            get { return _connectionStringValue; }
            set { ConnectionString = _connectionStringValue; }
        }

        public IDbConnection CreateConnection()
        {
            return new NpgsqlConnection(_connectionStringValue);
        }
    }
}
