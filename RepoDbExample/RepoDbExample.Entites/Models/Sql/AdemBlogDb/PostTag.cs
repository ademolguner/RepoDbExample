using RepoDbExample.Core.Entities;

namespace RepoDbExample.Entites.Models.Sql.AdemBlogDb
{
    public class PostTag : IEntity, ISqlEntityType
    {
        public int PostTagId { get; set; }
        public int PostId { get; set; }
        public int TagId { get; set; }
    }
}