using RepoDbExample.Core.Entities;

namespace RepoDbExample.Entites.Models.Sql.AdemBlogDb
{
    public class Tag : IEntity, ISqlEntityType
    {
        public int TagId { get; set; }
        public string TagName { get; set; }

    }
}
