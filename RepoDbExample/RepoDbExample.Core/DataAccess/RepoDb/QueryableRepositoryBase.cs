using RepoDb;
using RepoDbExample.Core.DataAccess.RepoDb.DbConnectionOptions;
using RepoDbExample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RepoDbExample.Core.DataAccess.RepoDb
{
    //public class DbRepositoryBase<TEntity, DbConnection> : IRepository<TEntity>
    //     where TEntity : class, IEntity, new()
    //     where DbConnection : IDatabaseConnectionFactory, new()

    public class QueryableRepositoryBase<TEntity, DbConnection> : IQueryableRepository<TEntity>
        where TEntity : class, IDto, new()
        where DbConnection : IDatabaseConnectionFactory, new()
    {

        //public IEnumerable<T> GetByExecuteTextQuery(
        //                                   Expression<Func<T, bool>> query = null, 
        //                                   Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, 
        //                                   string includeProperties = ""
        //                                )
        //{
        //    throw new NotImplementedException();
        //}


        //public IEnumerable<T> GetByExecuteProcedureQuery(Expression<Func<T, bool>> query = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<T> SiraliGetir(Expression<Func<T, bool>> filter = null, IEnumerable<OrderField> queryOrderBy = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<T> GetByExecuteTextQuery(string commandText, object param = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<T> GetByExecuteStoredProcedureQuery(string commandText, object param = null)
        //{
        //    throw new NotImplementedException();
        //}
       

        public IEnumerable<TEntity> GetByExecuteTextQuery(string commandText, object param = null)
        {
            using var conn = new DbConnection().CreateConnection();
            var data = conn.ExecuteQuery<TEntity>(commandText, param, CommandType.Text);
            return data;
        }

        public IEnumerable<TEntity> GetByExecuteStoredProcedureQuery(string commandText, object param = null)
        {
            using var conn = new DbConnection().CreateConnection();
            var data = conn.ExecuteQuery<TEntity>(commandText, param, CommandType.StoredProcedure);
            return data;
        }
    }
}
