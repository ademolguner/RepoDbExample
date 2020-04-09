using Npgsql;
using RepoDb;
using RepoDbExample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace RepoDbExample.Core.DataAccess.RepoDb
{

    public class PostgreSqlRepositoryBase<TEntity, DbConnection> : IRepository<TEntity>
         where TEntity : class, IEntity, new()
         where DbConnection : System.Data.IDbConnection, new()
    {

       
        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using var conn = new NpgsqlConnection(new DbConnection().ConnectionString);
            var data = conn.QueryAll<TEntity>().ToList();
            return data;
        }
         
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using var conn = new NpgsqlConnection(new DbConnection().ConnectionString);
            var data = conn.Query<TEntity>(filter).GetEnumerator().Current;
            return data;
        }

        public void Insert(TEntity entity)
        {
            using var conn = new NpgsqlConnection(new DbConnection().ConnectionString);
            var data = conn.Insert(entity);
        }

        public void Update(TEntity entity)
        {
            using var conn = new NpgsqlConnection(new DbConnection().ConnectionString);
            var data = conn.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            using var conn = new NpgsqlConnection(new DbConnection().ConnectionString);
            var data = conn.Delete(entity);
        }

        
        public List<T> BulkInsert<T>(List<T> bulkInsetData)
        {
            throw new NotImplementedException();
        }

        public void BulkDelete<T>(List<T> bulkInsetData)
        {
            throw new NotImplementedException();
        }

        public List<T> BulkUpdate<T>(List<T> bulkInsetData)
        {
            throw new NotImplementedException();
        }

    }
}
