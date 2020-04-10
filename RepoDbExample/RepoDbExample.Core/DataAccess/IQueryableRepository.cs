using RepoDbExample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RepoDbExample.Core.DataAccess
{
    public interface IQueryableRepository<T> where T : class, IEntity, new()
    {
        IEnumerable<T> GetByQuery(Expression<Func<T, bool>> query = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");
    }
}
