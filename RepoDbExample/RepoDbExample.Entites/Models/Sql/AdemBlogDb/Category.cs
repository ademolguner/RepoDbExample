using RepoDbExample.Core.Entities;

namespace RepoDbExample.Entites.Models.Sql.AdemBlogDb
{
    public class Category : IEntity, ISqlEntityType
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}