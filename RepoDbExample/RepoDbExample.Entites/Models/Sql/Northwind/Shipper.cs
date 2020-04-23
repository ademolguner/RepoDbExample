using RepoDbExample.Core.Entities;
using System.Collections.Generic;

namespace RepoDbExample.Entites.Models.Sql.Northwind
{
    public class Shipper : IEntity, ISqlEntityType
    {
        public Shipper()
        {
            Orders = new HashSet<Order>();
        }

        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}