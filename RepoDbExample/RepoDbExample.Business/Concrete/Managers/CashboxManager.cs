using RepoDbExample.Business.Abstract;
using RepoDbExample.DataAccess.Abstract;
using RepoDbExample.Entites.Models.PostgreSql.Finans;
using System;
using System.Collections.Generic;
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
           return _cashboxDal.QueryAll();
        }
    }
}
