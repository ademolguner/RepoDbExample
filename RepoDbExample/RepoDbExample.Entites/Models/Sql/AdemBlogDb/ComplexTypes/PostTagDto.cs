using RepoDbExample.Core.Entities;

namespace RepoDbExample.Entites.Models.Sql.AdemBlogDb.ComplexTypes
{
    public class PostTagDto : IEntity, ISqlEntityType
    {
        public string TagValueName { get; set; }
    }
}
