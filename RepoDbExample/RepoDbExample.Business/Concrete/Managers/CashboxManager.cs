using RepoDb;
using RepoDbExample.Business.Abstract;
using RepoDbExample.DataAccess.Abstract;
using RepoDbExample.Entites.Models.PostgreSql.Finans;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RepoDbExample.Business.Concrete.Managers
{
    public class CashboxManager : ICashboxService
    {
        private readonly ICashboxDal _cashboxDal;

        public CashboxManager(ICashboxDal cashboxDal)
        {
            _cashboxDal = cashboxDal;
        }

        public void NewItem(Cashbox cashbox)
        {
            _cashboxDal.Insert(cashbox);
        }

        public IEnumerable<Cashbox> QueryAll()
        {
           return _cashboxDal.GetList();
        }

        public IEnumerable<Cashbox> SiraliGetir(Expression<Func<Cashbox, bool>> filter = null, IEnumerable<OrderField> queryOrderBy = null)
        {
            return _cashboxDal.GetListOrderByQuery(filter, queryOrderBy);
        }
         
    }
}
