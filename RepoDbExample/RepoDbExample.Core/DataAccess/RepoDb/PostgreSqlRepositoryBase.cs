using Npgsql;
using RepoDb;
using RepoDbExample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace RepoDbExample.Core.DataAccess.RepoDb
{
     

    public class PostgreSqlRepositoryBase<TEntity, DbConnection> : IRepository<TEntity>
         where TEntity : class, IEntity, new()
         where DbConnection : System.Data.IDbConnection, new()
    {


        public void Insert(TEntity entity)
        {

            using var conn =  new NpgsqlConnection(new DbConnection().ConnectionString);
            var data = conn.Insert(entity);
        }

        public IEnumerable<TEntity> QueryAll(TEntity entity)
        {
            using var conn = new NpgsqlConnection(new DbConnection().ConnectionString);
            var data = conn.QueryAll<TEntity>();
            return data;
        }
    }
}
