using RepoDbExample.Core.Entities;

using System.Collections.Generic;

namespace RepoDbExample.Core.DataAccess
{
    public interface IQueryableRepository<T> where T : class, IDto, new()
    {
        IEnumerable<T> GetByExecuteTextQuery(string commandText, object param = null);

        IEnumerable<T> GetByExecuteStoredProcedureQuery(string commandText, object param = null);
    }
}