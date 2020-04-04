using RepoDbExample.Core.Entities;
using System;
using System.Collections.Generic; 
using RepoDb;
using System.Data.SqlClient;

namespace RepoDbExample.Core.DataAccess.RepoDb
{
    public class RepoDbRepositoryBase<TEntity, DbConnection> : IRepoDbRepository<TEntity>
         where TEntity : class, IEntity, new()
         where DbConnection : System.Data.IDbConnection, new()
    {


        public void Insert(TEntity entity)
        {

            using var conn = new SqlConnection(new DbConnection().ConnectionString);
            var data = conn.Insert(entity);
        }

        public IEnumerable<TEntity> QueryAll(TEntity entity)
        {
            using var conn = new SqlConnection(new DbConnection().ConnectionString);
            var data = conn.QueryAll<TEntity>();
            return data;
        }
    }
}
