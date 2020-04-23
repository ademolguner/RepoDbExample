using RepoDbExample.Core.Entities;
using System;
using System.Collections.Generic;

namespace RepoDbExample.Entites.Models.Sql.Northwind
{
    public class Customer : IEntity, ISqlEntityType
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}