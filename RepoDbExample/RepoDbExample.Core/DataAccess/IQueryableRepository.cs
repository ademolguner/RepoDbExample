using RepoDb;
using RepoDbExample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RepoDbExample.Core.DataAccess
{
    public interface IQueryableRepository<T> where T : class, IDto, new()
    {
        IEnumerable<T> GetByExecuteTextQuery(string commandText, object param = null);
        IEnumerable<T> GetByExecuteStoredProcedureQuery(string commandText, object param = null);

        //ExecuteQueryMultiple
    }
}
