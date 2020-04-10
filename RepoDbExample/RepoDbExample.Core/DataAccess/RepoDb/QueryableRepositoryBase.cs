using RepoDbExample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RepoDbExample.Core.DataAccess.RepoDb
{
    public class QueryableRepositoryBase<T> : IQueryableRepository<T> where T : class, IEntity, new()
    {
        public IEnumerable<T> GetByQuery(
                                           Expression<Func<T, bool>> query = null, 
                                           Func<IQueryable<T>, 
                                           IOrderedQueryable<T>> orderBy = null, 
                                           string includeProperties = ""
                                        )
        {
            throw new NotImplementedException();
        }
    }
}
