using RepoDbExample.Core.Entities;
using System;

namespace RepoDbExample.Entites.Models.PostgreSql.Finans
{
    public class Currency : IEntity
    {
        public int CurrencyId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal ForexBuying { get; set; }
        public decimal ForexSelling { get; set; }
        public decimal BanknoteBuying { get; set; }
        public decimal BanknoteSelling { get; set; }
        public DateTime LastUpdateTime { get; set; }
    }
}