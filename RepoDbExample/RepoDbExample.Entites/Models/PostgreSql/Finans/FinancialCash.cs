using RepoDbExample.Core.Entities;
using System;

namespace RepoDbExample.Entites.Models.PostgreSql.Finans
{
    public class FinancialCash : IEntity, IPostgresqlEntityType
    {
        public FinancialCash()
        {
            LastUpdatedDate = DateTime.Now;
        }

        public int FinancialCashId { get; set; }
        public int CurrencyId { get; set; }
        public decimal CashCurrncy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}