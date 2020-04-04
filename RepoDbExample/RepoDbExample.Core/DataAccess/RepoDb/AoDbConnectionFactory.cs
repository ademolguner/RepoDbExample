using System;
using System.Data;
using System.Data.SqlClient;

namespace RepoDbExample.Core.DataAccess.RepoDb
{
    public   class NwDbConnectionFactory : IDbConnection
    {

        private string _connectionStringValue;

        public NwDbConnectionFactory()
        {
            _connectionStringValue = "Server=.;Database=Northwind;Integrated Security=SSPI;";
        }

        public   string ConnectionString
        {
            get { return _connectionStringValue; }
            set { ConnectionString = _connectionStringValue; }
        }
        
        public int ConnectionTimeout => 10000;

        public string Database => this.Database;

        public ConnectionState State => this.State;

        

        public IDbTransaction BeginTransaction()
        {
            return this.BeginTransaction();
        }

        public IDbTransaction BeginTransaction(IsolationLevel il)
        {
            return this.BeginTransaction(il);
        }

        public void ChangeDatabase(string databaseName)
        {
            this.ChangeDatabase(databaseName);
        }

        public void Close()
        {
            this.Close();
        }

        public IDbCommand CreateCommand()
        {
            return this.CreateCommand();
        }

        public void Dispose()
        {
            this.Dispose();
        }

        public void Open()
        {
            this.Open();
        }
    }
}
