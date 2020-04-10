using RepoDb;
using RepoDbExample.Business.Abstract;
using RepoDbExample.DataAccess.Abstract;
using RepoDbExample.Entites.Models.Sql.AdemBlogDb;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace RepoDbExample.Business.Concrete.Managers
{
    public class PostManager : IPostService
    {
       private readonly  IPostDal _postDal;
        public PostManager(IPostDal postDal)
        {
            _postDal = postDal;
        }

        public IEnumerable<Post> SiraliGetir(Expression<Func<Post, bool>> filter = null, IEnumerable<OrderField> queryOrderBy = null)
        {
            return _postDal.GetListOrderByQuery(filter, queryOrderBy);
        }
    }
}
