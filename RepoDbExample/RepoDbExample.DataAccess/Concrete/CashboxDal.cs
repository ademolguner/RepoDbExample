using RepoDb;
using RepoDbExample.Core.DataAccess.RepoDb;
using RepoDbExample.DataAccess.Abstract;
using RepoDbExample.DataAccess.Concrete.DbConnection.PostgreSqLConnectionDatabases;
using RepoDbExample.Entites.Models.PostgreSql.Finans;
using RepoDbExample.Entites.Models.PostgreSql.Finans.ComplexTypes;
using System.Collections.Generic;
using System.Linq;

namespace RepoDbExample.DataAccess.Concrete
{
    public class CashboxDal : DbRepositoryBase<Cashbox, FinansDbConnectionFactory>, ICashboxDal
    {
        public List<FinanceSummaryDto> GetFinancialCashDalOperation()
        {
            var dbConn = new FinansDbConnectionFactory().CreateConnection().EnsureOpen();

            var model = from cb in dbConn.QueryAll<Cashbox>()
                        join ct in dbConn.QueryAll<CashType>() on cb.CashTypeId equals ct.CashTypeId
                        group cb by new 
                               { 
                                  cb.CashTypeId, 
                                  ct.CashTypeName 
                               } into groupData
                        select new FinanceSummaryDto
                        {
                            CashTypeName = groupData.Key.CashTypeName,
                            TotalQuantity = groupData.Sum(x => x.TotalQuantity)
                        };

            return model.ToList();
        }
    }
}