using RepoDbExample.Core.Entities;

namespace RepoDbExample.Entites.Models.PostgreSql.Finans.ComplexTypes
{
    public class FinanceSummaryDto : IDto, IMySqlEntityType
    {
        public string CashTypeName { get; set; }
        public decimal TotalQuantity { get; set; }
    }
}