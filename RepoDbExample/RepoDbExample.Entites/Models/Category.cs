using System;
using System.Collections.Generic;
using System.Text; 
using RepoDbExample.Core.Entities;

namespace RepoDbExample.Entites.Models
{
    public class Category : IEntity
    {
        public Category()
        {
            this.Products = new HashSet<Product>();
        }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
