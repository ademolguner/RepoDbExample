using System;
using System.Collections.Generic;
using System.Text;
using RepoDbExample.Core.Entities;

namespace RepoDbExample.Entites.Models.Sql.Northwind
{
    public class Category : IEntity, ISqlEntityType
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
