using RepoDbExample.Core.DataAccess;
using RepoDbExample.Entites.Models.Sql.AdemBlogDb;
using RepoDbExample.Entites.Models.Sql.AdemBlogDb.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace RepoDbExample.DataAccess.Abstract
{
    public interface IPostDal : IRepository<Post>
    {
    }
}
