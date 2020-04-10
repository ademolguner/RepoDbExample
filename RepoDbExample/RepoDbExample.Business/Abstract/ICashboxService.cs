using RepoDb;
using RepoDbExample.Entites.Models.PostgreSql.Finans;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RepoDbExample.Business.Abstract
{
    public interface ICashboxService
    {
        IEnumerable<Cashbox> QueryAll();
        void NewItem(Cashbox cashbox);

        IEnumerable<Cashbox> SiraliGetir(Expression<Func<Cashbox, bool>> filter = null, IEnumerable<OrderField> queryOrderBy = null);
    }
}
