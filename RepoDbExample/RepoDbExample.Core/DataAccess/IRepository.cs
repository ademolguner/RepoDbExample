using RepoDb;
using RepoDbExample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepoDbExample.Core.DataAccess
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        //Standar CRUD işlemleri için metoto imzaları
        //List<T> GetList(Expression<Func<T, bool>> filter = null);


        List<T> GetList();
        List<T> GetList(Expression<Func<T, bool>> filter);
        List<T> GetList(IEnumerable<OrderField> orderByFilter);
        List<T> GetList(Expression<Func<T, bool>> filter, IEnumerable<OrderField> orderByFilter);
        List<T> GetList(int count);
        List<T> GetList(Expression<Func<T, bool>> filter, int count);
        List<T> GetList(IEnumerable<OrderField> orderByFilter, int count);
        List<T> GetList(Expression<Func<T, bool>> filter, IEnumerable<OrderField> orderByFilter, int count);




        T Get(Expression<Func<T, bool>> filter);
        T Get(Expression<Func<T, bool>> filter, IEnumerable<OrderField> orderByFilter);
        T Insert(T entity);
        int Update(T entity);
        int Delete(T entity);

        //BULK Işlemleri Metot imzaları
        int BulkInsert(IEnumerable<T> bulkInsetData);
        int BulkUpdate(IEnumerable<T> bulkUpdateData);
        int BulkDelete(IEnumerable<T> bulkDeleteData);



        // (Asenkron) Standar CRUD işlemleri için metoto imzaları 
        Task<List<T>> GetListAsync(Expression<Func<T, bool>> filter = null);
        Task<T> GetAsync(Expression<Func<T, bool>> filter);
        Task<T> InsertAsync(T entity);
        Task<int> UpdateAsync(T entity);
        Task<int> DeleteAsync(T entity);

        //(Asenkron) BULK Işlemleri Metot imzaları  
        Task<int> BulkInsertAsync(IEnumerable<T> bulkInsetData);
        Task<int> BulkUpdateAsync(IEnumerable<T> bulkUpdateData);
        Task<int> BulkDeleteAsync(IEnumerable<T> bulkDeleteData);

    }
}
