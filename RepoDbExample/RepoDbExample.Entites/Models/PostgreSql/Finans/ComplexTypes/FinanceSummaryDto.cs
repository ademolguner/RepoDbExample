using RepoDbExample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDbExample.Entites.Models.PostgreSql.Finans.ComplexTypes
{
    public class FinanceSummaryDto : IDto, IMySqlEntityType
    { 
        public string CashTypeName { get; set; }
        public decimal TotalQuantity { get; set; }
    }
}
