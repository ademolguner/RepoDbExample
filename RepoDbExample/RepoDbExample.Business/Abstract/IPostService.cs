using RepoDb;
using RepoDbExample.Entites.Models.Sql.AdemBlogDb;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RepoDbExample.Business.Abstract
{
   public interface IPostService
    {
        IEnumerable<Post> SiraliGetir(Expression<Func<Post, bool>> filter = null, IEnumerable<OrderField> queryOrderBy = null);
    }
}
