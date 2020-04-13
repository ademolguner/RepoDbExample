using RepoDbExample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDbExample.Entites.Models.PostgreSql.Finans.ComplexTypes
{
   public  class CashboxInfo: IDto, IMySqlEntityType
    {
        public int CashboxId { get; set; }
        public int CashTypeId { get; set; }
        public string CashTypeName { get; set; }
        public decimal TotalQuantity { get; set; }
    }
}
