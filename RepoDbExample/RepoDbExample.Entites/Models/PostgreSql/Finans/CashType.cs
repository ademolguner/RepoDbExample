using RepoDbExample.Core.Entities;

namespace RepoDbExample.Entites.Models.PostgreSql.Finans
{
    public class CashType : IEntity
    {
        public int CashTypeId { get; set; }
        public string CashTypeName { get; set; }
    }
}