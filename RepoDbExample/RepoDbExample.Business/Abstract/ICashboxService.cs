using RepoDbExample.Entites.Models.PostgreSql.Finans.ComplexTypes;
using System.Collections.Generic;

namespace RepoDbExample.Business.Abstract
{
    public interface ICashboxService
    { 
        List<FinanceSummaryDto> GetFinancialCashDalOperationJoin();
    }
}