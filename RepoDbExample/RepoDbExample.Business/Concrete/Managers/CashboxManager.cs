using RepoDb;
using RepoDbExample.Business.Abstract;
using RepoDbExample.DataAccess.Abstract;
using RepoDbExample.Entites.Models.PostgreSql.Finans;
using RepoDbExample.Entites.Models.PostgreSql.Finans.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace RepoDbExample.Business.Concrete.Managers
{
    public class CashboxManager : ICashboxService
    {
        private readonly ICashboxDal _cashboxDal;
        public CashboxManager(ICashboxDal cashboxDal) => _cashboxDal = cashboxDal;
        public List<FinanceSummaryDto> GetFinancialCashDalOperationJoin() => _cashboxDal.GetFinancialCashDalOperation();
    }
}