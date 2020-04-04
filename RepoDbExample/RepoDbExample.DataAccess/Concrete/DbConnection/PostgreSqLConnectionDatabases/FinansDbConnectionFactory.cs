using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace RepoDbExample.DataAccess.Concrete.DbConnection.PostgreSqLConnectionDatabases
{
    // 
    public class FinansDbConnectionFactory : IDbConnection
    {
        private string _connectionStringValue;

        public FinansDbConnectionFactory()
        {
           // _connectionStringValue = @"User Id=postgres; Server=localhost; Port=5432; Database=finansdb; Unicode=True; Connection Timeout=15; Default Command Timeout=30; Integrated Security=False";
            //_connectionStringValue =   @"User ID=postgres;Password=1903;Server=localhost;Database=finansdb;Integrated Security=true;Pooling=true;";
            _connectionStringValue = @"Server=localhost;Port=5432;Database=finansdb;User Id=postgres;Password=1903;";
        }
        //"User ID=postgres;Password=1903;Server=localhost;Port=5432;Database=finansdb;Integrated Security=true;Pooling=true;"
        //"Server=.;Database=Northwind;Integrated Security=SSPI;";

        public string ConnectionString
        {
            get { return _connectionStringValue; }
            set { ConnectionString = _connectionStringValue; }
        }
         
        public int ConnectionTimeout => 10000;

        public string Database => Database;

        public ConnectionState State => State;



        public IDbTransaction BeginTransaction()
        {
            return BeginTransaction();
        }

        public IDbTransaction BeginTransaction(IsolationLevel il)
        {
            return BeginTransaction(il);
        }

        public void ChangeDatabase(string databaseName)
        {
            ChangeDatabase(databaseName);
        }

        public void Close()
        {
            Close();
        }

        public IDbCommand CreateCommand()
        {
            return CreateCommand();
        }

        public void Dispose()
        {
            Dispose();
        }

        public void Open()
        {
            Open();
        }
    }
}
