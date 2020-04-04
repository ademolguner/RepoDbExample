using RepoDbExample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RepoDbExample.Core.DataAccess
{
    public interface IRepository<T>  where T : class, IEntity, new()
        
    {
        //List<T> GetList(Expression<Func<T, bool>> filter = null);
        //T Get(Expression<Func<T, bool>> filter);

        //void Add(T entity);

        //void Update(T entity);

        //void Delete(T entity);


        //RepoDB query tipleri
        IEnumerable<T> QueryAll(T entity);

        //List<T> BulkDelete<T>(List<T> bulkInsetData);
        //List<T> BulkInsert<T>(List<T> bulkInsetData);

        //List<T> InsertAll<T>(List<T> insertAllList) where T:IEntity, new();

        void Insert(T entity);
        //void DeleteAll(List<T> deletedAllList);




    }
}
