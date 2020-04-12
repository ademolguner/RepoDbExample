using RepoDb;
using RepoDb.Enumerations;
using RepoDbExample.Core.DataAccess.RepoDb.DbConnectionOptions;
using RepoDbExample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RepoDbExample.Core.DataAccess.RepoDb
{
    public class DbRepositoryBase<TEntity, DbConnection> : IRepository<TEntity>
          where TEntity : class, IEntity, new()
          where DbConnection : IDatabaseConnectionFactory, new()
    {
        #region Standar CRUD işlemleri için metoto işlemleri


        public List<TEntity> GetList()
        {
            using var conn = new DbConnection().CreateConnection().EnsureOpen();
            var data = conn.QueryAll<TEntity>().ToList();
            return data;
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter)
        {
            using var conn = new DbConnection().CreateConnection().EnsureOpen();
            var data = conn.Query<TEntity>(where: filter).ToList();
            return data;
        }

        public List<TEntity> GetList(IEnumerable<OrderField> orderByFilter)
        {
            using var conn = new DbConnection().CreateConnection().EnsureOpen();
            var data = conn.QueryAll<TEntity>(orderBy: orderByFilter).ToList();
            return data;
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter, IEnumerable<OrderField> orderByFilter)
        {
            using var conn = new DbConnection().CreateConnection().EnsureOpen();
            var data = conn.Query<TEntity>(where: filter, orderBy: orderByFilter).ToList();
            return data;
        }

        public List<TEntity> GetList(int count)
        {
            using var conn = new DbConnection().CreateConnection().EnsureOpen();
            List<TEntity> data = conn.QueryAll<TEntity>().Take(count).ToList();
            return data;
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter, int count)
        {
            using var conn = new DbConnection().CreateConnection().EnsureOpen();
            List<TEntity> data = conn.Query<TEntity>(where: filter).Take(count).ToList();
            return data;
        }

        public List<TEntity> GetList(IEnumerable<OrderField> orderByFilter, int count)
        {
            using var conn = new DbConnection().CreateConnection().EnsureOpen();
            List<TEntity> data = conn.QueryAll<TEntity>(orderBy: orderByFilter).Take(count).ToList();
            return data;
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter, IEnumerable<OrderField> orderByFilter, int count)
        {
            using var conn = new DbConnection().CreateConnection().EnsureOpen();
            var data = conn.Query<TEntity>(where: filter, orderBy: orderByFilter, top: count).ToList();
            return data;
        }




        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using var conn = new DbConnection().CreateConnection().EnsureOpen();
            var data = conn.Query<TEntity>(filter).FirstOrDefault();
            return data;
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter, IEnumerable<OrderField> orderByFilter)
        {
            using var conn = new DbConnection().CreateConnection().EnsureOpen();
            var data = conn.Query<TEntity>(where: filter, orderBy: orderByFilter).FirstOrDefault();
            return data;
        }

        public TEntity Insert(TEntity entity)
        {
            using var conn = new DbConnection().CreateConnection().EnsureOpen();
            var data = conn.Insert(entity);
            return entity;
        }

        public int Update(TEntity entity)
        {
            using var conn = new DbConnection().CreateConnection().EnsureOpen();
            var rowsAffected = conn.Update(entity);
            return rowsAffected;
        }

        public int Delete(TEntity entity)
        {
            using var conn = new DbConnection().CreateConnection().EnsureOpen();
            var rowsAffected = conn.Delete(entity);
            return rowsAffected;
        }
        #endregion


        #region BULK Işlemleri Metot imzaları işlemleri
        public int BulkInsert(IEnumerable<TEntity> bulkInsetData)
        {
            using var conn = new DbConnection().CreateConnection().EnsureOpen();
            var rowsAffected = conn.InsertAll<TEntity>(bulkInsetData);
            return rowsAffected;
        }
        public int BulkUpdate(IEnumerable<TEntity> bulkUpdateData)
        {
            using var conn = new DbConnection().CreateConnection().EnsureOpen();
            var rowsAffected = conn.UpdateAll<TEntity>(bulkUpdateData);
            return rowsAffected;
        }
        public int BulkDelete(IEnumerable<TEntity> bulkDeleteData)
        {
            using var conn = new DbConnection().CreateConnection().EnsureOpen();
            var rowsAffected = conn.DeleteAll<TEntity>(bulkDeleteData);
            return rowsAffected;
        }
        #endregion



        #region (Asenkron) Standar CRUD işlemleri için metot işlemleri



        public async Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            using var conn = new DbConnection().CreateConnection().EnsureOpen();
            var data = await conn.QueryAllAsync<TEntity>();
            return data.ToList();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            using var conn = new DbConnection().CreateConnection().EnsureOpen();
            var data = await conn.QueryAsync<TEntity>(filter);
            return data.FirstOrDefault();
        }

        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            using var conn = new DbConnection().CreateConnection().EnsureOpen();
            var data = await conn.InsertAsync(entity);
            return entity;
        }

        public async Task<int> UpdateAsync(TEntity entity)
        {
            using var conn = new DbConnection().CreateConnection().EnsureOpen();
            var rowsAffected = conn.UpdateAsync(entity);
            return await rowsAffected;
        }

        public async Task<int> DeleteAsync(TEntity entity)
        {
            using var conn = new DbConnection().CreateConnection().EnsureOpen();
            var rowsAffected = conn.DeleteAsync(entity);
            return await rowsAffected;
        }
        #endregion

        #region(Asenkron) BULK Işlemleri Metot işlemleri
        public async Task<int> BulkInsertAsync(IEnumerable<TEntity> bulkInsetData)
        {
            using var conn = new DbConnection().CreateConnection().EnsureOpen();
            var rowsAffected = await conn.InsertAllAsync<TEntity>(bulkInsetData);
            return rowsAffected;
        }

        public async Task<int> BulkUpdateAsync(IEnumerable<TEntity> bulkUpdateData)
        {
            using var conn = new DbConnection().CreateConnection().EnsureOpen();
            var rowsAffected = await conn.UpdateAllAsync<TEntity>(bulkUpdateData);
            return rowsAffected;
        }

        public async Task<int> BulkDeleteAsync(IEnumerable<TEntity> bulkDeleteData)
        {
            using var conn = new DbConnection().CreateConnection().EnsureOpen();
            var rowsAffected = await conn.DeleteAllAsync<TEntity>(bulkDeleteData);
            return rowsAffected;
        }









        #endregion


        #region sql stringtext veya stored procedure işlemleri
        //public List<TEntity> GetListOrderByQuery(Expression<Func<TEntity, bool>> filter = null, IEnumerable<OrderField> queryOrderBy = null)
        //{
        //    using var conn = new DbConnection().CreateConnection().EnsureOpen();
        //    var data = conn.Query<TEntity>(filter, orderBy: queryOrderBy).ToList();
        //    return data;
        //}





        //public IEnumerable<TEntity> ExecuteQuery(string commandText, object param = null, CommandType? commandType = null)
        //{
        //    using var conn = new DbConnection().CreateConnection().EnsureOpen();
        //    var data = conn.ExecuteQuery<TEntity>(commandText, param, commandType);
        //    return data;
        //}



        //public IEnumerable<TEntity> ExecuteQuery(string commandText, object param = null, CommandType? commandType = null)
        //{
        //    using var dbCconnection = new DbConnection().CreateConnection().EnsureOpen();
        //    var data = dbCconnection.ExecuteQuery<TEntity>(commandText, param, commandType);
        //    return data;
        //}

        #endregion


        #region  Kontrol Metotoları

        //private bool GetClassAttrşbutesControl(object className, IEnumerable<OrderField> orderFields)
        //{
        //    Type myType = typeof(className.GetType());

        //    var myPropInfo2 = myType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

        //    bool a = myPropInfo2.Any(c => orderFields.Select(x=> x.Name).ToList().Contains(c));
        //    //orderFields.Where(x=> x.Name)


        //    foreach (var item in orderFields)
        //    {
        //        myPropInfo2.Any(x=> x.Name.Contains(item.Name))
        //    }

        //    return true;
        //}

        #endregion
    }
}
