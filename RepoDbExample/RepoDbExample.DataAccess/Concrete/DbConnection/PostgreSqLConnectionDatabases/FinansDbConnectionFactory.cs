﻿using System;
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
            _connectionStringValue = new AppConfiguration(DatabaseConnectionName.FinansDb)._connectionString;
        }
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
