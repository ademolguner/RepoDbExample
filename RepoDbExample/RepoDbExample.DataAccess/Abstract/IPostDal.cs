using RepoDbExample.Core.DataAccess;
using RepoDbExample.Entites.Models.Sql.AdemBlogDb;

namespace RepoDbExample.DataAccess.Abstract
{
    public interface IPostDal : IRepository<Post>
    {
    }
}