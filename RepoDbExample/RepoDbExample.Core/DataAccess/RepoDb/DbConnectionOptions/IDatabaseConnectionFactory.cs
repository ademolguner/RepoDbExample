using System;
using System.Data;

namespace RepoDbExample.Core.DataAccess.RepoDb.DbConnectionOptions
{
    public interface IDatabaseConnectionFactory : IDisposable
    {
        IDbConnection CreateConnection();
    }
}