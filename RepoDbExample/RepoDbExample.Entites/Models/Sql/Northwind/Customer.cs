using RepoDbExample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace RepoDbExample.Entites.Models.Sql.Northwind
{
    public class Customer : IEntity
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }


        public string CustomerID { get; set; }
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

        public virtual ICollection<Order> Orders { get; set; }
    }
}
