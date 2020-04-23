using RepoDbExample.Core.DataAccess;
using RepoDbExample.Entites.Models.PostgreSql.Finans;
using RepoDbExample.Entites.Models.PostgreSql.Finans.ComplexTypes;
using System.Collections.Generic;

namespace RepoDbExample.DataAccess.Abstract
{
    public interface ICashboxDal : IRepository<Cashbox>
    {
        List<FinanceSummaryDto> GetFinancialCashDalOperation();
    }
}

