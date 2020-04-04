﻿using RepoDbExample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDbExample.Entites.Models
{
   public class Order : IEntity
    {
         public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<System.DateTime> RequiredDate { get; set; }
        public Nullable<System.DateTime> ShippedDate { get; set; }
        public Nullable<int> ShipVia { get; set; }
        public Nullable<decimal> Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }



        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual Shipper Shipper { get; set; }
    }
}
