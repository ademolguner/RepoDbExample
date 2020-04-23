using RepoDbExample.Core.Entities;
using System;

namespace RepoDbExample.Entites.Models.Sql.AdemBlogDb.ComplexTypes
{
    public class PostInfoDto : IDto, ISqlEntityType
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CategoryName { get; set; }
        public string SmallContent { get; set; }
        public string TagNames { get; set; }
    }
}