 
using RepoDbExample.Core.Entities;
using System.Collections.Generic;

namespace RepoDbExample.Entites.Models.Sql.AdemBlogDb
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}