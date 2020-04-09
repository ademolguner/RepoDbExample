using RepoDb;
using RepoDbExample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepoDbExample.Core.DataAccess
{
    public interface IRepository<T> where T : class, IEntity, new()

    {

        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        T Insert(T entity);
        int Update(T entity);
        int Delete(T entity);

        // BULK ISlemleri
        int BulkInsert(IEnumerable<T> bulkInsetData);
        int BulkUpdate(IEnumerable<T> bulkUpdateData);
        int BulkDelete(IEnumerable<T> bulkDeleteData);




        Task<List<T>> GetListAsync(Expression<Func<T, bool>> filter = null);
        Task<T> GetAsync(Expression<Func<T, bool>> filter);
        Task<T> InsertAsync(T entity);
        Task<int> UpdateAsync(T entity);
        Task<int> DeleteAsync(T entity);

        Task<int> BulkInsertAsync(IEnumerable<T> bulkInsetData);
        Task<int> BulkUpdateAsync(IEnumerable<T> bulkUpdateData);
        Task<int> BulkDeleteAsync(IEnumerable<T> bulkDeleteData);
    }
}
