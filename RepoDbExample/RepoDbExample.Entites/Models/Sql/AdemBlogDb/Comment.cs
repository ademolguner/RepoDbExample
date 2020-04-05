using RepoDbExample.Core.Entities;
using System;

namespace RepoDbExample.Entites.Models.Sql.AdemBlogDb
{
    public class Comment : IEntity
    {
        public int CommentId { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public string GuestFullName { get; set; }
        public bool IsDelete { get; set; }
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
