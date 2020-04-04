﻿using RepoDbExample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDbExample.Entites.Models
{
    public   class OrderDetail : IEntity
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
