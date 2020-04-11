using RepoDbExample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepoDbExample.Entites.Models.Sql.AdemBlogDb.ComplexTypes
{
    public class PostInfo : IDto, ISqlEntityType
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
