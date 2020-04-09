using RepoDbExample.Core.Entities;

namespace RepoDbExample.Entites.Models.PostgreSql.Finans
{
    public class Cashbox : IEntity, IPostgresqlEntityType
    {
        public int CashboxId { get; set; }
        public int CashTypeId { get; set; }
        public decimal TotalQuantity { get; set; }
    }
}